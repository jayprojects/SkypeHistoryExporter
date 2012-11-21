using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkypeHistoryExporter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            global.dbName = textBoxDatabase.Text;
            global.connectionString = "Server=" + textBoxServer.Text + "; " +
                                "Database=" + textBoxDatabase.Text + "; " +
                                "User ID=" + textBoxUser.Text + "; " +
                                "Password=" + textBoxPasswrod.Text + "; ";
            DataTable dt =  DbUtill.executeQuery("use "+global.dbName+"; SELECT name FROM sys.Tables;");
            if (dt != null)
            {
                global.connectDb = true;
                MessageBox.Show("Database Connection Successfull");
            }
            else
            {
                global.connectDb = false;
                MessageBox.Show("Database Connection not found, Please try again");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }
    }
}
