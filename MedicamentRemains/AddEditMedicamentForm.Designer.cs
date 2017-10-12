namespace MedicamentRemains
{
    partial class AddEditMedicamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.medicamentNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meterCBList = new System.Windows.Forms.ComboBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.medGroupsCBList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // medicamentNameTextBox
            // 
            this.medicamentNameTextBox.Location = new System.Drawing.Point(77, 24);
            this.medicamentNameTextBox.Name = "medicamentNameTextBox";
            this.medicamentNameTextBox.Size = new System.Drawing.Size(453, 20);
            this.medicamentNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Од. виміру:";
            // 
            // meterCBList
            // 
            this.meterCBList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.meterCBList.FormattingEnabled = true;
            this.meterCBList.Location = new System.Drawing.Point(108, 56);
            this.meterCBList.Name = "meterCBList";
            this.meterCBList.Size = new System.Drawing.Size(77, 21);
            this.meterCBList.TabIndex = 3;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(241, 97);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 4;
            this.actionButton.Text = "Створити";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // medGroupsCBList
            // 
            this.medGroupsCBList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medGroupsCBList.FormattingEnabled = true;
            this.medGroupsCBList.Location = new System.Drawing.Point(366, 55);
            this.medGroupsCBList.Name = "medGroupsCBList";
            this.medGroupsCBList.Size = new System.Drawing.Size(164, 21);
            this.medGroupsCBList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(201, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Група медикаменту:";
            // 
            // AddEditMedicamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 132);
            this.Controls.Add(this.medGroupsCBList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.meterCBList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medicamentNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditMedicamentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Створення нового медикамента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox medicamentNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox meterCBList;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.ComboBox medGroupsCBList;
        private System.Windows.Forms.Label label3;
    }
}