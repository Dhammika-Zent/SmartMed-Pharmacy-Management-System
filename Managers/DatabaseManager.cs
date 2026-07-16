using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SmartMed.Managers
{
    internal class DatabaseManager
    {
        // Private connection string, built from the application path
        private string connectionString = $"Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "SmartMed.db")};Version=3;";

        // Open a new database connection
        public SQLiteConnection OpenConnection()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
                return null;
            }
        }

        // Close the given database connection
        public void CloseConnection(SQLiteConnection conn)
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing connection: " + ex.Message);
            }
        }

        // Execute a SELECT query and return the result as a DataTable
        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection conn = OpenConnection())
                {
                    if (conn == null) return dt;
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query execution error: " + ex.Message);
            }
            return dt;
        }

        // Execute an INSERT, UPDATE, or DELETE statement
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                using (SQLiteConnection conn = OpenConnection())
                {
                    if (conn == null) return -1;
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Non-query execution error: " + ex.Message);
                return -1;
            }
        }

        // Execute a query that returns a single value
        public object ExecuteScalar(string sql)
        {
            try
            {
                using (SQLiteConnection conn = OpenConnection())
                {
                    if (conn == null) return null;
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Scalar execution error: " + ex.Message);
                return null;
            }
        }
    }
}