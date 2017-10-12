namespace MedicamentRemains
{
    partial class SimpleElementListForm
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewPriorityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMeterLink = new System.Windows.Forms.LinkLabel();
            this.removeMeterLink = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dbWorkResultLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dbUpdateWorker = new System.ComponentModel.BackgroundWorker();
            this.checkTaskQueueTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToResizeColumns = false;
            this.dataTable.AllowUserToResizeRows = false;
            this.dataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.RowNumberColumn,
            this.NameColumn,
            this.ViewPriorityColumn});
            this.dataTable.Location = new System.Drawing.Point(12, 37);
            this.dataTable.MultiSelect = false;
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataTable.Size = new System.Drawing.Size(383, 150);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellValueChanged);
            this.dataTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.metersTable_RowsAdded);
            this.dataTable.SelectionChanged += new System.EventHandler(this.metersTable_SelectionChanged);
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
            this.RowNumberColumn.Width = 45;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameColumn.HeaderText = "Назва";
            this.NameColumn.Name = "NameColumn";
            // 
            // ViewPriorityColumn
            // 
            this.ViewPriorityColumn.DataPropertyName = "ViewPriority";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewPriorityColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ViewPriorityColumn.HeaderText = "Пріорітет";
            this.ViewPriorityColumn.Name = "ViewPriorityColumn";
            this.ViewPriorityColumn.Visible = false;
            // 
            // addMeterLink
            // 
            this.addMeterLink.AutoSize = true;
            this.addMeterLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.addMeterLink.Location = new System.Drawing.Point(12, 15);
            this.addMeterLink.Name = "addMeterLink";
            this.addMeterLink.Size = new System.Drawing.Size(45, 13);
            this.addMeterLink.TabIndex = 1;
            this.addMeterLink.TabStop = true;
            this.addMeterLink.Text = "Додати";
            this.addMeterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addMeterLink_LinkClicked);
            // 
            // removeMeterLink
            // 
            this.removeMeterLink.AutoSize = true;
            this.removeMeterLink.Enabled = false;
            this.removeMeterLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.removeMeterLink.Location = new System.Drawing.Point(76, 15);
            this.removeMeterLink.Name = "removeMeterLink";
            this.removeMeterLink.Size = new System.Drawing.Size(55, 13);
            this.removeMeterLink.TabIndex = 2;
            this.removeMeterLink.TabStop = true;
            this.removeMeterLink.Text = "Видалити";
            this.removeMeterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removeMeterLink_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbWorkResultLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 204);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(407, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dbWorkResultLabel
            // 
            this.dbWorkResultLabel.Name = "dbWorkResultLabel";
            this.dbWorkResultLabel.Size = new System.Drawing.Size(109, 17);
            this.dbWorkResultLabel.Text = "dbWorkResultLabel";
            // 
            // dbUpdateWorker
            // 
            this.dbUpdateWorker.WorkerReportsProgress = true;
            this.dbUpdateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dbUpdateWorker_DoWork);
            this.dbUpdateWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.dbUpdateWorker_ProgressChanged);
            this.dbUpdateWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dbUpdateWorker_RunWorkerCompleted);
            // 
            // checkTaskQueueTimer
            // 
            this.checkTaskQueueTimer.Enabled = true;
            this.checkTaskQueueTimer.Interval = 3000;
            this.checkTaskQueueTimer.Tick += new System.EventHandler(this.checkTaskQueueTimer_Tick);
            // 
            // SimpleElementListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 226);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.removeMeterLink);
            this.Controls.Add(this.addMeterLink);
            this.Controls.Add(this.dataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleElementListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Список одиниць виміру";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.LinkLabel addMeterLink;
        private System.Windows.Forms.LinkLabel removeMeterLink;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel dbWorkResultLabel;
        private System.ComponentModel.BackgroundWorker dbUpdateWorker;
        private System.Windows.Forms.Timer checkTaskQueueTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewPriorityColumn;
    }
}