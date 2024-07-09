using SE_Project.Pages;
using SE_Project.Forms;
using SE_Project.PagesParts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SE_Project.Helpers
{
    class DBHelper
    {
        static string conString = @"Data Source=DESKTOP-2DTOCB6\SQLEXPRESS;Initial Catalog=TaskSphere1;Integrated Security=True;";

        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader reader;

        public DBHelper()
        {
            conn = new SqlConnection(conString);
            cmd = new SqlCommand();
        }

        public bool connect()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool disconnect()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public string InsertRow(string query)
        {
            try
            {
                if (connect())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        return "Row inserted successfully.";
                    }
                    else
                    {
                        return "No rows were inserted.";
                    }
                }
                else
                {
                    return "Failed to connect to database.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            finally
            {
                disconnect();
            }
        }

        public string DeleteRow(string query)
        {
            try
            {
                if (connect())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    int result = cmd.ExecuteNonQuery();
                    return result > 0 ? "Row deleted successfully." : "No rows were deleted.";
                }
                else
                {
                    return "Failed to connect to database.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            finally
            {
                disconnect();
            }
        }

        public int GetTotalRowCount(string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName};";
            try
            {
                if (connect())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar()); // ExecuteScalar used for single value
                    return rowCount; // Return the row count directly
                }
                else
                {
                    throw new Exception("Failed to connect to database.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed: " + ex.Message);
            }
            finally
            {
                disconnect();
            }
        }


        public string getButtons(string query, FlowLayoutPanel panel)
        {
            string ret = "";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query.ToLower();
                connect();

                reader = cmd.ExecuteReader();

                string id, name, description;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    description = reader[2].ToString();

                    //btnProduct btn = new btnProduct();
                    ProjectCard btn = new ProjectCard();

                    btn.ProjectTitle = name;
                    btn.ProjectDesc = description;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            finally
            {
                disconnect();
            }
            return ret;
        }

        


        public bool userAuth(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM userlist WHERE username = @username AND password = @password;";
            try
            {
                if (connect())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = Convert.ToInt32(cmd.ExecuteScalar()); // ExecuteScalar used for single value
                    return result > 0; // If count is more than 0, credentials are correct
                }
                else
                {
                    throw new Exception("Failed to connect to the database.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed: " + ex.Message);
            }
            finally
            {
                disconnect();
                cmd.Parameters.Clear(); // Clear parameters to prevent issues on subsequent calls
            }
        }
    }
}
