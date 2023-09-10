using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Prog_Entregable_1.Data;
using Prog_Entregable_1.Entities;
using Microsoft.Data.SqlClient;

namespace Prog_Entregable_1.Dominio
{
    public class ServiceFactura
    {
        DBHelper helper;
        public ServiceFactura()
        {
            helper = new DBHelper();
            
        }

         

        public bool InsertarFactura(Factura f)
        {

          return  helper.SPInsertFactura( f);


        }

        public List<SqlParameter> ListaParametros(Factura f) {

            List<SqlParameter> lista = new List<SqlParameter>();
            lista.Add(new SqlParameter("@FECHA",f.Fecha));
            lista.Add(new SqlParameter("@ID_FORMA_PAGO",f.FormaP.Id));

            SqlParameter p = new SqlParameter();
            p.Direction = ParameterDirection.Output;
            p.SqlDbType = SqlDbType.Int;
            p.ParameterName = "@ID_FACTURA";
            lista.Add(p);
            return lista;

        }



    }
}
