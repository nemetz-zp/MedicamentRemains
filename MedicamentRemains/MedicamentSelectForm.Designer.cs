namespace MedicamentRemains
{
    partial class MedicamentSelectForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.medGroupsCBList = new System.Windows.Forms.ComboBox();
            this.loadingMedicamentsTable = new System.ComponentModel.BackgroundWorker();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.loadingPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.RowNumberColumn,
            this.NameColumn,
            this.MeterColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(388, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IdColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // RowNumberColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowNumberColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.RowNumberColumn.HeaderText = "№ з/п";
            this.RowNumberColumn.Name = "RowNumberColumn";
            this.RowNumberColumn.ReadOnly = true;
            this.RowNumberColumn.Width = 40;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Назва";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // MeterColumn
            // 
            this.MeterColumn.DataPropertyName = "Meter";
            this.MeterColumn.HeaderText = "Од. виміру";
            this.MeterColumn.Name = "MeterColumn";
            this.MeterColumn.ReadOnly = true;
            this.MeterColumn.Width = 75;
            // 
            // selectButton
            // 
            this.selectButton.Enabled = false;
            this.selectButton.Location = new System.Drawing.Point(406, 45);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Вибрати";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Група медикаментів:";
            // 
            // medGroupsCBList
            // 
            this.medGroupsCBList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medGroupsCBList.FormattingEnabled = true;
            this.medGroupsCBList.Location = new System.Drawing.Point(163, 16);
            this.medGroupsCBList.Name = "medGroupsCBList";
            this.medGroupsCBList.Size = new System.Drawing.Size(158, 21);
            this.medGroupsCBList.TabIndex = 6;
            this.medGroupsCBList.SelectedIndexChanged += new System.EventHandler(this.medGroupsCBList_SelectedIndexChanged);
            // 
            // loadingMedicamentsTable
            // 
            this.loadingMedicamentsTable.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadingMedicamentsTable_DoWork);
            this.loadingMedicamentsTable.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadingMedicamentsTable_RunWorkerCompleted);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadingLabel.Location = new System.Drawing.Point(163, 135);
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
            this.loadingPicture.Location = new System.Drawing.Point(55, 110);
            this.loadingPicture.Name = "loadingPicture";
            this.loadingPicture.Size = new System.Drawing.Size(102, 76);
            this.loadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingPicture.TabIndex = 9;
            this.loadingPicture.TabStop = false;
            this.loadingPicture.Visible = false;
            // 
            // MedicamentSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 237);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.loadingPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medGroupsCBList);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedicamentSelectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Вибір медикамента";
            this.Load += new System.EventHandler(this.MedicamentSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox medGroupsCBList;
        private System.ComponentModel.BackgroundWorker loadingMedicamentsTable;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.PictureBox loadingPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeterColumn;
    }
}