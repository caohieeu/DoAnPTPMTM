using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public interface IMyDbcontext
    {
        int ExecuteCommand(string sqlCommand, CommandType commandType, params IDataParameter[] parameters);

        DataTable ExecuteQuery(string sqlQuery, CommandType commandType, params IDataParameter[] parameters);
    }
}
