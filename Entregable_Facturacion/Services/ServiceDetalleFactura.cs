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
    public class ServiceDetalleFactura
    {
        DBHelper helper;
        public ServiceDetalleFactura()
        {
            helper = new DBHelper();

        }


        public DataTable TablaDetalles()
        {

            return helper.getTabla("Detalles_Factura", 1);




        }
        public List<DetalleFactura> ListaDetalleFactura(int nroFactura)
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            DataTable dt = TablaDetalles();
            List<Articulo> lArt = new List<Articulo>();
            foreach (DataRow i in dt.Rows)
            {
                if (Convert.ToInt32(i[1]) == nroFactura)
                {
                    DetalleFactura nuevo = new DetalleFactura();
                   
                        nuevo.Art.ID = Convert.ToInt32(i[0]);
                  
                  
                        
                    
                
                    nuevo.Cantidad = Convert.ToInt32(i[2]);
                    ServiceArticulo sa = new ServiceArticulo();
                    lArt = sa.listaArticulos();
                    foreach (Articulo a in lArt)
                    {
                        if (a.ID == nuevo.Art.ID)
                        {
                            nuevo.Art = a;
                        }
                    }

                    lista.Add(nuevo);

                }

            }
            return lista;


        }


    }
}
