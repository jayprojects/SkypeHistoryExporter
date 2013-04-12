namespace SkypeHistoryExporter
{
    partial class AddDestDataSource
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPasswrod = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDataSourceName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(131, 192);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(95, 23);
            this.buttonConnect.TabIndex = 28;
            this.buttonConnect.Text = "Test Connection";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(131, 166);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(147, 20);
            this.textBoxDatabase.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Server";
            // 
            // textBoxPasswrod
            // 
            this.textBoxPasswrod.Location = new System.Drawing.Point(131, 137);
            this.textBoxPasswrod.Name = "textBoxPasswrod";
            this.textBoxPasswrod.PasswordChar = '*';
            this.textBoxPasswrod.Size = new System.Drawing.Size(147, 20);
            this.textBoxPasswrod.TabIndex = 21;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(131, 108);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(147, 20);
            this.textBoxUser.TabIndex = 20;
            this.textBoxUser.Text = "sa";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(131, 79);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(147, 20);
            this.textBoxPort.TabIndex = 19;
            this.textBoxPort.Text = "1434";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(131, 50);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(147, 20);
            this.textBoxServer.TabIndex = 18;
            this.textBoxServer.Text = "localhost";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(131, 221);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(95, 20);
            this.buttonClose.TabIndex = 30;
            this.buttonClose.Text = "Add and Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Data Source Name";
            // 
            // textBoxDataSourceName
            // 
            this.textBoxDataSourceName.Location = new System.Drawing.Point(131, 24);
            this.textBoxDataSourceName.Name = "textBoxDataSourceName";
            this.textBoxDataSourceName.Size = new System.Drawing.Size(147, 20);
            this.textBoxDataSourceName.TabIndex = 31;
            this.textBoxDataSourceName.Text = "New SQL Data Source";
            // 
            // AddDestDataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 277);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDataSourceName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPasswrod);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxServer);
            this.Name = "AddDestDataSource";
            this.Text = "Set Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasswrod;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDataSourceName;
    }
}