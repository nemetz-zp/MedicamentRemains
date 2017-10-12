namespace MedicamentRemains
{
    partial class MedicamentsListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.medicamentsTable = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMedicamentButton = new System.Windows.Forms.Button();
            this.editMedicamentButton = new System.Windows.Forms.Button();
            this.removeMedicamentButton = new System.Windows.Forms.Button();
            this.medGroupsCBList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.loadingPicture = new System.Windows.Forms.PictureBox();
            this.loadingMedicametsWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // medicamentsTable
            // 
            this.medicamentsTable.AllowUserToAddRows = false;
            this.medicamentsTable.AllowUserToDeleteRows = false;
            this.medicamentsTable.AllowUserToResizeColumns = false;
            this.medicamentsTable.AllowUserToResizeRows = false;
            this.medicamentsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.medicamentsTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.medicamentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.RowNumberColumn,
            this.NameColumn,
            this.MeterColumn});
            this.medicamentsTable.Location = new System.Drawing.Point(12, 48);
            this.medicamentsTable.MultiSelect = false;
            this.medicamentsTable.Name = "medicamentsTable";
            this.medicamentsTable.RowHeadersVisible = false;
            this.medicamentsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.medicamentsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.medicamentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicamentsTable.Size = new System.Drawing.Size(461, 191);
            this.medicamentsTable.TabIndex = 0;
            this.medicamentsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicamentsTable_CellDoubleClick);
            this.medicamentsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.medicamentsTable_RowsAdded);
            this.medicamentsTable.SelectionChanged += new System.EventHandler(this.medicamentsList_SelectionChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // RowNumberColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowNumberColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.RowNumberColumn.HeaderText = "№ з/п";
            this.RowNumberColumn.Name = "RowNumberColumn";
            this.RowNumberColumn.Width = 40;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameColumn.HeaderText = "Назва медикамента";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // MeterColumn
            // 
            this.MeterColumn.DataPropertyName = "Meter";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MeterColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.MeterColumn.HeaderText = "Од. виміру";
            this.MeterColumn.Name = "MeterColumn";
            this.MeterColumn.Width = 80;
            // 
            // addMedicamentButton
            // 
            this.addMedicamentButton.Enabled = false;
            this.addMedicamentButton.Location = new System.Drawing.Point(494, 48);
            this.addMedicamentButton.Name = "addMedicamentButton";
            this.addMedicamentButton.Size = new System.Drawing.Size(75, 23);
            this.addMedicamentButton.TabIndex = 1;
            this.addMedicamentButton.Text = "Додати";
            this.addMedicamentButton.UseVisualStyleBackColor = true;
            this.addMedicamentButton.Click += new System.EventHandler(this.addMedicamentButton_Click);
            // 
            // editMedicamentButton
            // 
            this.editMedicamentButton.Enabled = false;
            this.editMedicamentButton.Location = new System.Drawing.Point(494, 86);
            this.editMedicamentButton.Name = "editMedicamentButton";
            this.editMedicamentButton.Size = new System.Drawing.Size(75, 23);
            this.editMedicamentButton.TabIndex = 2;
            this.editMedicamentButton.Text = "Редагувати";
            this.editMedicamentButton.UseVisualStyleBackColor = true;
            this.editMedicamentButton.Click += new System.EventHandler(this.editMedicamentButton_Click);
            // 
            // removeMedicamentButton
            // 
            this.removeMedicamentButton.Enabled = false;
            this.removeMedicamentButton.Location = new System.Drawing.Point(494, 125);
            this.removeMedicamentButton.Name = "removeMedicamentButton";
            this.removeMedicamentButton.Size = new System.Drawing.Size(75, 23);
            this.removeMedicamentButton.TabIndex = 3;
            this.removeMedicamentButton.Text = "Видалити";
            this.removeMedicamentButton.UseVisualStyleBackColor = true;
            this.removeMedicamentButton.Click += new System.EventHandler(this.removeMedicamentButton_Click);
            // 
            // medGroupsCBList
            // 
            this.medGroupsCBList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medGroupsCBList.FormattingEnabled = true;
            this.medGroupsCBList.Location = new System.Drawing.Point(163, 20);
            this.medGroupsCBList.Name = "medGroupsCBList";
            this.medGroupsCBList.Size = new System.Drawing.Size(158, 21);
            this.medGroupsCBList.TabIndex = 4;
            this.medGroupsCBList.SelectedIndexChanged += new System.EventHandler(this.medGroupsCBList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Група медикаментів:";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadingLabel.Location = new System.Drawing.Point(202, 150);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(218, 20);
            this.loadingLabel.TabIndex = 10;
            this.loadingLabel.Text = "Завантаження данних ...";
            this.loadingLabel.Visible = false;
            // 
            // loadingPicture
            // 
            this.loadingPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadingPicture.Image = global::MedicamentRemains.Properties.Resources.loader;
            this.loadingPicture.Location = new System.Drawing.Point(94, 125);
            this.loadingPicture.Name = "loadingPicture";
            this.loadingPicture.Size = new System.Drawing.Size(102, 76);
            this.loadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingPicture.TabIndex = 9;
            this.loadingPicture.TabStop = false;
            this.loadingPicture.Visible = false;
            // 
            // loadingMedicametsWorker
            // 
            this.loadingMedicametsWorker.WorkerReportsProgress = true;
            this.loadingMedicametsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadingMedicametsWorker_DoWork);
            this.loadingMedicametsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadingMedicametsWorker_RunWorkerCompleted);
            // 
            // MedicamentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 262);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.loadingPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medGroupsCBList);
            this.Controls.Add(this.removeMedicamentButton);
            this.Controls.Add(this.editMedicamentButton);
            this.Controls.Add(this.addMedicamentButton);
            this.Controls.Add(this.medicamentsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedicamentsListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Список зареєстрованих медикаментів";
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView medicamentsTable;
        private System.Windows.Forms.Button addMedicamentButton;
        private System.Windows.Forms.Button editMedicamentButton;
        private System.Windows.Forms.Button removeMedicamentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeterColumn;
        private System.Windows.Forms.ComboBox medGroupsCBList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.PictureBox loadingPicture;
        private System.ComponentModel.BackgroundWorker loadingMedicametsWorker;
    }
}