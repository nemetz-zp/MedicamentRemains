using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace MedicamentRemains
{
    public partial class MedicamentSelectForm : Form
    {
        private ZcrlMedicamentModels.Medicament selectedMedicament;
        private BindingList<ZcrlMedicamentModels.Medicament> medList;
        private IEnumerable<int> alreadySelectedMedicaments;

        private bool medGroupsListIsLoaded;

        public ZcrlMedicamentModels.Medicament SelectedMedicament
        {
            get
            {
                return selectedMedicament;
            }
        }

        public MedicamentSelectForm(IEnumerable<int> alreadySelectedMedicaments)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            this.alreadySelectedMedicaments = alreadySelectedMedicaments;

            medGroupsListIsLoaded = false;

            using(MedicamentRemainsContext mc = new MedicamentRemainsContext())
            {
                List<ZcrlMedicamentModels.MedicamentGroup> groupsList = mc.MedicamentsGroups.ToList();
                groupsList.Insert(0, new ZcrlMedicamentModels.MedicamentGroup { Id = -1, Name = "- ВСІ ГРУПИ -" });
                medGroupsCBList.DataSource = groupsList;
                medGroupsCBList.DisplayMember = "Name";
                medGroupsCBList.ValueMember = "Id";
            }

            medGroupsListIsLoaded = true;

            ReloadMedicamentsTable();
        }

        private void ReloadMedicamentsTable()
        {
            int selectedMedGroupId = Convert.ToInt32(medGroupsCBList.SelectedValue);
            loadingMedicamentsTable.RunWorkerAsync(selectedMedGroupId);
            ToggleLoadingAnimation();
        }

        private void ToggleLoadingAnimation()
        {
            loadingLabel.Visible = loadingPicture.Visible = !(loadingPicture.Visible);
        }

        private void MedicamentSelectForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectButton.Enabled = (dataGridView1.SelectedRows.Count > 0);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            selectedMedicament = dataGridView1.SelectedRows[0].DataBoundItem as ZcrlMedicamentModels.Medicament;
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMedicament = dataGridView1.Rows[e.RowIndex].DataBoundItem as ZcrlMedicamentModels.Medicament;
            this.Close();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for(int i = 0; i < e.RowCount; i++)
            {
                dataGridView1.Rows[e.RowIndex + i].Cells[1].Value = (e.RowIndex + i + 1);
            }
        }

        private void medGroupsCBList_SelectedIndexChanged(object sender, EventArgs e)
        {
            medGroupsCBList.Enabled = false;
            ReloadMedicamentsTable();
        }

        private void loadingMedicamentsTable_DoWork(object sender, DoWorkEventArgs e)
        {
            int selectedMedGroupId = Convert.ToInt32(e.Argument);
            using (MedicamentRemainsContext mc = new MedicamentRemainsContext())
            {
                if (selectedMedGroupId > 0)
                {
                    medList = new BindingList<ZcrlMedicamentModels.Medicament>(mc.Medicaments
                        .Include(p => p.Meter)
                        .Where(p => !alreadySelectedMedicaments.Contains(p.Id) && (p.MedicamentGroupId == selectedMedGroupId))
                        .OrderBy(p => p.Name).ToList());
                }
                else
                {
                    medList = new BindingList<ZcrlMedicamentModels.Medicament>(mc.Medicaments.Include(p => p.Meter)
                        .Where(p => !alreadySelectedMedicaments.Contains(p.Id)).OrderBy(p => p.Name).ToList());
                }
            }
        }

        private void loadingMedicamentsTable_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.DataSource = medList;
            dataGridView1.Update();
            
            // Делаем доступным выпадающий список
            medGroupsCBList.Enabled = true;

            ToggleLoadingAnimation();
        }
    }
}
