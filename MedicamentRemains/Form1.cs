using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ZcrlMedicamentModels;

namespace MedicamentRemains
{
    public partial class Form1 : Form
    {
        private BindingList<MedicamentRemain> medRemainsList;
        private List<int> existingMedicamentsInTable;
        private bool programIsRunned = false;

        // Очередь запросов на внесение изменений в БД
        private Queue<DbRecordChangesTask> dbUpdatesQueue;

        // Блокировщик потоков (для синхронизации)
        private object locker = new object();

        private static Color failColor = Color.FromArgb(255, 0, 0);
        private static Color successColor = Color.FromArgb(0, 255, 0);

        public Form1()
        {
            LoadingProgramForm lf = new LoadingProgramForm();
            lf.ShowDialog();

            // Окно загрузки программы (проверяеться соединение с Интернетом и БД)
            string loadingError = lf.ErrorMessage;
            if(!string.IsNullOrWhiteSpace(loadingError))
            {
                NotificationHelper.ShowError(loadingError);
                Environment.Exit(0);
            }

            InitializeComponent();
            lastUpdateLabel.Text = string.Empty;

            existingMedicamentsInTable = new List<int>();

            remainsTable.AutoGenerateColumns = false;
            medRemainsList = new BindingList<MedicamentRemain>();
            remainsTable.DataSource = medRemainsList;

            checkInternetTimer.Start();

            dbUpdatesQueue = new Queue<DbRecordChangesTask>();
            checkDbTasksTimer.Start();

            InitializeDepartmentCBList();
            LoadTableData(0);

            programIsRunned = true;
        }

        private void InitializeDepartmentCBList()
        {
            using(MedicamentRemainsContext mc = new MedicamentRemainsContext())
            {
                List<HospitalDepartment> deps = mc.HospitalDepartments.ToList();
                deps.Insert(0, new HospitalDepartment { Id = -1, Name = "- УСІ ВІДДІЛЕННЯ -" });
                departmentsCBList.DataSource = deps;
                departmentsCBList.DisplayMember = "Name";
                departmentsCBList.ValueMember = "Id";

                int selectedDepartmentId = Convert.ToInt32(departmentsCBList.SelectedValue);
                remainsTable.ReadOnly = selectedDepartmentId < 0;
            }
        }

        private void LoadTableData(int selectedDepartmentId)
        {
            ToggleLoadingAnimation();
            remainsLoadWorker.RunWorkerAsync(selectedDepartmentId);
        }

        // Анимация загрузки данных в таблицу
        private void ToggleLoadingAnimation()
        {
            remainsTable.Enabled = !remainsTable.Enabled;
            loadingPicture.Visible = loadingLabel.Visible = !loadingLabel.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedicamentRemain selectedItem = remainsTable.CurrentRow.DataBoundItem as MedicamentRemain;

            if (selectedItem.Medicament != null && 
                NotificationHelper.ShowQuestion("Ви впевнені, що хочете видалити виділений елемент?") != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            int deletingRowIndex = remainsTable.CurrentRow.Index;

            if(selectedItem.Medicament != null)
            {
                existingMedicamentsInTable.Remove(selectedItem.Medicament.Id);
            }

            remainsTable.Rows.RemoveAt(deletingRowIndex);
            RecalculateRowsNumbers(deletingRowIndex);

            if (selectedItem.Id > 0)
            {
                backgroundDbUpdateWorker.RunWorkerAsync(new DbRecordChangesTask { DbRecord = selectedItem, ChangesType = DbRecordChangesType.Remove });
                medRemainsList.Remove(selectedItem);
            }
        }

        private void remainsLoadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Очищаем список выбраных в отделении медикаментов для формирования нового
            existingMedicamentsInTable.Clear();

            using (MedicamentRemainsContext mc = new MedicamentRemainsContext())
            {
                int selectedDepartmentId = Convert.ToInt32(e.Argument);

                if (selectedDepartmentId > 0)
                {
                    medRemainsList = new BindingList<MedicamentRemain>(mc.MedicamentRemains.Include(p => p.Medicament).Include(p => p.Medicament.Meter)
                        .Where(p => p.HospitalDepartmentId == selectedDepartmentId).OrderBy(p => p.Medicament.Name).ToList());
                }
                else
                {
                    // Не даём посчитать итоги пока очередь изменений в БД не обслужена
                    while (dbUpdatesQueue.Count > 0 && !backgroundDbUpdateWorker.IsBusy)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }

                    var fullMedRemains = mc.MedicamentRemains.Include(p => p.Medicament).Include(p => p.Medicament.Meter).ToList();
   
                    medRemainsList = new BindingList<MedicamentRemain>(
                        (from item in fullMedRemains
                            group item by item.Medicament into g
                            select new MedicamentRemain
                            {
                                Medicament = g.Key,
                                CurrentRemain = g.Sum(p => p.CurrentRemain),
                                MedicamentId = g.Key.Id
                            } into selection
                            orderby selection.Medicament.Name
                            select selection
                        ).ToList());
                }

                existingMedicamentsInTable = (from item in medRemainsList select item.Medicament.Id).ToList();
            }
        }

