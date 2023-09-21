using Entregable_Facturacion.Data;
using Entregable_Facturacion.Entitys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable_Facturacion.Services
{
    public class ServiceArticulo
    {
        DBHelper helper;
        public ServiceArticulo()
        {
            helper = new DBHelper();
        }

        public DataTable TablaArticulos()
        {
            return helper.getTabla("ARTICULOS", 1);
        }

        public List<Articulo> listaArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            DataTable dt = new DataTable();
            dt = TablaArticulos();

            foreach (DataRow x in dt.Rows)
            {
                Articulo a = new Articulo();
                a.ID = Convert.ToInt32(x[0].ToString());
                a.Nombre = x[1].ToString();
                a.PrecioUnitario = (double)x[2];

                lista.Add(a);
            }

            return lista;
        }





    }
}
