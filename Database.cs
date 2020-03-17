using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTriageTransferTool
{
    public static class Database
    {
        static readonly string connectionString = Properties.Resources.dt3_connection_string;

        public static class Get
        {
            public static DataTable Classifications()
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.select_classifications, connectionString);
                dataAdapter.Fill(table);
                return table;
            }
            public static DataTable FlumeData()
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.flume_data, connectionString);
                dataAdapter.Fill(table);
                return table;
            }


            public static DataTable MedexTypes()
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.medex_types, connectionString);
                dataAdapter.Fill(table);
                return table;
            }


            public static DataTable CellexTypes()
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.cellex_types, connectionString);
                dataAdapter.Fill(table);
                return table;
            }


            public static DataTable Sizes()
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.sizes, connectionString);
                dataAdapter.Fill(table);
                return table;
            }


            public static DataTable AORS()
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.select_aors, connectionString);
                dataAdapter.Fill(table);
                return table;
            }

            public static DataTable CaseFolder()
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.case_folder, connectionString);
                dataAdapter.Fill(table);
                return table;
            }

            public static DataTable Cases()
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.select_cases, connectionString);
                dataAdapter.Fill(table);
                return table;
            }

            public static string[] Items(string case_number)
            {
                string[] items = { "1", "1.1", "2", "2.1", "2.2", "3" };
                return items;
            }

            public static string[] Folders(string type)
            {
                string[] folders = { "photos", "documents", "videos" };
                return folders;
            }
        }

        public static class Save
        {
            public static void FlumeIP(string item, bool suppressMessage = false)
            {
                string sql = "insert into flume (ip) values('" + item + "');";
                Insert.Item(sql, suppressMessage);
            }

            public static void FlumeDrive(string item, bool suppressMessage = false)
            {
                string sql = "insert into case_folder (drive) values('" + item + "');";
                Insert.Item(sql, suppressMessage);
            }

            public static void Case(string case_id, string mgrs, string objective, string subject_name, int aor_id, int classification_id, string submitter_name, string submitter_email, string comments, bool suppressMessage = false)
            {
                string sql = "insert into cases (case_id,mgrs,objective,subject_name,aor_id,classification_id,submitter_name, " +
                "submitter_email,submitted_date,comments) "
                + "values('" + case_id + "',"
                + "'" + mgrs + "',"
                + "'" + objective + "',"
                + "'" + subject_name + "',"
                + aor_id + ","
                + classification_id + ","
                + "'" + submitter_name + "',"
                + "'" + submitter_email + "',"
                + "'" + DateTime.Now.ToString() + "',"
                + "'" + comments + "'" + "); ";

                Insert.Item(sql, suppressMessage);
            }

            public static void CaseItem(string case_number)
            {

            }

            public static void CaseFolder(string path, bool suppressMessage = false)
            {
                string sql = "insert into case_folder (location) values('" + path + "');";
                Database.Insert.Item(sql, suppressMessage);
            }
        }

        public static class Insert
        {
            public static void Item(string sql, bool suppressMessage)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                try
                {
                    connection.Open();
                    dataAdapter.InsertCommand = new SqlCommand(sql, connection);
                    int numRowsAffected = dataAdapter.InsertCommand.ExecuteNonQuery();

                    if (suppressMessage == false)
                    {
                        Messaging.ShowInfoMessageBox(numRowsAffected + " row inserted.");
                    }

                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                    connection.Dispose();
                    dataAdapter.Dispose();
                }
                catch (Exception ex)
                {
                    Messaging.ShowErrorMessageBox(ex.ToString());
                }
            }
        }
        public static class Update
        {
            public static void Item(string sql)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                try
                {
                    connection.Open();
                    dataAdapter.UpdateCommand = new SqlCommand(sql, connection);
                    int numRowsAffected = dataAdapter.UpdateCommand.ExecuteNonQuery();
                    Messaging.ShowInfoMessageBox(numRowsAffected + " row updated.");
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                    connection.Dispose();
                    dataAdapter.Dispose();
                }
                catch (Exception ex)
                {
                    Messaging.ShowErrorMessageBox(ex.ToString());
                }
            }
        }
    }
}
