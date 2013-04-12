namespace SkypeHistoryExporter
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.RichTextBox();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.buttonExportSel = new System.Windows.Forms.Button();
            this.buttonExportAll = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTableList = new System.Windows.Forms.Label();
            this.labelExportHistory = new System.Windows.Forms.Label();
            this.listBoxDestDataSource = new System.Windows.Forms.ListBox();
            this.buttonAddDataSource = new System.Windows.Forms.Button();
            this.tabControlDestDataSource = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.buttonRemoveDataSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageXml = new System.Windows.Forms.TabPage();
            this.labelDataPreview = new System.Windows.Forms.Label();
            this.labelStatusLog = new System.Windows.Forms.Label();
            this.labelBrowse = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPageMySQL = new System.Windows.Forms.TabPage();
            this.tabPageCSV = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlDestDataSource.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select User In System:";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(12, 438);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(678, 123);
            this.statusBox.TabIndex = 1;
            this.statusBox.Text = "";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(15, 34);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(162, 21);
            this.comboBoxUsers.TabIndex = 2;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 351);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // listBoxTables
            // 
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.Location = new System.Drawing.Point(15, 123);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(162, 264);
            this.listBoxTables.TabIndex = 6;
            this.listBoxTables.SelectedIndexChanged += new System.EventHandler(this.listBoxTables_SelectedIndexChanged);
            // 
            // buttonExportSel
            // 
            this.buttonExportSel.Location = new System.Drawing.Point(6, 167);
            this.buttonExportSel.Name = "buttonExportSel";
            this.buttonExportSel.Size = new System.Drawing.Size(123, 23);
            this.buttonExportSel.TabIndex = 8;
            this.buttonExportSel.Text = "Export Selected";
            this.buttonExportSel.UseVisualStyleBackColor = true;
            this.buttonExportSel.Click += new System.EventHandler(this.buttonExportSel_Click);
            // 
            // buttonExportAll
            // 
            this.buttonExportAll.Location = new System.Drawing.Point(6, 196);
            this.buttonExportAll.Name = "buttonExportAll";
            this.buttonExportAll.Size = new System.Drawing.Size(123, 23);
            this.buttonExportAll.TabIndex = 9;
            this.buttonExportAll.Text = "Export All Tables";
            this.buttonExportAll.UseVisualStyleBackColor = true;
            this.buttonExportAll.Click += new System.EventHandler(this.buttonExportAll_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(6, 225);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(123, 23);
            this.buttonView.TabIndex = 10;
            this.buttonView.Text = "View Exported Hist";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(803, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTableList
            // 
            this.labelTableList.AutoSize = true;
            this.labelTableList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableList.Location = new System.Drawing.Point(12, 100);
            this.labelTableList.Name = "labelTableList";
            this.labelTableList.Size = new System.Drawing.Size(144, 17);
            this.labelTableList.TabIndex = 12;
            this.labelTableList.Text = "Tables in History File:";
            // 
            // labelExportHistory
            // 
            this.labelExportHistory.AutoSize = true;
            this.labelExportHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExportHistory.Location = new System.Drawing.Point(709, 58);
            this.labelExportHistory.Name = "labelExportHistory";
            this.labelExportHistory.Size = new System.Drawing.Size(100, 17);
            this.labelExportHistory.TabIndex = 13;
            this.labelExportHistory.Text = "Export History:";
            // 
            // listBoxDestDataSource
            // 
            this.listBoxDestDataSource.FormattingEnabled = true;
            this.listBoxDestDataSource.Location = new System.Drawing.Point(6, 34);
            this.listBoxDestDataSource.Name = "listBoxDestDataSource";
            this.listBoxDestDataSource.Size = new System.Drawing.Size(123, 69);
            this.listBoxDestDataSource.TabIndex = 15;
            this.listBoxDestDataSource.SelectedIndexChanged += new System.EventHandler(this.listBoxDestDataSource_SelectedIndexChanged);
            // 
            // buttonAddDataSource
            // 
            this.buttonAddDataSource.Location = new System.Drawing.Point(6, 109);
            this.buttonAddDataSource.Name = "buttonAddDataSource";
            this.buttonAddDataSource.Size = new System.Drawing.Size(123, 23);
            this.buttonAddDataSource.TabIndex = 16;
            this.buttonAddDataSource.Text = "Add Data Source";
            this.buttonAddDataSource.UseVisualStyleBackColor = true;
            this.buttonAddDataSource.Click += new System.EventHandler(this.buttonAddDataSource_Click);
            // 
            // tabControlDestDataSource
            // 
            this.tabControlDestDataSource.Controls.Add(this.tabPageSQL);
            this.tabControlDestDataSource.Controls.Add(this.tabPageMySQL);
            this.tabControlDestDataSource.Controls.Add(this.tabPageXml);
            this.tabControlDestDataSource.Controls.Add(this.tabPageCSV);
            this.tabControlDestDataSource.Location = new System.Drawing.Point(701, 78);
            this.tabControlDestDataSource.Name = "tabControlDestDataSource";
            this.tabControlDestDataSource.SelectedIndex = 0;
            this.tabControlDestDataSource.Size = new System.Drawing.Size(182, 305);
            this.tabControlDestDataSource.TabIndex = 15;
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.buttonRemoveDataSource);
            this.tabPageSQL.Controls.Add(this.label2);
            this.tabPageSQL.Controls.Add(this.buttonAddDataSource);
            this.tabPageSQL.Controls.Add(this.listBoxDestDataSource);
            this.tabPageSQL.Controls.Add(this.buttonExportAll);
            this.tabPageSQL.Controls.Add(this.buttonExportSel);
            this.tabPageSQL.Controls.Add(this.buttonView);
            this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(174, 279);
            this.tabPageSQL.TabIndex = 0;
            this.tabPageSQL.Text = "SQL";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveDataSource
            // 
            this.buttonRemoveDataSource.Location = new System.Drawing.Point(6, 138);
            this.buttonRemoveDataSource.Name = "buttonRemoveDataSource";
            this.buttonRemoveDataSource.Size = new System.Drawing.Size(123, 23);
            this.buttonRemoveDataSource.TabIndex = 17;
            this.buttonRemoveDataSource.Text = "Remove Data Source";
            this.buttonRemoveDataSource.UseVisualStyleBackColor = true;
            this.buttonRemoveDataSource.Click += new System.EventHandler(this.buttonRemoveDataSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Destination Datasource:";
            // 
            // tabPageXml
            // 
            this.tabPageXml.Location = new System.Drawing.Point(4, 22);
            this.tabPageXml.Name = "tabPageXml";
            this.tabPageXml.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXml.Size = new System.Drawing.Size(160, 279);
            this.tabPageXml.TabIndex = 1;
            this.tabPageXml.Text = "XML";
            this.tabPageXml.UseVisualStyleBackColor = true;
            // 
            // labelDataPreview
            // 
            this.labelDataPreview.AutoSize = true;
            this.labelDataPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataPreview.Location = new System.Drawing.Point(191, 9);
            this.labelDataPreview.Name = "labelDataPreview";
            this.labelDataPreview.Size = new System.Drawing.Size(95, 17);
            this.labelDataPreview.TabIndex = 16;
            this.labelDataPreview.Text = "Data Preview:";
            // 
            // labelStatusLog
            // 
            this.labelStatusLog.AutoSize = true;
            this.labelStatusLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusLog.Location = new System.Drawing.Point(12, 418);
            this.labelStatusLog.Name = "labelStatusLog";
            this.labelStatusLog.Size = new System.Drawing.Size(80, 17);
            this.labelStatusLog.TabIndex = 17;
            this.labelStatusLog.Text = "Status Log:";
            // 
            // labelBrowse
            // 
            this.labelBrowse.AutoSize = true;
            this.labelBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowse.Location = new System.Drawing.Point(9, 67);
            this.labelBrowse.Name = "labelBrowse";
            this.labelBrowse.Size = new System.Drawing.Size(120, 17);
            this.labelBrowse.TabIndex = 18;
            this.labelBrowse.Text = "Or Browse db file:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(127, 61);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(50, 23);
            this.buttonBrowse.TabIndex = 19;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPageMySQL
            // 
            this.tabPageMySQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageMySQL.Name = "tabPageMySQL";
            this.tabPageMySQL.Size = new System.Drawing.Size(160, 279);
            this.tabPageMySQL.TabIndex = 2;
            this.tabPageMySQL.Text = "MySQL";
            this.tabPageMySQL.UseVisualStyleBackColor = true;
            // 
            // tabPageCSV
            // 
            this.tabPageCSV.Location = new System.Drawing.Point(4, 22);
            this.tabPageCSV.Name = "tabPageCSV";
            this.tabPageCSV.Size = new System.Drawing.Size(160, 279);
            this.tabPageCSV.TabIndex = 3;
            this.tabPageCSV.Text = "CSV";
            this.tabPageCSV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 573);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelBrowse);
            this.Controls.Add(this.labelStatusLog);
            this.Controls.Add(this.labelDataPreview);
            this.Controls.Add(this.tabControlDestDataSource);
            this.Controls.Add(this.labelExportHistory);
            this.Controls.Add(this.labelTableList);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listBoxTables);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Skype History Exporter";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlDestDataSource.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.tabPageSQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox statusBox;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxTables;
        private System.Windows.Forms.Button buttonExportSel;
        private System.Windows.Forms.Button buttonExportAll;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTableList;
        private System.Windows.Forms.Label labelExportHistory;
        private System.Windows.Forms.ListBox listBoxDestDataSource;
        private System.Windows.Forms.Button buttonAddDataSource;
        private System.Windows.Forms.TabControl tabControlDestDataSource;
        private System.Windows.Forms.TabPage tabPageSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageXml;
        private System.Windows.Forms.Button buttonRemoveDataSource;
        private System.Windows.Forms.Label labelDataPreview;
        private System.Windows.Forms.Label labelStatusLog;
        private System.Windows.Forms.Label labelBrowse;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPageMySQL;
        private System.Windows.Forms.TabPage tabPageCSV;
    }
}

