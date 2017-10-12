using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace MedicamentRemains
{
    public partial class LoadingProgramForm : Form
    {
        private string errorMessage;

        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
        }

        public LoadingProgramForm()
        {
            InitializeComponent();
            progressStatusLabel.Text = string.Empty;

            backgroundLoadingWorker.RunWorkerAsync();
        }

        private void backgroundLoadingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundLoadingWorker.ReportProgress(0, "Перевірка з'єднання з мережею інтернет ...");
            if(!NetHelper.IsConnectedToInternet())
            {
                errorMessage = "Відсутнє з'єданння з мережею Інтернет!";
                return;
            }
            backgroundLoadingWorker.ReportProgress(0, "З'єднання наявне!");

            backgroundLoadingWorker.ReportProgress(0, "Перевірка з'єднання з базою даних ...");
            if (!NetHelper.IsDatabaseAvailable())
            {
                errorMessage = "Доступ до бази данних відсутній!";
                return;
            }
            backgroundLoadingWorker.ReportProgress(0, "Доступ до бази даних наявний!");
        }

        private void backgroundLoadingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressStatusLabel.Text = e.UserState.ToString();
        }

        private void backgroundLoadingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressStatusLabel.Text = string.Empty;
            this.Close();
        }
    }
}
