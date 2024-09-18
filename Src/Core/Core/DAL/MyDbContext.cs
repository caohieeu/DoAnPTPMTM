using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class MyDbContext : IMyDbcontext
    {   
        private readonly string _connectionString;
        public MyDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public int ExecuteCommand(string sqlCommand, CommandType commandType, params IDataParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ExecuteQuery(string sqlQuery, CommandType commandType, params IDataParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);
                        return resultTable;  //
                    }
                }
            }
        }
    }
}
