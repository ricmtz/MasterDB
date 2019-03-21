using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterBB
{
    class MasterDB
    {
        public String ConnectionString { get; private set; }
        private SqlConnection connection;

        public MasterDB(String conString)
        {
            this.ConnectionString = conString;
            this.connection = new SqlConnection(ConnectionString = this.ConnectionString);
        }

        public List<string> GetAllBD()
        {
            List<string> dbNames = new List<string>();
            try {
                this.connection.Open();
                string query = "SELECT name FROM master.dbo.sysdatabases";
                SqlCommand command = new SqlCommand(query, this.connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dbNames.Add(reader["name"].ToString());
                }
            } catch (Exception ex) {
                throw  ex;
            } finally {
                this.connection.Close();
            }
            return dbNames;
        }

        public List<string> GetAllTables(string table)
        {
            List<string> tableNames = new List<string>();
            try
            {
                this.connection.Open();
                string query = "SELECT * FROM " + table + ".INFORMATION_SCHEMA.TABLES";
                SqlCommand command = new SqlCommand(query, this.connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tableNames.Add(reader["TABLE_NAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.connection.Close();
            }
            return tableNames;
        }

        public List<string> GetAllViews(string table)
        {
            List<string> viewNames = new List<string>();
            try
            {
                this.connection.Open();
                string query = "SELECT * FROM " + table + ".INFORMATION_SCHEMA.VIEWS";
                SqlCommand command = new SqlCommand(query, this.connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    viewNames.Add(reader["TABLE_NAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.connection.Close();
            }
            return viewNames;
        }

        public List<string> GetAllSP(string table)
        {
            List<string> spNames = new List<string>();
            try
            {
                this.connection.Open();
                string query = "SELECT * FROM " + table + ".INFORMATION_SCHEMA.ROUTINES";
                SqlCommand command = new SqlCommand(query, this.connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    spNames.Add(reader["ROUTINE_NAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.connection.Close();
            }
            return spNames;
        }

    }
}
