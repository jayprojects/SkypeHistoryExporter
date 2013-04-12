using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Configuration;
using System.Runtime.Serialization.Formatters.Binary;
namespace SkypeHistoryExporter
{
    public partial class Form1 : Form
    {
        DataTable currentDt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            global.connectDb = false;
            loadUsersInTheSystem();
            buttonExportSel.Enabled = false;
            buttonExportAll.Enabled = false;
            buttonView.Enabled = false;
            reLoadDestDataSources();
        }
        
        //Add skype users to the Select User combo box
        void loadUsersInTheSystem()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                path = Path.Combine(path, "Skype");
                if (Directory.Exists(path))
                {
                    string[] dirs = Directory.GetDirectories(path);

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo directoryName = new DirectoryInfo(Path.Combine(path, dir));
                        //Iterate all folder int he Skype application folder
                        //if a folder contians main.db then add that folder as skype user
                        if (directoryName.GetFiles().Where(x => x.Name == global.sqlLiteDbFileName).Any())
                        {
                            comboBoxUsers.Items.Add(new ComboboxItem(directoryName.Name, directoryName.FullName + "\\" + global.sqlLiteDbFileName));
                        }
                    }
                }
                else
                {
                    addStatus("No skype user found in the system. Please browse select skype history file if you have");
                }
            }
            catch (Exception e)
            {
                addStatus("No skype user found in the system. Please browse select skype history file if you have");
            }
        }



        //Load tables for selected user in to the list box
        //Value of each list item is the sql query to create that item!
        void loadUserHistory()
        {
            if (global.sqlLiteDbFilePath.Length > 3)
            {
                addStatus("db file: " + global.sqlLiteDbFilePath);
                List<ComboboxItem> tblList = SqlLiteDbUtil.getTableList(global.sqlLiteDbFilePath);
                if (null != tblList && tblList.Count > 0)
                {

                    tblList.Sort();
                    foreach (ComboboxItem ci in tblList)
                    {
                        listBoxTables.Items.Add(ci);
                    }
                    addStatus("Skype history found for the user " + comboBoxUsers.Text + ". To view records, please select the table from the left list box.");
                    if (global.connectDb)
                        buttonExportAll.Enabled = true;
                }
                else
                {
                    addStatus("No database file found for the user");
                }
            }
            
        }
       





        //Upon clicking on the table name from the list box (on the left side)
        //it load data for that table and display it on the data grid view
        private void listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = listBoxTables.SelectedItem.ToString();
            currentDt = SqlLiteDbUtil.getTableData(global.sqlLiteDbFilePath, tableName);
            if (null != currentDt)
            {
                
                dataGridView1.DataSource = currentDt;
                
                addStatus("Table read successfull. History is ready to export.");

                 
                if (global.connectDb)
                {
                    buttonExportSel.Enabled = true;
                }

            }
            else
            {
                addStatus("Falied to read the table.");
            }
        }



       //Export selected table to database
        private void buttonExportSel_Click(object sender, EventArgs e)
        {
            if (!(global.connectDb))
            {
                addStatus("Please set destination database and click Export again");
                
            }
            else
            {
                string tableName = listBoxTables.SelectedItem.ToString();
                string query = ((ComboboxItem)listBoxTables.SelectedItem).Value.ToString();
                addStatus("query: " + query);
                exportTable(tableName, query, currentDt);
                addStatus("Data Exported successfully!");
            }
        }

        //Export All tables to database
        private void buttonExportAll_Click(object sender, EventArgs e)
        {
            if (!(global.connectDb))
            {
                addStatus("Please set destination database and click Export again");
            }
            else
            {
                foreach (ComboboxItem lbi in listBoxTables.Items)
                {

                    string tableName = lbi.ToString();
                    string query = lbi.Value.ToString();
                    currentDt = SqlLiteDbUtil.getTableData(global.sqlLiteDbFilePath, tableName);
                    exportTable(tableName, query, currentDt);

                }
            }
        }

        //Insert datatable to Sql database
        //Drop table if already exist
        void exportTable(string tableName, string query, DataTable dt)
        {
            DbUtill.dropTable(tableName);
            DbUtill.executeQuery(query);
            DbUtill.insertDataTableToSqlTable(tableName, dt);
        }

        //Viewer allows you to view data from already exported MS Sql table
        private void buttonView_Click(object sender, EventArgs e)
        {
            Viewer f3 = new Viewer();
            f3.Show();
        }
        
        //Add status and messages to the rich text box
        private void addStatus(string str)
        {
            statusBox.AppendText(Environment.NewLine+ str + Environment.NewLine);
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //if an user was selected load tables for that user
            if ( comboBoxUsers.SelectedIndex > -1)
            {
                global.skypeUserName = ((ComboboxItem)comboBoxUsers.SelectedItem).Text;
                global.sqlLiteDbFilePath = ((ComboboxItem)comboBoxUsers.SelectedItem).Value.ToString();
                loadUserHistory();
            }
            else
            {
                addStatus("Please select a valid user");
            }

            

        }

        //Exit Application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Ignore error on loading data
        //Solves problem of displaying image data
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        //Add new data source
        private void buttonAddDataSource_Click(object sender, EventArgs e)
        {
            AddDestDataSource ads = new AddDestDataSource();
            ads.Show();
        }

        //Remove selected datasource
        private void buttonRemoveDataSource_Click(object sender, EventArgs e)
        {
            if (listBoxDestDataSource.SelectedIndex > -1)
            {
                string datasource = ((ComboboxItem)listBoxDestDataSource.SelectedItem).Text;
                List<ComboboxItem> cbiList = ApplicationUtil.getDestDataSources();
                if (cbiList != null && cbiList.Count > 0)
                {
                    cbiList.RemoveAt(listBoxDestDataSource.SelectedIndex);
                }
                ApplicationUtil.setDestDataSources(cbiList);
            }
            //reLoadDestDataSources();
            listBoxDestDataSource.Items.Remove(listBoxDestDataSource.SelectedItem);
        }

        //Reloade destnation data source items from application setting
        void reLoadDestDataSources()
        {
            listBoxDestDataSource.Items.Clear();
            List<ComboboxItem> cbiList = ApplicationUtil.getDestDataSources();
            if (cbiList != null && cbiList.Count > 0)
            {
                foreach (ComboboxItem cbi in cbiList)
                {
                    listBoxDestDataSource.Items.Add(cbi);
                }
            }
        }

        //Everytime the form get activated, lets refresh datasource
        private void Form1_Activated(object sender, EventArgs e)
        {
            reLoadDestDataSources();
        }

        
        //on clicking item on the destination data source list box
        private void listBoxDestDataSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(((ComboboxItem)listBoxDestDataSource.SelectedItem).Value.ToString());
            if (listBoxDestDataSource.SelectedIndex > -1)
            {
                global.connectionString = ((ComboboxItem)listBoxDestDataSource.SelectedItem).Value.ToString();
                global.connectDb = true;
                buttonView.Enabled = true;
                if (null != currentDt)
                {
                    buttonExportSel.Enabled = true;
                }
                if (listBoxTables.Items.Count > 0)
                {
                    buttonExportAll.Enabled = true;
                }
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Skype History File (sqlite)|*.db|All files (*.*)|*.*";
            openFileDialog1.FileName = global.sqlLiteDbFileName;
            openFileDialog1.ShowDialog();
            global.sqlLiteDbFilePath = openFileDialog1.FileName;
            loadUserHistory();
            
        }

        

        

       
    }
}
