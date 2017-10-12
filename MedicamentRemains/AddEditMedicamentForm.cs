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

namespace MedicamentRemains
{
    public partial class AddEditMedicamentForm : Form
    {
        private Medicament loadedMedicament;
        private Medicament currentMedicament;

        public Medicament CurrentMedicament
        {
            get
            {
                return currentMedicament;
            }
        }

        public AddEditMedicamentForm()
        {
            InitializeComponent();

            using (MedicamentRemainsContext mc = new MedicamentRemainsContext())
            {
                List<Meter> metersList = mc.Meters.ToList();
                meterCBList.DataSource = metersList;
                meterCBList.DisplayMember = "Name";
                meterCBList.ValueMember = "Id";

                List<MedicamentGroup> medGroups = mc.MedicamentsGroups.ToList();
                medGroupsCBList.DataSource = medGroups;
                medGroupsCBList.DisplayMember = "Name";
                medGroupsCBList.ValueMember = "Id";
            }
        }

        public AddEditMedicamentForm(int medicamentId) : this()
        {
            this.Text = "Змінити дані про медикамент";
            actionButton.Text = "Змінити";

            using(MedicamentRemainsContext mc = new MedicamentRemainsContext())
            {
                Medicament med = mc.Medicaments.Include(p => p.Meter).Where(p => (p.Id == medicamentId)).First();
                medicamentNameTextBox.Text = med.Name;
                meterCBList.SelectedValue = med.MeterId;
                medGroupsCBList.SelectedValue = med.MedicamentGroupId;
                loadedMedicament = med;
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(medicamentNameTextBox.Text))
            {
                NotificationHelper.ShowError("Ви не ввели назву");
                return;
            }

            try
            {
                using (MedicamentRemainsContext mc = new MedicamentRemainsContext())
                {
                    if (loadedMedicament == null)
                    {
                        currentMedicament = new Medicament();
                    }
                    else
                    {
                        currentMedicament = loadedMedicament;
                    }

                    currentMedicament.Name = medicamentNameTextBox.Text.Trim();
                    currentMedicament.Meter = meterCBList.SelectedItem as Meter;
                    currentMedicament.MeterId = Convert.ToInt32(meterCBList.SelectedValue);
                    currentMedicament.Group = null;
                    currentMedicament.MedicamentGroupId = Convert.ToInt32(medGroupsCBList.SelectedValue);

                    mc.Meters.Attach(currentMedicament.Meter);

                    if (currentMedicament.Id > 0)
                    {
                        mc.Medicaments.Attach(currentMedicament);
                        mc.Entry<Medicament>(currentMedicament).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        mc.Medicaments.Add(currentMedicament);
                    }

                    mc.SaveChanges();
                    NotificationHelper.ShowInfo("Данні успішно збережено!");
                }
            }
            catch (Exception ex)
            {
                NotificationHelper.ShowError("Помилка при збережені данних до БД.\n Подробиці: \n" + ex.Message);
            }

            Close();
        }
    }
}
