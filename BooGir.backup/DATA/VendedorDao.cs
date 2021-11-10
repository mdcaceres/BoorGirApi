using BooGir.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooGir.DATA.servicios
{
    class VendedorDao : IDaoVendedores
    {
        HelperDao helper; 

        public VendedorDao()
        {
            helper = HelperDao.GetHelper(); 
        }

        public int BringInt(CommandType type, string CommandText, string ParamName, SqlDbType sqlType, ParameterDirection direction)
        {
            return helper.BringInt(type, CommandText, ParamName, sqlType, direction); 
        }

        public bool Create(Vendedor vendedor)
        {
            SqlTransaction transact = null;
            bool flag = true;
            try
            {
                helper.OpenConn();

                transact = helper.TransactBegin(transact);
                //asegurase de mantener limpios los parametros
                helper.ClearParams();
                //creo el comando y le asigno la transaccion 
                helper.SetCommand(CommandType.StoredProcedure, "SP_INSERTAR_VENDEDOR", transact);
                helper.AddParamsValue("@nombre", vendedor.nom_vendedor);
                helper.AddParamsValue("@apellido", vendedor.ape_vendedor);
                helper.AddParamsValue("@nom_usuario", vendedor.usuario);
                helper.AddParamsValue("@pwd", vendedor.password);
                helper.command.ExecuteNonQuery();
                transact.Commit();
                return flag;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                helper.CloseConn();
            }
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
    }
}
