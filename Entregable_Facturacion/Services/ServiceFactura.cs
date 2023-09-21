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
    public class ServiceFactura
    {
        DBHelper helper;
        public ServiceFactura()
        {
            helper = new DBHelper();

        }



        public bool InsertarFactura(Factura f)
        {

            return helper.SPInsertFactura(f);


        }

        public bool EliminarFactura(int id) { 
        
        return helper.SPDeleteFactura(id);
        }
        public DataTable TablaFacturas()
        {
            DataTable table = new DataTable();

            table = helper.getTabla("Facturas", 1);

            return table;


        }

        public List<Factura> ListaFacturas()
        {
            DataTable table = TablaFacturas();
            List<Factura> listaF = new List<Factura>();
            List<FormaPago> listaFP = new List<FormaPago>();
            foreach (DataRow l in table.Rows)
            {
                Factura f = new Factura();
                f.NroFactura = Convert.ToInt32(l[0]);
                f.Fecha = Convert.ToDateTime(l[1]);
                f.FormaP.Id = Convert.ToInt32(l[2]);
                ServiceFormaPago sFP = new ServiceFormaPago();
                listaFP = sFP.listaFormasPago();
                foreach (FormaPago i in listaFP)
                {
                    if (i.Id == f.FormaP.Id)
                    {
                        f.FormaP = i;
                    }

                }
                ServiceDetalleFactura serviceDF = new ServiceDetalleFactura();
                f.DetFact = serviceDF.ListaDetalleFactura(f.NroFactura);
                listaF.Add(f);
            }

            return listaF;


        }




        //public List<SqlParameter> ListaParametros(Factura f) {

        //    List<SqlParameter> lista = new List<SqlParameter>();
        //    lista.Add(new SqlParameter("@FECHA",f.Fecha));
        //    lista.Add(new SqlParameter("@ID_FORMA_PAGO",f.FormaP.Id));

        //    SqlParameter p = new SqlParameter();
        //    p.Direction = ParameterDirection.Output;
        //    p.SqlDbType = SqlDbType.Int;
        //    p.ParameterName = "@ID_FACTURA";
        //    lista.Add(p);
        //    return lista;

        //}



    }
}
