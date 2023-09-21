using Entregable_Facturacion.Entitys;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregable_Facturacion.Data
{
    public class DBHelper
    {
        string cadena = @"Data Source=DESKTOP-JDKTHBG\SQLEXPRESS;Initial Catalog = Entregable_Prog2; Integrated Security = True;TrustServerCertificate = true";
        SqlConnection cnn;
        SqlCommand cmd;
        public DBHelper()
        {
            cnn = new SqlConnection(cadena);
        }

        private void Conectarse()
        {
          //  Desconectarse();
            cnn.Open();
            cmd = new SqlCommand();
            cmd.Connection = cnn;

        }


        private void Desconectarse()
        {

            cnn.Close();
        }

        public DataTable getTabla(string tabla, int orderBy)
        {

            DataTable dt = new DataTable();
            Conectarse();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tabla + " order by " + orderBy;
            dt.Load(cmd.ExecuteReader());
            Desconectarse();
            return dt;
        }

        public DataTable SPConsultar(string nombreSP)
        {

            DataTable tabla = new DataTable();
            Conectarse();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;

            tabla.Load(cmd.ExecuteReader());

            Desconectarse();
            return tabla;

        }


        public bool SPInsertFactura(Factura f)
        {
            bool aux = true;

            SqlTransaction t = null;

            try
            {
                Conectarse();

                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERTAR_FACTURA";

                cmd.Parameters.AddWithValue("@FECHA", f.Fecha);
                cmd.Parameters.AddWithValue("@ID_FORMA_PAGO", f.FormaP.Id);

                SqlParameter p = new SqlParameter();
                p.Direction = ParameterDirection.Output;
                p.ParameterName = "@ID_FACTURA";
                p.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                int NroFactura = (int)p.Value;
                int nroD = 1;

                foreach (DetalleFactura x in f.DetFact)
                {
                    SqlCommand cmd2 = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    MessageBox.Show("f2");

                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@FACTURA_NRO", NroFactura);
                    cmd2.Parameters.AddWithValue("@ID_ARTICULO", x.Art.ID);
                    cmd2.Parameters.AddWithValue("@CANTIDAD", x.Cantidad);

                    cmd2.ExecuteNonQuery();

                }

                t.Commit();
            }
            catch
            {
                t.Rollback();
                aux = false;

            }
            finally
            {
                if ((cnn != null) && (cnn.State == ConnectionState.Closed))
                    Desconectarse();
            }
            return aux;

        }


        public bool SPDeleteFactura( int nroF)
        {
            //CREAR SP EN BASE DE DATOS

            bool aux = true;

            SqlTransaction t = null;



            try
            {

                Conectarse();

                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_DELETE_FACTURA";

                cmd.Parameters.AddWithValue("@ID_FACTURA", nroF);

                cmd.ExecuteNonQuery();

                t.Commit();
            }
            catch
            {
                t.Rollback();
                aux = false;
                MessageBox.Show("al catch");

            }
            finally
            {
                
                    Desconectarse();
            }
            return aux;

        }


    }
}
