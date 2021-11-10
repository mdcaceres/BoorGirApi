using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoorGirLibrary
{
    class HelperDao
    {
        //variable statica para el patron singleton 
        private static HelperDao instance;

        //properties del helper 
        private string strConnection;
        private SqlConnection conn;
        public SqlCommand command { get;  }

        //constructor privado 
        private HelperDao()
        {
            strConnection = Properties.Resources.StrConnection;
            conn = new SqlConnection(strConnection);
            command = new SqlCommand();
        }

        public static HelperDao GetHelper()
        {
            if (instance == null)
                instance = new HelperDao();

            return instance;
        }

        //devuelve el estado de la conexion
        private ConnectionState ConnState()
        {
            return conn.State;
        }

        //abre unicamente la conexion si esta se encuentra cerrada
        public void OpenConn()
        {
            if (ConnState().Equals(ConnectionState.Closed))
                conn.Open();
        }

        //cierra unicamente la conexion si esta se encuentra abierta
        public void CloseConn()
        {
            if (ConnState().Equals(ConnectionState.Open))
                conn.Close();
        }

        public void ClearParams()
        {
            command.Parameters.Clear();
        }

        //Asigna las properties del comando
        public void SetCommand(CommandType type, string CommandText)
        {
            command.Connection = conn;
            command.CommandType = type;
            command.CommandText = CommandText;
        }

        public void SetCommand(CommandType type, string CommandText, SqlTransaction transact)
        {
            command.Connection = conn;
            command.CommandType = type;
            command.CommandText = CommandText;
            command.Transaction = transact;
        }

        //me devuelve el datatable cargado con datos
        public DataTable BringTable(CommandType type, string CommandText)
        {
            try
            {
                DataTable table = new DataTable(); 
                OpenConn();
                table.Clear();
                ClearParams();
                SetCommand(type, CommandText);
                table.Load(command.ExecuteReader());
                //CloseConn(); 
                return table;
            }
            catch(SqlException ex)
            {
            throw ex; 
            }
            finally
            { 
                CloseConn(); 
            }

        }
        public DataTable BringTable(CommandType type, string CommandText,string name0, string value0, string name1, string value1)
        {
            try
            {
                DataTable table = new DataTable();
                OpenConn();
                table.Clear();
                ClearParams();
                SetCommand(type, CommandText);
                AddParamsValue(name0, value0);
                AddParamsValue(name1, value1);
                table.Load(command.ExecuteReader());
                //CloseConn(); 
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                CloseConn();
            }

        }
        public DataTable BringTable(CommandType type, string CommandText, string name, object value)
        {
            try
            {
                DataTable table = new DataTable();
                OpenConn();
                table.Clear();
                ClearParams();
                SetCommand(type, CommandText);
                AddParamsValue(name, value);
                table.Load(command.ExecuteReader());
                //CloseConn(); 
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                CloseConn();
            }

        }
        public void AddParameters(SqlParameter param)
        {
            command.Parameters.Add(param);
        }
        public void AddParamsValue(string param, object value)
        {
            command.Parameters.AddWithValue(param, value); 
        }

        public SqlParameter BringParameter(string paramName, SqlDbType type, ParameterDirection direction)
        {
            SqlParameter param = new SqlParameter(paramName, type);
            param.Direction = direction;
            AddParameters(param);
            return param;
        }

        public int BringInt(CommandType type, string CommandText, string ParamName, SqlDbType sqlType, ParameterDirection direction)
        {
                OpenConn();
                command.Parameters.Clear(); 
                SetCommand(type, CommandText);
                SqlParameter param = BringParameter(ParamName, sqlType, direction);
                command.ExecuteNonQuery();
                CloseConn();
                return (int)param.Value;
        }

        public string BringString(CommandType type, string CommandText, string ParamName, SqlDbType sqlType, ParameterDirection direction)
        {
            OpenConn();
            command.Parameters.Clear();
            SetCommand(type, CommandText);
            SqlParameter param = BringParameter(ParamName, sqlType, direction);
            command.ExecuteNonQuery();
            CloseConn();
            return param.Value.ToString();
        }
        public SqlTransaction TransactBegin(SqlTransaction transaction)
        {
            transaction = conn.BeginTransaction();
            return transaction;
        }

    }
}
