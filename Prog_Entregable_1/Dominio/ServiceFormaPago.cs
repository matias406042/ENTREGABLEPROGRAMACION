using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Prog_Entregable_1.Data;
using Prog_Entregable_1.Entities;

namespace Prog_Entregable_1.Dominio
{
    public class ServiceFormaPago
    {

        DBHelper helper;
        public ServiceFormaPago()
        {
            helper = new DBHelper();
        }

        public DataTable TablaFormasPago()
        {
            return helper.getTabla("Formas_Pago", 1);
        }

        public List<FormaPago> listaFormasPago()
        {
            List<FormaPago> lista = new List<FormaPago>();
            DataTable dt = new DataTable();
            dt = TablaFormasPago();

            foreach (DataRow x in dt.Rows)
            {
                FormaPago a = new FormaPago();
                a.Id = Convert.ToInt32( x[0].ToString());
                a.Name = (string)x[1];
                

                lista.Add(a);
            }

            return lista;
        }
    }
}
