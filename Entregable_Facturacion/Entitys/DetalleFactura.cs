using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable_Facturacion.Entitys
{
    public class DetalleFactura
    {

        public Articulo Art { get; set; }
        public int Cantidad { get; set; }

        public DetalleFactura() {
        Art = new Articulo();

        }

        public DetalleFactura(Articulo a, int c)
        {
            this.Art = a;
            this.Cantidad = c;

        }
        public double CalcularSubTotal()
        {
            return Cantidad * Art.PrecioUnitario;
        }
    }
}
