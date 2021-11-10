using LibraryBoorGir.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBoorGir.DATA
{
    public class PagosDao : IDao
    {
        HelperDao helper; 

        public PagosDao()
        {
            helper = HelperDao.GetHelper(); 
        }
        public int BringInt(CommandType type, string CommandText, string ParamName, SqlDbType sqlType, ParameterDirection direction)
        {
            throw new NotImplementedException();
        }

        public int GetNext()
        {
            throw new NotImplementedException();
        }

        public DataTable ReturnTable(CommandType type, string CommandText)
        {
            return helper.BringTable(type, CommandText); 
        }

        public DataTable ReturnTable(CommandType type, string CommandText, string name, object value)
        {
            throw new NotImplementedException();
        }
    }
}
