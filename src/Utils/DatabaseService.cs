﻿using System.Data;
using System.Data.OleDb;

namespace DentalSoftware.Utils
{
    public class DatabaseService
    {
        private string _connectionString;

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetDataTable(string query, params OleDbParameter[] values)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;
                    
                    command.Parameters.AddRange(values);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        command.Parameters.Clear();

                        return table;
                    }
                }
            }
        }

        public int ExecuteNonQuery(string query, params OleDbParameter[] values)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    command.Parameters.AddRange(values);

                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
