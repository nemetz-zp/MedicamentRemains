using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using ZcrlMedicamentModels;
using System.Threading.Tasks;

namespace MedicamentRemains
{
    public partial class MedicamentsListForm : Form
    {
        private BindingList<Medicament> medicamentsList;
        private bool listIsLoaded;

        public MedicamentsListForm()
        {
            InitializeComponent();
            medicamentsTable.AutoGenerateColumns = false;
            listIsLoaded = false;
            
            using(MedicamentRemainsContext mc = new MedicamentRemainsContext())
            {
                List<MedicamentGroup> medGroupsList = mc.MedicamentsGroups.ToList();
                medGroupsList.Insert(0, new MedicamentGroup { Id = -1, Name = "- ВСІ ГРУППИ -" });
                medGroupsCBList.DataSource = medGroupsList;
                medGroupsCBList.DisplayMember = "Name";
                medGroupsCBList.ValueMember = "Id";
            }

            ReloadTableData();

            listIsLoaded = true;
        }

        private void ReloadTableData()
        {
            int medGroupId = Convert.ToInt32(medGroupsCBList.SelectedValue);
            ToggleLoadAnimation();
            loadingMedicametsWorker.RunWorkerAsync(medGroupId);
        }

        private void ToggleLoadAnimation()
        {
            loadingLabel.Visible = loadingPicture.Visible = !(loadingPicture.Visible);
        }

        private void medicamentsList_SelectionChanged(object sender, EventArgs e)
        {
            editMedicamentButton.Enabled = removeMedicamentButton.Enabled = (medicamentsTable.SelectedRows.Count > 0);
        }

        private void addMedicamentButton_Click(object sender, EventArgs e)
        {
            AddEditMedicamentForm af = new AddEditMedicamentForm();
            af.ShowDialog();

            if(af.CurrentMedicament != null)
            {
                medicamentsList.Add(af.CurrentMedicament);
            }

            medicamentsTable.CurrentCell = medicamentsTable.Rows[medicamentsTable.Rows.Count - 1].Cells[2];
        }

        private void editMedicamentButton_Click(object sender, EventArgs e)
        {
            Medicament selectedMedicament = medicamentsTable.SelectedRows[0].DataBoundItem as Medicament;

            EditSelectedMedicament(selectedMedicament);
        }

        private void EditSelectedMedicament(Medicament selectedMedicament)
        {
            AddEditMedicamentForm af = new AddEditMedicamentForm(selectedMedicament.Id);
            af.ShowDialog();

            if (af.CurrentMedicament != null)
            {
                int index = medicamentsList.IndexOf(selectedMedicament);
                medicamentsList[index] = af.CurrentMedicament;
                medicamentsTable.Update();
            }
        }

        // TODO: Проверить удалиться ли элемент из DataGridView, если удалить его из связаного источника без вызова метода Update на DataGridView
        private void removeMedicamentButton_Click(object sender, EventArgs e)
        {
            Medicament selectedMedicament = medicamentsTable.SelectedRows[0].DataBoundItem as Medicament;
            int currentRowIndex = medicamentsTable.SelectedRows[0].Index;

            if(NotificationHelper.ShowQuestion(string.Format("Ви впевнені, що хочете видалити всі данні про медикамент '{0}'", selectedMedicament)) 
                == System.Windows.Forms.DialogResult.Yes)
            {
                medicamentsList.Remove(selectedMedicament);
                new Task(
                    () =>
                    {
                        using (MedicamentRemainsContext mc = new MedicamentRemainsContext())
                        {
                            mc.Medicaments.Attach(selectedMedicament);
                            mc.Medicaments.Remove(selectedMedicament);
                            mc.SaveChanges();
                        }
                    }
                    ).Start();
                RecalculateRowsNumbers(currentRowIndex);
            }
        }

        private void RecalculateRowsNumbers(int startRowNumber)
        {
            for (int i = startRowNumber; i < medicamentsTable.Rows.Count; i++)
            {
                medicamentsTable.Rows[i].Cells[1].Value = (i + 1);
            }
        }

        private void medicamentsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < e.RowCount; i++)
            {
                medicamentsTable.Rows[e.RowIndex + i].Cells[1].Value = (e.RowIndex + i + 1);
            }
        }

        private void medGroupsCBList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int medGroupId = Convert.ToInt32(medGroupsCBList.SelectedValue);
           
            if (medGroupId > 0) 
            {
                addMedicamentButton.Enabled = true;
            }
            else
            {
                addMedicamentButton.Enabled = false;
            }

            medGroupsCBList.Enabled = false;
            addMedicamentButton.Enabled = false;
            ReloadTableData();
        }

        private void loadingMedicametsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (MedicamentRemainsContext mc = new MedicamentRemainsContext())
            {
                int medGroupId = Convert.ToInt32(e.Argument);
                if (medGroupId > 0)
                {
                    medicamentsList = new BindingList<Medicament>(mc.Medicaments.Include(p => p.Meter)
                        .Where(p => p.MedicamentGroupId == medGroupId)
                        .OrderBy(p => p.Name)
                        .ToList());
                }
                else
                {
                    medicamentsList = new BindingList<Medicament>(mc.Medicaments.Include(p => p.Meter)
                        .OrderBy(p => p.Name)
                        .ToList());
                }
            }
        }

        private void loadingMedicametsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            medicamentsTable.DataSource = medicamentsList;
            medGroupsCBList.Enabled = true;
            addMedicamentButton.Enabled = true;
            ToggleLoadAnimation();
        }

        private void medicamentsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Medicament selectedMedicament = medicamentsTable.Rows[e.RowIndex].DataBoundItem as Medicament;

            EditSelectedMedicament(selectedMedicament);
        }
    }
}
