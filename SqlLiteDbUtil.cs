using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Data;
namespace SkypeHistoryExporter
{
    public class SqlLiteDbUtil
    {

        //Returns all the table in a sql lite database file. usally main.db
        public static List<ComboboxItem> getTableList(string sqlLiteDbFilePath)
        {
            List<ComboboxItem> tblList = new List<ComboboxItem>();
            if (sqlLiteDbFilePath != "")
            {
                string cs = "URI=file:" + sqlLiteDbFilePath;
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
                                string query = row["sql"].ToString().Replace("BLOB", "IMAGE").Replace("INTEGER", "int");
                                if (tableName.Equals("Messages"))
                                {

                                    query = query.Replace("pk_id int", "pk_id bigint");
                                    query = query.Replace("crc int", "crc bigint");
                                    query = query.Replace("remote_id int", "remote_id bigint");
                                }
                                tblList.Add(new ComboboxItem(tableName, query));
                            }
                        }
                    }
                    con.Close();
                }
            }
            return tblList;
        }




        //Select all data from given sql lite databse file and table name
        //return it as datatable
        public static DataTable getTableData(string sqlLiteDbFilePath, string tableName)
        {
            DataTable dt = new DataTable();
            
            if (sqlLiteDbFilePath != "")
            {
                string cs = "URI=file:" + sqlLiteDbFilePath;
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
                            dt = ds.Tables[tableName];
                        }
                    }
                    con.Close();
                }
            }
            return dt;
        }
    }
}
