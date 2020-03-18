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
            public static DataTable ZipSize()
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.zip_size, connectionString);
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
            public static DataTable MedexItem(string name)
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.medex_item + "'" + name + "';", connectionString);
                dataAdapter.Fill(table);
                return table;
            }
            public static DataTable CellexItem(string name)
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.cellex_item + "'" + name + "';", connectionString);
                dataAdapter.Fill(table);
                return table;
            }
            public static DataTable AOR(string name)
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.aor_item + "'" + name + "';", connectionString);
                dataAdapter.Fill(table);
                return table;
            }
            public static DataTable Classification(string name)
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.classification_item + "'" + name + "';", connectionString);
                dataAdapter.Fill(table);
                return table;
            }
            public static DataTable Size(string name)
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.size_item + "'" + name + "';", connectionString);
                dataAdapter.Fill(table);
                return table;
            }
            public static DataTable ZipSize(string name)
            {
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Properties.Resources.zip_size_item  + "'" + name + "';", connectionString);
                dataAdapter.Fill(table);
                return table;
            }
        }

        public static class Delete
        {
            public static void Size(string item)
            {
                string sql = "delete from sizes where type='" + item + "';";
                Delete.Item(sql);
            }
            public static void MedexType(string item)
            {
                string sql = "delete from medex_types where type='" + item + "';";
                Delete.Item(sql);
            }
            public static void Classification(string item)
            {
                string sql = "delete from classifications where classification='" + item + "';";
                Delete.Item(sql);
            }
            public static void CellexType(string item)
            {
                string sql = "delete from cellex_types where type='" + item + "';";
                Delete.Item(sql);
            }
            public static void AOR(string item)
            {
                string sql = "delete from aors where aor='" + item + "';";
                Delete.Item(sql);
            }
            private static void Item(string sql)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                try
                {
                    connection.Open();
                    dataAdapter.DeleteCommand = new SqlCommand(sql, connection);
                    int numRowsAffected = dataAdapter.DeleteCommand.ExecuteNonQuery();
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

        public static class Insert
        {
            public static void Size(string item, bool suppressMessage = false)
            {
                string sql = "insert into sizes (type) values('" + item + "');";
                Insert.Item(sql, suppressMessage);
            }
            public static void FlumeIP(string item, bool suppressMessage = false)
            {
                string sql = "insert into flume (ip) values('" + item + "');";
                Insert.Item(sql, suppressMessage);
            }
            public static void FlumeDrive(string item, bool suppressMessage = false)
            {
                string sql = "insert into flume (drive) values('" + item + "');";
                Insert.Item(sql, suppressMessage);
            }
            public static void Classification(string item, bool suppressMessage = false)
            {
                string sql = "insert into classifications (classification) values('" + item + "');";
                Insert.Item(sql, suppressMessage);
            }
            public static void AOR(string item, bool suppressMessage = false)
            {
                string sql = "insert into aors (aor) values('" + item + "');";
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
                Insert.Item(sql, suppressMessage);
            }
            public static void MedexType(string item, bool suppressMessage = false)
            {
                string sql = "insert into medex_types (type) values('" + item + "');";
                Insert.Item(sql, suppressMessage);
            }
            public static void CellexType(string item, bool suppressMessage = false)
            {
                string sql = "insert into cellex_types (type) values('" + item + "');";
                Insert.Item(sql, suppressMessage);
            }
            private static void Item(string sql, bool suppressMessage)
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
            public static void Size(string item, int id)
            {
                string sql = "update sizes set type ='" + item + "' where id = " + id + ";";
                Update.Item(sql);
            }
            public static void FlumeIP(string item)
            {
                string sql = "update flume set ip ='" + item + "';";
                Update.Item(sql);
            }
            public static void ZipSize(string item)
            {
                string sql = "update zip set size ='" + item + "';";
                Update.Item(sql);
            }
            public static void CaseFolder(string item)
            {
                string sql = "update case_folder set location ='" + item + "';";
                Update.Item(sql);
            }
            public static void FlumeDrive(string item)
            {
                string sql = "update flume set drive = '" + item + "';";
                Update.Item(sql);
            }
            public static void MedexType(string item, int id)
            {
                string sql = "update medex_types set type = '" + item + "' where id = " + id + ";";
                Update.Item(sql);
            }
            public static void CellexType(string item, int id)
            {
                string sql = "update cellex_types set type = '" + item + "' where id = " + id + ";";
                Update.Item(sql);
            }
            public static void Classification(string item, int id)
            {
                string sql = "update classifications set classification = '" + item + "' where id = " + id + ";";
                Update.Item(sql);
            }
            public static void AOR(string item, int id)
            {
                string sql = "update aors set aor = '" + item + "' where id = " + id + ";";
                Update.Item(sql);
            }
            public static void Case(string case_id, string mgrs, string objective, string subject_name, int aor_id, int classification_id, string submitter_name, string submitter_email, string comments, bool suppressMessage = false)
            {
                string sql = "update cases set case_id = '" + case_id + "'," +
                "mgrs = '" + mgrs + "'," +
                "objective = '" + objective + "'," +
                "subject_name = " + subject_name + "'," +
                "aor_id = " + aor_id + "'," +
                "classification_id = " + classification_id + "'," +
                "submitter_name = '" + submitter_name + "'," +
                "submitter_email = '" + submitter_email + "'," +
                "updated_date = '" + DateTime.Now.ToString() + "'," +
                "comments = '" + comments + "';";

                Update.Item(sql);
            }
            private static void Item(string sql)
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
