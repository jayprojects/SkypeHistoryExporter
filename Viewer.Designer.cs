namespace SkypeHistoryExporter
{
    partial class Viewer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxStatusLog = new System.Windows.Forms.RichTextBox();
            this.labelStatusLog = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelSelectTable = new System.Windows.Forms.Label();
            this.comboBoxTableNames = new System.Windows.Forms.ComboBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 329);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chat Partner List:";
            // 
            // richTextBoxStatusLog
            // 
            this.richTextBoxStatusLog.Location = new System.Drawing.Point(17, 469);
            this.richTextBoxStatusLog.Name = "richTextBoxStatusLog";
            this.richTextBoxStatusLog.Size = new System.Drawing.Size(842, 83);
            this.richTextBoxStatusLog.TabIndex = 10;
            this.richTextBoxStatusLog.Text = "";
            // 
            // labelStatusLog
            // 
            this.labelStatusLog.AutoSize = true;
            this.labelStatusLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusLog.Location = new System.Drawing.Point(14, 449);
            this.labelStatusLog.Name = "labelStatusLog";
            this.labelStatusLog.Size = new System.Drawing.Size(80, 17);
            this.labelStatusLog.TabIndex = 18;
            this.labelStatusLog.Text = "Status Log:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(784, 9);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSelectTable
            // 
            this.labelSelectTable.AutoSize = true;
            this.labelSelectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTable.Location = new System.Drawing.Point(14, 50);
            this.labelSelectTable.Name = "labelSelectTable";
            this.labelSelectTable.Size = new System.Drawing.Size(91, 17);
            this.labelSelectTable.TabIndex = 20;
            this.labelSelectTable.Text = "Select Table:";
            // 
            // comboBoxTableNames
            // 
            this.comboBoxTableNames.FormattingEnabled = true;
            this.comboBoxTableNames.Location = new System.Drawing.Point(111, 50);
            this.comboBoxTableNames.Name = "comboBoxTableNames";
            this.comboBoxTableNames.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTableNames.TabIndex = 21;
            this.comboBoxTableNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableNames_SelectedIndexChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(209, 97);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(650, 328);
            this.webBrowser.TabIndex = 22;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(352, 26);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(187, 25);
            this.labelUser.TabIndex = 23;
            this.labelUser.Text = "Data View for user : ";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(111, 12);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsers.TabIndex = 25;
            this.comboBoxUsers.Visible = false;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select User:";
            this.label1.Visible = false;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 573);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.comboBoxTableNames);
            this.Controls.Add(this.labelSelectTable);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelStatusLog);
            this.Controls.Add(this.richTextBoxStatusLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Name = "Viewer";
            this.Text = "Viewer";
            this.Load += new System.EventHandler(this.Viewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxStatusLog;
        private System.Windows.Forms.Label labelStatusLog;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelSelectTable;
        private System.Windows.Forms.ComboBox comboBoxTableNames;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label label1;

    }
}