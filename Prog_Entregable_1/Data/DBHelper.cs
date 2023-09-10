using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.ComponentModel.Design;
using Prog_Entregable_1.Entities;
using System.Runtime.Intrinsics.Arm;
using System.Collections;

namespace Prog_Entregable_1.Data
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

        public void Conectarse()
        {
            cnn.Open();
            cmd = new SqlCommand();
            cmd.Connection = cnn;

        }

         public void Desconectarse()
        {

            cnn.Close();
        }

        public DataTable getTabla(string tabla,int orden)
        {

            DataTable dt = new DataTable();
            Conectarse();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM "+tabla + " order by "+ orden;
            dt.Load(cmd.ExecuteReader());
            Desconectarse();
            return dt;
        } 

        public DataTable SPConsultar(string nombreSP) {
        
            DataTable tabla = new DataTable();
            Conectarse();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;

            tabla.Load(cmd.ExecuteReader());

            Desconectarse();        
            return tabla;
        
        }
        //public void SPInsertDetalles(Factura f,int nroF,SqlTransaction t)
        //{
        //     int nroD = 1;
        //     SqlCommand cmd2 = new SqlCommand();
        //    foreach (DetalleFactura x in f.DetFact)
        //    {
        //        cmd2 = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);

        //        cmd2.CommandType = CommandType.StoredProcedure;
        //        cmd2.Parameters.AddWithValue("@FACTURA_NRO", nroF);
        //        cmd2.Parameters.AddWithValue("@ID_DETALLE", nroD);
        //        cmd2.Parameters.AddWithValue("@ID_ARTICULO", x.Art.ID);
        //        cmd2.Parameters.AddWithValue("@CANTIDAD", x.Cantidad);
        //        cmd2.ExecuteNonQuery();
        //        nroD++;
        //    }



        //}

        public bool SPInsertFactura( Factura f)
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
                   
                    // ...
                    cmd2.ExecuteNonQuery();



                }

                MessageBox.Show("ANTES DEL COMMIT");
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
                if ((cnn != null) && (cnn.State == ConnectionState.Closed))
                Desconectarse();
            }
              return aux;
      
        }
        




    }
}
