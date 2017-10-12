using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicamentRemains
{
    public class NotificationHelper
    {
        public static void ShowError(string msg)
        {
            MessageBox.Show(msg, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string msg)
        {
            MessageBox.Show(msg, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowQuestion(string msg)
        {
            return MessageBox.Show(msg, "Підтвердження дії", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
