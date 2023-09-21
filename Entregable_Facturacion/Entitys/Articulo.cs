using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable_Facturacion.Entitys
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }

        public Articulo() { }
        public Articulo(string nombre, double p)
        {

            Nombre = nombre;
            PrecioUnitario = p;

        }

        public string Mostrar()
        {
            return Nombre + " " + PrecioUnitario;

        }
    }
}
