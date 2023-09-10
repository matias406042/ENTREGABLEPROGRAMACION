using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Entregable_1.Entities
{
    public class Factura
    {

        public int NroFactura { get; set; }

        public DateTime Fecha { get; set;}
        
        public FormaPago FormaP { get; set; }

        public List<DetalleFactura> DetFact { get; set; }

        public Factura() {
        
               FormaP = new FormaPago();
               DetFact = new List<DetalleFactura>();
        }
         public Factura(int nroFactura,DateTime fecha,FormaPago formap ) { 
        
            NroFactura = nroFactura;
            Fecha = fecha;
            FormaP = formap;
            DetFact = new List<DetalleFactura>();
        }
        
        public void RemoverDetalle(int posicion)
        {
            DetFact.RemoveAt(posicion);

        }
         public bool AgregarDetalle(DetalleFactura detalle)
         {
            bool aux= true;
            foreach (DetalleFactura x in DetFact)
            {
                if (x.Art.Nombre == detalle.Art.Nombre)
                {
                    aux = false;
                    return aux;
                }        

            }
            DetFact.Add(detalle);
            return aux;
            
         }

         public double TotalDetalles() 
        {
            double total=0;

            foreach (DetalleFactura d in DetFact)
            {

                total += d.CalcularSubTotal();
            }
            return total;
        }


         
    }
}
