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
    class FacturaDao : IDaoFacturas
    {
        HelperDao helper; 

        public FacturaDao()
        {
            helper = HelperDao.GetHelper(); 
        }
        public int GetNext()
        {
            return helper.BringInt(CommandType.StoredProcedure, "SP_PROXIMA_FACTURA", "@next", SqlDbType.Int, ParameterDirection.Output);
        }

        public DataTable ReturnTable(CommandType type, string CommandText)
        {
            return helper.BringTable(type, CommandText);
        }

        public int BringInt(CommandType type, string CommandText, string ParamName, SqlDbType sqlType, ParameterDirection direction)
        {
            throw new NotImplementedException();
        }

        public bool Create(Factura myFactura)
        {
            SqlTransaction transact = null;
            bool flag = false;
            try
            {
                helper.OpenConn();

                transact = helper.TransactBegin(transact);
                //asegurase de mantener limpios los parametros
                helper.ClearParams();
                //creo el comando y le asigno la transaccion 
                helper.SetCommand(CommandType.StoredProcedure, "SP_INSERTAR_MAESTRO", transact);

                helper.AddParamsValue("@id_vendedor", myFactura.IdVendedor);
                helper.AddParamsValue("@DNI", myFactura.DNI);
                helper.AddParamsValue("@id_forma", myFactura.FormaPago);
                helper.AddParamsValue("@descuento", myFactura.Descuento);
                helper.AddParamsValue("@total", myFactura.total);

                //recibiendo el parametro de salida ID DE LA FACTURA
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id_Factura";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                //AGREGO EL PARAMETRO
                helper.AddParameters(param);

                helper.command.ExecuteNonQuery();

                int idFactura = (int)param.Value;

                myFactura.IdFactura = idFactura;

                //------ insertar detalles -------
                int detNro = 1; 

                foreach(DetalleFactura det in myFactura.Detalles)
                {
                    helper.ClearParams();
                    helper.SetCommand(CommandType.StoredProcedure, "SP_INSERTAR_DETALLE", transact);

                    helper.AddParamsValue("@id_factura", myFactura.IdFactura);
                    helper.AddParamsValue("@detalle_nro", detNro);
                    helper.AddParamsValue("@id_producto", det.Producto.idProducto);
                    helper.AddParamsValue("@cantidad", det.Cantidad);
                    helper.AddParamsValue("@precio", det.Producto.preUnitario);

                    helper.command.ExecuteNonQuery();
                    detNro++;
                }
                transact.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                helper.CloseConn();
            }
            return flag;
        }

        public DataTable ReturnTable(CommandType type, string CommandText, string name0, string value0, string name1, string value1)
        {
            return helper.BringTable(type, CommandText, name0, value0, name1, value1);
        }

        public DataTable ReturnTable(CommandType type, string CommandText, string name, object value)
        {
            return helper.BringTable(type, CommandText, name, value);
        }
    }
}
