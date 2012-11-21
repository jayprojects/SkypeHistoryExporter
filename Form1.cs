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

namespace SkypeHistoryExporter
{
    public partial class Form1 : Form
    {
        string dbFile;
        DataTable currentDt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            global.connectDb = false;
            loadUsers();
            dbFile = "main.db";
            loadTables();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = global.connectionString;
            
        }

        void loadTableData(string tableName)
        {
            if (dbFile != "")
            {
                string cs = "URI=file:" + dbFile;
                using (SQLiteConnection con = new SQLiteConnection(cs))
                {
                    con.Open();
                    string stm = @"SELECT * FROM " + tableName;
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(stm, con))
                    {
                        DataSet ds = new DataSet();

                        da.Fill(ds, tableName);
                        if (ds != null)
                        {
                            currentDt = ds.Tables[tableName];
                            dataGridView1.DataSource = currentDt;
                        }
                    }
                    con.Close();
                }
            }
        }

        void loadTables()
        {
            if (dbFile != "")
            {
                string cs = "URI=file:" + dbFile;
                using (SQLiteConnection con = new SQLiteConnection(cs))
                {
                    con.Open();
                    string stm = @"SELECT name, sql FROM sqlite_master WHERE type='table'";
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(stm, con))
                    {
                        DataSet ds = new DataSet();

                        da.Fill(ds, "tables");
                        if (ds != null)
                        {
                            DataTable dt = ds.Tables["tables"];
                            foreach (DataRow row in dt.Rows)
                            {
                                string tableName = row["name"].ToString();
                                string query =  row["sql"].ToString().Replace("BLOB", "IMAGE").Replace("INTEGER", "int");
                                if (tableName.Equals("Messages"))
                                {
              
                                    query = query.Replace("pk_id int", "pk_id bigint");
                                    query = query.Replace("crc int", "crc bigint");
                                    query = query.Replace("remote_id int", "remote_id bigint");
                                }
                                listBoxTables.Items.Add(new ComboboxItem(tableName, query));
                            }
                        }
                    }
                    con.Close();
                }
            }
            
        }


        void loadUsers()
        {
            string databaseName ="main.db";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "Skype");
            string[] dirs = Directory.GetDirectories(path);


            foreach (string dir in dirs)
            {
                DirectoryInfo directoryName = new DirectoryInfo(Path.Combine(path, dir));


                if (directoryName.GetFiles().Where(x => x.Name == databaseName).Any())
                {
                    comboBoxUsers.Items.Add(new ComboboxItem(directoryName.Name, directoryName.FullName + "\\" + databaseName));
                }
            }
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = ((ComboboxItem)comboBoxUsers.SelectedItem).Value.ToString();
        }

        private void listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //richTextBox1.Text = ((ComboboxItem)listBoxTables.SelectedItem).Value.ToString();
            loadTableData(listBoxTables.SelectedItem.ToString());
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            dbFile = ((ComboboxItem)comboBoxUsers.SelectedItem).Value.ToString();
            loadTables();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonExportSel_Click(object sender, EventArgs e)
        {
            if (!(global.connectDb))
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                string tableName = listBoxTables.SelectedItem.ToString();
                string query = ((ComboboxItem)listBoxTables.SelectedItem).Value.ToString();
                exportTable(tableName, query, currentDt);
            }
        }

        private void buttonExportAll_Click(object sender, EventArgs e)
        {
            if (!(global.connectDb))
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                foreach (ComboboxItem lbi in listBoxTables.Items)
                {

                    string tableName = lbi.ToString();
                    string query = lbi.Value.ToString();
                    loadTableData(tableName);
                    exportTable(tableName, query, currentDt);

                }
            }
        }

        void exportTable(string tableName, string query, DataTable dt)
        {
            DbUtill.dropTable(tableName);
            //richTextBox1.Text = "query: " + query;
            DbUtill.executeQuery(query);
            DbUtill.insertDataTableToSqlTable(tableName, dt);
        }

    }
}
