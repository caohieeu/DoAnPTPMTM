﻿using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
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
        /// <summary>
        /// Sử dụng với thao tác update, insert, delete
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Sủ dụng với lệnh select, trả về 1 datatable
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Sủ dụng với lệnh nhiều select, trả về 1 dataset
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet ExecuteQueryDataset(string sqlQuery, CommandType commandType, params IDataParameter[] parameters)
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
                        DataSet resultTable = new DataSet();
                        adapter.Fill(resultTable);
                        return resultTable;  //
                    }
                }
            }
        }
    }
}