        private void remainsLoadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            remainsTable.DataSource = medRemainsList;
            for (int i = 0; i < remainsTable.RowCount; i++)
            {
                MedicamentRemain row = remainsTable.Rows[i].DataBoundItem as MedicamentRemain;
                if (row.Medicament != null)
                {
                    remainsTable.Rows[i].Cells[4].Value = row.Medicament.Meter;
                }
            }

            remainsTable.Update();
            departmentsCBList.Enabled = true;

            int selectedDepId = Convert.ToInt32(departmentsCBList.SelectedValue);
            if(selectedDepId > 0)
                addRecord.Enabled = true;

            ToggleLoadingAnimation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicamentRemain newMedRem = new MedicamentRemain();
            newMedRem.HospitalDepartmentId = Convert.ToInt32(departmentsCBList.SelectedValue);
            medRemainsList.Add(newMedRem);
            remainsTable.CurrentCell = remainsTable.Rows[remainsTable.Rows.Count - 1].Cells[2];
        }

        // Пересчёт значений столбца с номерами строк (необходимо при удалении строки)
        private void RecalculateRowsNumbers(int startRowNumber)
        {
            for(int i = startRowNumber; i < remainsTable.Rows.Count; i++)
            {
                remainsTable.Rows[i].Cells[1].Value = (i + 1);
            }
        }

        private void remainsTable_SelectionChanged(object sender, EventArgs e)
        {
            int selectedDepartment = Convert.ToInt32(departmentsCBList.SelectedValue);
            removeRecord.Enabled = (remainsTable.SelectedCells.Count > 0) && (selectedDepartment > 0);
        }

        private void remainsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for(int i = 0; i < e.RowCount; i++)
            {
                MedicamentRemain rowMedRemain = remainsTable.Rows[e.RowIndex].DataBoundItem as MedicamentRemain;
                remainsTable.Rows[e.RowIndex + i].Cells[1].Value = (e.RowIndex + i + 1);

                if (rowMedRemain.Medicament != null)
                {
                    remainsTable.Rows[e.RowIndex + i].Cells[4].Value = rowMedRemain.Medicament.Meter;
                }
            }
        }

        private void departmentsCBList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedDepartmentId = Convert.ToInt32(departmentsCBList.SelectedValue);
            remainsTable.ReadOnly = selectedDepartmentId < 0;
            
            // Отключаем возможность редактирование записей на общих итогах
            if(selectedDepartmentId < 0)
            {
                addRecord.Enabled = removeRecord.Enabled = false;
            }
            else
            {
                addRecord.Enabled =  true;
                removeRecord.Enabled = (remainsTable.SelectedCells.Count > 0);
            }

            if(programIsRunned && !remainsLoadWorker.IsBusy)
            {
                departmentsCBList.Enabled = false;
                addRecord.Enabled = false;
                LoadTableData(selectedDepartmentId);
            }
        }

        private void remainsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if((e.ColumnIndex == 3 || e.ColumnIndex == 2) && e.RowIndex >= 0)
            {
                MedicamentRemain currentElement = remainsTable.Rows[e.RowIndex].DataBoundItem as MedicamentRemain;

                // Форматируем введённый остаток (добавляем десятичную часть)
                //string formatedRemain = currentElement.CurrentRemain.ToString("F4");
                //remainsTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToDecimal(formatedRemain);
                
                if(currentElement.Medicament != null && currentElement.Id > 0)
                {
                    SendUpdateDbTask(new DbRecordChangesTask { DbRecord = currentElement, ChangesType = DbRecordChangesType.Update });
                }
            }
        }

        // Смена медикамента при двойном клике на ячейку таблицы
        private void remainsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Убираем возможность смены медикамента, если выбран показ итогов по остаткам
            int selectedDepartmentId = Convert.ToInt32(departmentsCBList.SelectedValue);
            if(selectedDepartmentId < 0)
            {
                return;
            }

            MedicamentRemain currentElement = remainsTable.Rows[e.RowIndex].DataBoundItem as MedicamentRemain;

            if (e.ColumnIndex == 2)
            {
                MedicamentSelectForm mf = new MedicamentSelectForm(existingMedicamentsInTable);
                mf.ShowDialog();
                if (mf.SelectedMedicament != null)
                {
                    if(currentElement.Medicament != null)
                    {
                        existingMedicamentsInTable.Remove(currentElement.Medicament.Id);
                    }
                    existingMedicamentsInTable.Add(mf.SelectedMedicament.Id);

                    remainsTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = mf.SelectedMedicament;
                    remainsTable.Rows[e.RowIndex].Cells[4].Value = mf.SelectedMedicament.Meter;
                    currentElement.MedicamentId = mf.SelectedMedicament.Id;

                    if (currentElement.Id == 0)
                    {
                        SendUpdateDbTask(new DbRecordChangesTask { DbRecord = currentElement, ChangesType = DbRecordChangesType.Create });
                    }
                    else
                    {
                        SendUpdateDbTask(new DbRecordChangesTask { DbRecord = currentElement, ChangesType = DbRecordChangesType.Update });
                    }
                }
            }
        }

        private void SendUpdateDbTask(DbRecordChangesTask task)
        {
            lock (locker)
            {
                if (!backgroundDbUpdateWorker.IsBusy)
                {
                    backgroundDbUpdateWorker.RunWorkerAsync(task);
                }
                else
                {
                    dbUpdatesQueue.Enqueue(task);
                } 
            }
        }

        // Обновляем данные в БД в фоновом режиме
        private void backgroundDbUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DbRecordChangesTask updateDbTask = e.Argument as DbRecordChangesTask;

            try
            {
                using (MedicamentRemainsContext mc = new MedicamentRemainsContext())
                {
                    MedicamentRemain record = updateDbTask.DbRecord as MedicamentRemain;
                    record.UpdateDate = DateTime.Now;

                    switch (updateDbTask.ChangesType)
                    {
                        case DbRecordChangesType.Create:
                            backgroundDbUpdateWorker.ReportProgress(0, "Створення запису по медикаменту " + record.Medicament + " ...");

                            mc.Medicaments.Attach(record.Medicament);
                            mc.MedicamentRemains.Add(record);
                            mc.SaveChanges();

                            backgroundDbUpdateWorker.ReportProgress(0, "Запис успішно доданий до бази данних!");
                            break;

                        case DbRecordChangesType.Update:
                            backgroundDbUpdateWorker.ReportProgress(0, "Оновлення запису по медикаменту " + record.Medicament + " ...");

                            mc.Medicaments.Attach(record.Medicament);
                            mc.Entry<MedicamentRemain>(record).State = System.Data.Entity.EntityState.Modified;
                            mc.SaveChanges();

                            backgroundDbUpdateWorker.ReportProgress(0, "Запис успішно оновлений у базі данних!");
                            break;

                        case DbRecordChangesType.Remove:
                            backgroundDbUpdateWorker.ReportProgress(0, "Видалення запису по медикаменту " + record.Medicament + " ...");

                            MedicamentRemain item = mc.MedicamentRemains.Where(p => (p.Id == record.Id)).First();
                            mc.MedicamentRemains.Remove(item);
                            mc.SaveChanges();

                            backgroundDbUpdateWorker.ReportProgress(0, "Запис успішно видалений з бази данних!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundDbUpdateWorker.ReportProgress(0, "Помилка: " + ex.Message);
            }

            // Задержка, чтобы пользователь смог прочитать сообщение об успехе операции либо об ошибке
            System.Threading.Thread.Sleep(3000);
        }

        private void backgroundDbUpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lastUpdateLabel.Text = string.Empty;
        }

        private void backgroundDbUpdateWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lastUpdateLabel.Text = e.UserState.ToString();
        }

        private void metersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleElementListForm sf = new SimpleElementListForm(new Meter());
            sf.ShowDialog();
        }

        private void departmentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleElementListForm sf = new SimpleElementListForm(new HospitalDepartment());
            sf.ShowDialog();

            if(sf.IsDepartmentListUpdated)
            {
                programIsRunned = false;
                InitializeDepartmentCBList();
                programIsRunned = true;
                departmentsCBList.SelectedValue = -1;
            }
        }

        private void medGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleElementListForm sf = new SimpleElementListForm(new MedicamentGroup());
            sf.ShowDialog();
        }

        private void checkDbTasksTimer_Tick(object sender, EventArgs e)
        {
            lock(locker)
            {
                if(dbUpdatesQueue.Count > 0 && !backgroundDbUpdateWorker.IsBusy)
                {
                    backgroundDbUpdateWorker.RunWorkerAsync(dbUpdatesQueue.Dequeue());
                }
            }
        }

        private void medicamentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicamentsListForm mf = new MedicamentsListForm();
            mf.ShowDialog();
        }

        private void checkInternetTimer_Tick(object sender, EventArgs e)
        {
            if(!NetHelper.IsConnectedToInternet())
            {
                internetConnectionLabel.Text = "Відсутній";
                internetConnectionLabel.ForeColor = failColor;
                dbAvailableLabel.Text = "Недоступна";
                dbAvailableLabel.ForeColor = failColor;
                return;
            }
            else
            {
                internetConnectionLabel.Text = "Наявний";
                internetConnectionLabel.ForeColor = successColor;
            }

            if (!NetHelper.IsDatabaseAvailable())
            {
                dbAvailableLabel.Text = "Недоступна";
                dbAvailableLabel.ForeColor = failColor;
            }
            else
            {
                dbAvailableLabel.Text = "Доступна";
                dbAvailableLabel.ForeColor = successColor;
            }
        }
    }
}
