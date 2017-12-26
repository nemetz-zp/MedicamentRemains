namespace MedicamentRemains
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remainsTable = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lastUpdateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.addRecord = new System.Windows.Forms.Button();
            this.removeRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentsCBList = new System.Windows.Forms.ComboBox();
            this.loadingPicture = new System.Windows.Forms.PictureBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.remainsLoadWorker = new System.ComponentModel.BackgroundWorker();
            this.backgroundDbUpdateWorker = new System.ComponentModel.BackgroundWorker();
            this.checkDbTasksTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.internetConnectionLabel = new System.Windows.Forms.Label();
            this.dbAvailableLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkInternetTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remainsTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentsListToolStripMenuItem,
            this.metersListToolStripMenuItem,
            this.departmentsListToolStripMenuItem,
            this.medGroupsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.settingsToolStripMenuItem.Text = "Налаштування";
            // 
            // medicamentsListToolStripMenuItem
            // 
            this.medicamentsListToolStripMenuItem.Name = "medicamentsListToolStripMenuItem";
            this.medicamentsListToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.medicamentsListToolStripMenuItem.Text = "Медикаменти";
            this.medicamentsListToolStripMenuItem.Click += new System.EventHandler(this.medicamentsListToolStripMenuItem_Click);
            // 
            // metersListToolStripMenuItem
            // 
            this.metersListToolStripMenuItem.Name = "metersListToolStripMenuItem";
            this.metersListToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.metersListToolStripMenuItem.Text = "Од. виміру";
            this.metersListToolStripMenuItem.Click += new System.EventHandler(this.metersListToolStripMenuItem_Click);
            // 
            // departmentsListToolStripMenuItem
            // 
            this.departmentsListToolStripMenuItem.Name = "departmentsListToolStripMenuItem";
            this.departmentsListToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.departmentsListToolStripMenuItem.Text = "Відділення";
            this.departmentsListToolStripMenuItem.Click += new System.EventHandler(this.departmentsListToolStripMenuItem_Click);
            // 
            // medGroupsToolStripMenuItem
            // 
            this.medGroupsToolStripMenuItem.Name = "medGroupsToolStripMenuItem";
            this.medGroupsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.medGroupsToolStripMenuItem.Text = "Групи медикаментів";
            this.medGroupsToolStripMenuItem.Click += new System.EventHandler(this.medGroupsToolStripMenuItem_Click);
            // 
            // remainsTable
            // 
            this.remainsTable.AllowUserToAddRows = false;
            this.remainsTable.AllowUserToDeleteRows = false;
            this.remainsTable.AllowUserToResizeColumns = false;
            this.remainsTable.AllowUserToResizeRows = false;
            this.remainsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.remainsTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.remainsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.remainsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.remainsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.RowNumberColumn,
            this.NameColumn,
            this.RemainColumn,
            this.MeterColumn});
            this.remainsTable.Location = new System.Drawing.Point(13, 82);
            this.remainsTable.MultiSelect = false;
            this.remainsTable.Name = "remainsTable";
            this.remainsTable.RowHeadersVisible = false;
            this.remainsTable.Size = new System.Drawing.Size(618, 205);
            this.remainsTable.TabIndex = 1;
            this.remainsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.remainsTable_CellDoubleClick);
            this.remainsTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.remainsTable_CellValueChanged);
            this.remainsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.remainsTable_RowsAdded);
            this.remainsTable.SelectionChanged += new System.EventHandler(this.remainsTable_SelectionChanged);
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
            this.RowNumberColumn.ReadOnly = true;
            this.RowNumberColumn.Width = 40;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.DataPropertyName = "Medicament";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameColumn.HeaderText = "Медикамент";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // RemainColumn
            // 
            this.RemainColumn.DataPropertyName = "CurrentRemain";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RemainColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.RemainColumn.HeaderText = "Залишок";
            this.RemainColumn.Name = "RemainColumn";
            this.RemainColumn.Width = 75;
            // 
            // MeterColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MeterColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.MeterColumn.HeaderText = "Од. виміру";
            this.MeterColumn.Name = "MeterColumn";
            this.MeterColumn.ReadOnly = true;
            this.MeterColumn.Width = 65;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastUpdateLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(643, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            // 
            // lastUpdateLabel
            // 
            this.lastUpdateLabel.Name = "lastUpdateLabel";
            this.lastUpdateLabel.Size = new System.Drawing.Size(118, 17);
            this.lastUpdateLabel.Text = "toolStripStatusLabel1";
            // 
            // addRecord
            // 
            this.addRecord.Enabled = false;
            this.addRecord.Location = new System.Drawing.Point(426, 50);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(99, 23);
            this.addRecord.TabIndex = 3;
            this.addRecord.Text = "Додати запис";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeRecord
            // 
            this.removeRecord.Enabled = false;
            this.removeRecord.Location = new System.Drawing.Point(532, 50);
            this.removeRecord.Name = "removeRecord";
            this.removeRecord.Size = new System.Drawing.Size(99, 23);
            this.removeRecord.TabIndex = 4;
            this.removeRecord.Text = "Видалити запис";
            this.removeRecord.UseVisualStyleBackColor = true;
            this.removeRecord.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Відділення:";
            // 
            // departmentsCBList
            // 
            this.departmentsCBList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentsCBList.FormattingEnabled = true;
            this.departmentsCBList.Location = new System.Drawing.Point(100, 52);
            this.departmentsCBList.Name = "departmentsCBList";
            this.departmentsCBList.Size = new System.Drawing.Size(189, 21);
            this.departmentsCBList.TabIndex = 6;
            this.departmentsCBList.SelectedIndexChanged += new System.EventHandler(this.departmentsCBList_SelectedIndexChanged);
            // 
            // loadingPicture
            // 
            this.loadingPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadingPicture.Image = global::MedicamentRemains.Properties.Resources.loader;
            this.loadingPicture.Location = new System.Drawing.Point(163, 160);
            this.loadingPicture.Name = "loadingPicture";
            this.loadingPicture.Size = new System.Drawing.Size(102, 76);
            this.loadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingPicture.TabIndex = 7;
            this.loadingPicture.TabStop = false;
            this.loadingPicture.Visible = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadingLabel.Location = new System.Drawing.Point(271, 185);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(218, 20);
            this.loadingLabel.TabIndex = 8;
            this.loadingLabel.Text = "Завантаження данних ...";
            this.loadingLabel.Visible = false;
            // 
            // remainsLoadWorker
            // 
            this.remainsLoadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.remainsLoadWorker_DoWork);
            this.remainsLoadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.remainsLoadWorker_RunWorkerCompleted);
            // 
            // backgroundDbUpdateWorker
            // 
            this.backgroundDbUpdateWorker.WorkerReportsProgress = true;
            this.backgroundDbUpdateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundDbUpdateWorker_DoWork);
            this.backgroundDbUpdateWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundDbUpdateWorker_ProgressChanged);
            this.backgroundDbUpdateWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundDbUpdateWorker_RunWorkerCompleted);
            // 
            // checkDbTasksTimer
            // 
            this.checkDbTasksTimer.Enabled = true;
            this.checkDbTasksTimer.Interval = 3000;
            this.checkDbTasksTimer.Tick += new System.EventHandler(this.checkDbTasksTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Зв\'язок з інтернетом:";
            // 
            // internetConnectionLabel
            // 
            this.internetConnectionLabel.AutoSize = true;
            this.internetConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.internetConnectionLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.internetConnectionLabel.Location = new System.Drawing.Point(171, 300);
            this.internetConnectionLabel.Name = "internetConnectionLabel";
            this.internetConnectionLabel.Size = new System.Drawing.Size(65, 15);
            this.internetConnectionLabel.TabIndex = 10;
            this.internetConnectionLabel.Text = "Наявний";
            // 
            // dbAvailableLabel
            // 
            this.dbAvailableLabel.AutoSize = true;
            this.dbAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbAvailableLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.dbAvailableLabel.Location = new System.Drawing.Point(548, 300);
            this.dbAvailableLabel.Name = "dbAvailableLabel";
            this.dbAvailableLabel.Size = new System.Drawing.Size(70, 15);
            this.dbAvailableLabel.TabIndex = 12;
            this.dbAvailableLabel.Text = "Доступна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(456, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "База даних:";
            // 
            // checkInternetTimer
            // 
            this.checkInternetTimer.Enabled = true;
            this.checkInternetTimer.Interval = 10000;
            this.checkInternetTimer.Tick += new System.EventHandler(this.checkInternetTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 352);
            this.Controls.Add(this.dbAvailableLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.internetConnectionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.loadingPicture);
            this.Controls.Add(this.departmentsCBList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeRecord);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.remainsTable);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Залишки медикаментів";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remainsTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metersListToolStripMenuItem;
        private System.Windows.Forms.DataGridView remainsTable;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lastUpdateLabel;
        private System.Windows.Forms.ToolStripMenuItem departmentsListToolStripMenuItem;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Button removeRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentsCBList;
        private System.Windows.Forms.PictureBox loadingPicture;
        private System.Windows.Forms.Label loadingLabel;
        private System.ComponentModel.BackgroundWorker remainsLoadWorker;
        private System.Windows.Forms.ToolStripMenuItem medGroupsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundDbUpdateWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeterColumn;
        private System.Windows.Forms.Timer checkDbTasksTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label internetConnectionLabel;
        private System.Windows.Forms.Label dbAvailableLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer checkInternetTimer;
    }
}

