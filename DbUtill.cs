/**
 * @author Jay Das <jay11421@gmail.com>
 * @copyright 2012 Jay Das
 * @namespace sqllitetest
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace SkypeHistoryExporter
{

    public class DbUtill
    {
        public DbUtill()
        {
        }

        public static DataTable executeQuery(string query)
        {
            SqlConnection myConnection = new SqlConnection(global.connectionString);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader dr = myCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                myConnection.Close();
                return dt;
            }
            catch (Exception e2)
            {
                Console.Write(e2.ToString());
            }
            return null;
        }

        public static string executeScalar(string query)
        {
            SqlConnection myConnection = new SqlConnection(global.connectionString);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                string st = myCommand.ExecuteScalar().ToString();
                myConnection.Close();
                return st;
            }
            catch (Exception e2)
            {
                Console.Write(e2.ToString());
            }
            return null;

        }

        public static int executeUpdate(string query)
        {



            SqlConnection myConnection = new SqlConnection(global.connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);



            try
            {
                return myCommand.ExecuteNonQuery();
            }

            catch (SqlException sqlexception)
            {
                Console.Write(sqlexception.Message + "\n" + query);
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message + "\n" + query);
            }

            finally
            {
                myConnection.Close();
            }
            return 0;
        }

        public static void insertDataTableToSqlTable(string tableName, DataTable table)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(global.connectionString))
                {
                    SqlBulkCopy bulkCopy =
                        new SqlBulkCopy
                        (
                        connection,
                        SqlBulkCopyOptions.TableLock |
                        SqlBulkCopyOptions.FireTriggers |
                        SqlBulkCopyOptions.UseInternalTransaction,
                        null
                        );

                    bulkCopy.DestinationTableName = tableName;
                    connection.Open();

                    bulkCopy.WriteToServer(table);
                    connection.Close();
                }
            }
            catch (Exception e2)
            {
                Console.Write(e2.ToString());
            }
        }


       
        public static void createDataTableToSqlTable(string connectionString, string tableName, DataTable table)
        {
            dropTable(tableName);
            string sqlsc = "CREATE TABLE " + tableName + "(";
            for (int i = 0; i < table.Columns.Count; i++)
            {
                string name = table.Columns[i].ColumnName;
                sqlsc += "\n [" + table.Columns[i].ColumnName + "] ";
                if (table.Columns[i].DataType.ToString().Contains("Int64"))
                    sqlsc += " bigint ";
                else if (table.Columns[i].DataType.ToString().Contains("Int32"))
                    sqlsc += " int ";
                else if (table.Columns[i].DataType.ToString().Contains("Int16"))
                    sqlsc += " smallint ";
                else if (table.Columns[i].DataType.ToString().Contains("SByte"))
                    sqlsc += " tinyint ";
                else if (table.Columns[i].DataType.ToString().Contains("System.DateTime"))
                    sqlsc += " datetime ";
                else if (table.Columns[i].ColumnName.Equals("normal_dateTime"))
                    sqlsc += " datetime ";
                else if (table.Columns[i].ColumnName.Equals("body_xml"))
                    sqlsc += " ntext ";
                else if (table.Columns[i].DataType.ToString().Contains("System.String"))
                    sqlsc += " nvarchar(100) ";
                else
                    sqlsc += " nvarchar(100) ";



                if (table.Columns[i].AutoIncrement)
                    sqlsc += " IDENTITY(" + table.Columns[i].AutoIncrementSeed.ToString() + "," + table.Columns[i].AutoIncrementStep.ToString() + ") ";
                if (!table.Columns[i].AllowDBNull)
                    sqlsc += " NOT NULL ";
                sqlsc += ",";
            }



            string query = sqlsc.Substring(0, sqlsc.Length - 1) + ")";
            DbUtill.executeQuery(query);

        }

        public static void dropTable(string table)
        {
            string query = "IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id('[dbo].[" + table + "]'))" +
                        " drop table [dbo].[" + table + "]";

            SqlConnection myConnection = new SqlConnection(global.connectionString);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                myCommand.ExecuteNonQuery();
                myConnection.Close();

            }
            catch (Exception e2)
            {
                Console.Write(e2.ToString());
            }

        }










    }
}