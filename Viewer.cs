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
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }


        private void loadUsers()
        {
            
            if (global.connectDb)
            {

                DataTable table = DbUtill.executeQuery("select distinct CONVERT(varchar(50), author) as users from skytest2.dbo.Messages where type=61 order by users ");
                if ((table != null) && (table.Rows.Count > 0))
                {

                    foreach (DataRow row in table.Rows) // Loop over the rows.
                    {
                        comboBoxUsers.Items.Add(new ComboboxItem(row.ItemArray[0].ToString(), row.ItemArray[0].ToString()));
                    }
                }
                
            }
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            labelUser.Text = "Data View for user : " + global.skypeUserName;
            populateTableComboBox();
            loadUsers();
        }

        private void populateTableComboBox()
        {
            List<string> tableNameList = new List<string>();
            tableNameList.Add("Chats");
            tableNameList.Add("Messages");


            foreach (string tbl in tableNameList)
            {
                comboBoxTableNames.Items.Add(new ComboboxItem(tbl, tbl));
            }
        }

        private void loadTables(string tableName)
        {

           

            if (global.connectDb)
            {

                DataTable table = DbUtill.executeQuery("SELECT distinct CONVERT(varchar(100), dialog_partner) as partnet_id FROM Messages where type=61 and dialog_partner is not null order by partnet_id");
                if ((table != null) && (table.Rows.Count > 0))
                {

                    foreach (DataRow row in table.Rows) // Loop over the rows.
                    {
                        listBox1.Items.Add(row.ItemArray[0].ToString());
                    }
                }
                else
                {
                    addStatus("Message table not found in the datasource");
                }
            }
           
        }

        private void getPartnetsFromMessageTable()
        {
            if (global.connectDb)
            {

                DataTable table = DbUtill.executeQuery("SELECT distinct CONVERT(varchar(100), dialog_partner) as partnet_id FROM Messages where type=61 and dialog_partner is not null order by partnet_id");
                if ((table != null) && (table.Rows.Count > 0))
                {
                    listBox1.Items.Clear();
                    foreach (DataRow row in table.Rows) // Loop over the rows.
                    {
                        listBox1.Items.Add(row.ItemArray[0].ToString());
                    }
                }
                else
                {
                    addStatus("Message table not found in the datasource");
                }
            }
        }

      
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            DataTable table = DbUtill.getMessages(listBox1.SelectedItem.ToString());
            //convo_id  ,author  ,dialog_partner , message_time ,body_xml
               // dataGridView1.DataSource = dt;
            if (table != null && table.Rows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<html>");
                sb.AppendLine("<head><title>Skype History</title></head>");
                sb.AppendLine("<body>");
                foreach (DataRow row in table.Rows) // Loop over the rows.
                {
                    
                    
                    sb.AppendLine("<div style=\"background: silver;\">");
                    sb.AppendLine("<span style=\" font-size:14pt; color:teal;\" >" + row["author"] + "</span>");
                    sb.AppendLine("<span style=\" font-size:11pt;\">(" + row["message_time"] + "): </span><br/>");
                    sb.AppendLine("<span>" + row["body_xml"] + "</span>");

                    sb.AppendLine("</div>");

                    sb.AppendLine("<br/>");
                    sb.AppendLine("</body>");
                    sb.AppendLine("</html>");
                }
                webBrowser.DocumentText = sb.ToString();
            }
            else
            {
                addStatus("No message to display");
            }
        }




        //Add status and messages to the rich text box
        private void addStatus(string str)
        {
            richTextBoxStatusLog.AppendText(Environment.NewLine + str + Environment.NewLine);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Viewer.ActiveForm.Close();
        }

        private void comboBoxTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboboxItem)comboBoxTableNames.SelectedItem).Value.ToString().Equals("Chats"))
                MessageBox.Show("Load chat table");
            else if (((ComboboxItem)comboBoxTableNames.SelectedItem).Value.ToString().Equals("Messages"))
                getPartnetsFromMessageTable();
            else
                MessageBox.Show("Unknown table format");

        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            global.skypeUserName =((ComboboxItem) comboBoxUsers.SelectedItem).Text;
        }
    }
}
