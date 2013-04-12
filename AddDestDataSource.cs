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
    public partial class AddDestDataSource : Form
    {
        public AddDestDataSource()
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
            if(global.connectDb && textBoxDataSourceName.Text.Length>0)
            {
                ComboboxItem cbi = new ComboboxItem(textBoxDataSourceName.Text, global.connectionString);
                List<ComboboxItem> cbiList = ApplicationUtil.getDestDataSources();
                cbiList.Add(cbi);
                ApplicationUtil.setDestDataSources(cbiList);
                AddDestDataSource.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Invalid datasource plase check again");
            }
        }
    }
}
