using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZcrlMedicamentModels;

namespace MedicamentRemains
{
    public partial class SimpleElementListForm : Form
    {
        private BindingList<Meter> metersList;
        private BindingList<HospitalDepartment> depList;
        private BindingList<MedicamentGroup> medGroupList;

        private bool isDepartmentListUpdated;

        public bool IsDepartmentListUpdated
        {
            get
            {
                return isDepartmentListUpdated;
            }
        }

        private Queue<DbRecordChangesTask> updateDbTasksQueue;

        private object lockObject = new object();

        private object tableItem;

        public SimpleElementListForm(object tableItem)
        {
            InitializeComponent();

            isDepartmentListUpdated = false;

            dataTable.AutoGenerateColumns = false;

            updateDbTasksQueue = new Queue<DbRecordChangesTask>();
            checkTaskQueueTimer.Start();

            dbWorkResultLabel.Text = string.Empty;

            this.tableItem = tableItem;

            using (MedicamentRemainsContext mc = new MedicamentRemainsContext())
            {
                if (tableItem is Meter)
                {
                    metersList = new BindingList<Meter>(mc.Meters.ToList());
                    dataTable.DataSource = metersList;
                }
                else if (tableItem is HospitalDepartment)
                {
                    depList = new BindingList<HospitalDepartment>(mc.HospitalDepartments.ToList());
                    dataTable.DataSource = depList;
                }
                else if (tableItem is MedicamentGroup)
                {
                    medGroupList = new BindingList<MedicamentGroup>(mc.MedicamentsGroups.ToList());
                    dataTable.DataSource = medGroupList;
                    dataTable.Columns[3].Visible = true;
                }
                else
                {
                    throw new InvalidOperationException("Invalid type of object");
                }
            }
        }

        private void SetDataToDb(DbRecordChangesTask dbTask)
        {
            if(!dbUpdateWorker.IsBusy)
            {
                dbUpdateWorker.RunWorkerAsync(dbTask);
            }
            else
            {
                updateDbTasksQueue.Enqueue(dbTask);
            }
        }



        private void addMeterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tableItem is Meter)
            {
                metersList.Add(new Meter { Name =  "- НОВИЙ ЕЛЕМЕНТ -" });
            }
            else if (tableItem is HospitalDepartment)
            {
                depList.Add(new HospitalDepartment { Name = "- НОВИЙ ЕЛЕМЕНТ -" });
            }
            else if (tableItem is MedicamentGroup)
            {
                medGroupList.Add(new MedicamentGroup { Name = "- НОВИЙ ЕЛЕМЕНТ -" });
            }

