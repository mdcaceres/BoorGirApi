
using BooGir.DATA.Interfaces;
using BooGir.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooGir.DATA
{
    class ClientesDao : IDaoCliente
    {
        HelperDao helper;

        public ClientesDao()
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
            return helper.BringTable(type, CommandText, name, value);
        }

        public void Create(Clientes cliente)
        {
            try
            {
                helper.OpenConn();
                //asegurase de mantener limpios los parametros
                helper.ClearParams();
                //creo el comando y le asigno la transaccion 
                helper.SetCommand(CommandType.StoredProcedure, "SP_INSERTAR_CLIENTE");
                helper.AddParamsValue("@DNI", cliente.Dni);
                helper.AddParamsValue("@tel_cliente", cliente.Telefono);
                helper.AddParamsValue("@nom_cliente", cliente.Nombre);
                helper.AddParamsValue("@ape_cliente", cliente.Apellido);
                helper.AddParamsValue("@id_barrio", cliente.IdBarrio);
                helper.AddParamsValue("@direccion", cliente.Direccion);
                helper.command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
            finally
            {
                helper.CloseConn();
            }
        }
    }
}