            dataTable.CurrentCell = dataTable.Rows[dataTable.Rows.Count - 1].Cells[2];
        }

        private void RecalculateRowsNumbers(int startRowNumber)
        {
            for (int i = startRowNumber; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i].Cells[1].Value = (i + 1);
            }
        }

        private void metersTable_SelectionChanged(object sender, EventArgs e)
        {
            removeMeterLink.Enabled = (dataTable.SelectedCells.Count > 0);
        }

        private void metersTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < e.RowCount; i++)
            {
                dataTable.Rows[e.RowIndex + i].Cells[1].Value = (e.RowIndex + (i + 1));
            }
        }

        private void dataTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
                {
                    if (dataTable.Rows[e.RowIndex].Cells[2].Value == null || string.IsNullOrEmpty(dataTable.Rows[e.RowIndex].Cells[2].Value.ToString()))
                    {
                        dataTable.Rows[e.RowIndex].Cells[2].Value = "- НОВИЙ ЕЛЕМЕНТ -";
                        return;
                    }

                    if(dataTable.Rows[e.RowIndex].Cells[2].Value.ToString().Trim().CompareTo("- НОВИЙ ЕЛЕМЕНТ -") == 0)
                    {
                        return;
                    }

                    object tableItem = dataTable.Rows[e.RowIndex].DataBoundItem;
                    int itemId = Convert.ToInt32(dataTable.Rows[e.RowIndex].Cells[0].Value);


                    lock (lockObject)
                    {
                        if (itemId > 0)
                        {
                            SetDataToDb(new DbRecordChangesTask { DbRecord = tableItem, ChangesType = DbRecordChangesType.Update });
                        }
                        else
                        {
                            SetDataToDb(new DbRecordChangesTask { DbRecord = tableItem, ChangesType = DbRecordChangesType.Create });
                        } 
                    }
                }
            }
        }

        private void dbUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DbRecordChangesTask dbChangesTask = e.Argument as DbRecordChangesTask;

            try
            {
                using (MedicamentRemainsContext mc = new MedicamentRemainsContext())
                {
                    if (tableItem is Meter)
                    {
                        Meter record = dbChangesTask.DbRecord as Meter;

                        switch (dbChangesTask.ChangesType)
                        {
                            case DbRecordChangesType.Create:
                                dbUpdateWorker.ReportProgress(0, "Створення нової одиниці виміру...");
                                record.Name = record.Name.Trim();
                                mc.Meters.Add(record);
                                break;

                            case DbRecordChangesType.Update:
                                dbUpdateWorker.ReportProgress(0, "Змінення одиниці виміру...");
                                record.Name = record.Name.Trim();
                                mc.Meters.Attach(record);
                                mc.Entry<Meter>(record).State = System.Data.Entity.EntityState.Modified;
                                break;

                            case DbRecordChangesType.Remove:
                                dbUpdateWorker.ReportProgress(0, "Видалення одиниці виміру...");
                                mc.Meters.Attach(record);
                                mc.Meters.Remove(record);
                                break;
                        }
                    }
                    else if (tableItem is HospitalDepartment)
                    {
                        HospitalDepartment record = dbChangesTask.DbRecord as HospitalDepartment;

                        switch (dbChangesTask.ChangesType)
                        {
                            case DbRecordChangesType.Create:
                                dbUpdateWorker.ReportProgress(0, "Створення нового відділення...");
                                record.Name = record.Name.Trim();
                                mc.HospitalDepartments.Add(record);
                                break;

                            case DbRecordChangesType.Update:
                                dbUpdateWorker.ReportProgress(0, "Змінення даних про відділення...");
                                record.Name = record.Name.Trim();
                                mc.HospitalDepartments.Attach(record);
                                mc.Entry<HospitalDepartment>(record).State = System.Data.Entity.EntityState.Modified;
                                break;

                            case DbRecordChangesType.Remove:
                                dbUpdateWorker.ReportProgress(0, "Видалення даних про відділення...");
                                mc.HospitalDepartments.Attach(record);
                                mc.HospitalDepartments.Remove(record);
                                break;
                        }
                    }
                    else if (tableItem is MedicamentGroup)
                    {
                        MedicamentGroup record = dbChangesTask.DbRecord as MedicamentGroup;

                        switch (dbChangesTask.ChangesType)
                        {
                            case DbRecordChangesType.Create:
                                dbUpdateWorker.ReportProgress(0, "Створення нової группи медикаментів...");
                                record.Name = record.Name.Trim();
                                mc.MedicamentsGroups.Add(record);
                                break;

                            case DbRecordChangesType.Update:
                                dbUpdateWorker.ReportProgress(0, "Змінення группи медикаментів...");
                                record.Name = record.Name.Trim();
                                mc.MedicamentsGroups.Attach(record);
                                mc.Entry<MedicamentGroup>(record).State = System.Data.Entity.EntityState.Modified;
                                break;

                            case DbRecordChangesType.Remove:
                                dbUpdateWorker.ReportProgress(0, "Видалення группи медикаментів...");
                                mc.MedicamentsGroups.Attach(record);
                                mc.MedicamentsGroups.Remove(record);
                                break;
                        }
                    }

                    mc.SaveChanges();

                    if (tableItem is HospitalDepartment)
                    {
                        isDepartmentListUpdated = true;
                    }

                    dbUpdateWorker.ReportProgress(0, "Дані успішно збережені!");
                }
            }
            catch (Exception ex)
            {
                dbUpdateWorker.ReportProgress(0, "Помилка: " + ex.Message);
            }

            Thread.Sleep(3000);
        }

        private void dbUpdateWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            dbWorkResultLabel.Text = e.UserState.ToString();
        }

        private void dbUpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dbWorkResultLabel.Text = string.Empty;
        }

        private void removeMeterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(NotificationHelper.ShowQuestion("Ви впевнені що хочете видалити вказаний елемент?") != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            int rowIndex = dataTable.SelectedCells[0].RowIndex;
            int itemId = Convert.ToInt32(dataTable.Rows[rowIndex].Cells[0].Value);
            object selectedItem = dataTable.Rows[rowIndex].DataBoundItem;

            lock (lockObject)
            {
                if (itemId > 0)
                {
                    SetDataToDb(new DbRecordChangesTask { DbRecord = selectedItem, ChangesType = DbRecordChangesType.Remove });
                } 
            }

            dataTable.Rows.RemoveAt(rowIndex);
            RecalculateRowsNumbers(rowIndex);
        }

        private void checkTaskQueueTimer_Tick(object sender, EventArgs e)
        {
            lock (lockObject)
            {
                if (updateDbTasksQueue.Count > 0 && !dbUpdateWorker.IsBusy)
                {
                    dbUpdateWorker.RunWorkerAsync(updateDbTasksQueue.Dequeue());
                } 
            }
        }

    }
}
