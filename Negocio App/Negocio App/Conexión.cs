using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Negocio_App
{
    public class Conexión
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-QUV81SK;Initial Catalog=Negocio_App;Integrated Security=True");

        public void conectar()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion a la base de datos establecida");
            }
            catch
            {
                MessageBox.Show("Hubo un error al conectar con la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }

        public DataTable consulta_Mos (string tipo)
        {

            DataTable tabla = new DataTable();
            SqlDataAdapter retro = new SqlDataAdapter(tipo, conexion);
            retro.Fill(tabla);
            return tabla;


        }

        public void GuardarCli(DatosCli Newcli)
        {
            string cmdSQL = "sp_InsertCli";
            SqlCommand cmdguardar = new SqlCommand(cmdSQL, conexion);
            conexion.Open();
            cmdguardar.CommandType = CommandType.StoredProcedure;

            cmdguardar.Parameters.AddWithValue("@codigo", Newcli.codigocli);
            cmdguardar.Parameters.AddWithValue("@nombre", Newcli.nombrecli);
            cmdguardar.Parameters.AddWithValue("@apellido", Newcli.apellidocli);
            cmdguardar.Parameters.AddWithValue("@direccion", Newcli.direccioncli);
            cmdguardar.Parameters.AddWithValue("@telefono", Newcli.telefonocli);
            cmdguardar.Parameters.AddWithValue("@fecha", Newcli.fechacli);

            cmdguardar.ExecuteNonQuery();
            conexion.Close();
        }

        public void GuardarPro(Datospro Newpro)
        {
            string cmdSQL = "sp_InsertPro";
            SqlCommand cmdguardar = new SqlCommand(cmdSQL, conexion);
            conexion.Open();
            cmdguardar.CommandType = CommandType.StoredProcedure;

            cmdguardar.Parameters.AddWithValue("@Codigo", Newpro.codigopro);
            cmdguardar.Parameters.AddWithValue("@Nombre", Newpro.nombrepro);
            cmdguardar.Parameters.AddWithValue("@Distribuidor", Newpro.distribuidor);
            cmdguardar.Parameters.AddWithValue("@Precio", Newpro.precio);
            cmdguardar.Parameters.AddWithValue("@Cantidad", Newpro.cantidad);
            cmdguardar.Parameters.AddWithValue("@Fecha", Newpro.fecha);
            cmdguardar.Parameters.AddWithValue("@Pre_ven", Newpro.precioven);

            cmdguardar.ExecuteNonQuery();
            conexion.Close();
        }

        public void InsertFact (DatosFactura Newfact)
        {
           try
           {
                
                string cmdSQL = "sp_Rgisfac";             
                SqlCommand cmdguardar = new SqlCommand(cmdSQL, conexion);
                conexion.Open();
                cmdguardar.CommandType = CommandType.StoredProcedure;

                
                cmdguardar.Parameters.AddWithValue("@codigofact", Newfact.codigofact);
                cmdguardar.Parameters.AddWithValue("@codigo", Newfact.CODproducto);
                cmdguardar.Parameters.AddWithValue("@cantidad ", Newfact.cantidad);
                cmdguardar.Parameters.AddWithValue("@nombrepro", Newfact.nombrepro);
                cmdguardar.Parameters.AddWithValue("@Total", Newfact.total);             



                cmdguardar.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Producto agregado");
            }
            catch(SqlException e)
            {
                MessageBox.Show("Error"+e);
            }
            
        }

        public void DeleteCli(int cod)
        {
            string cmdSQL = "sp_Deletecli";
            SqlCommand cmdborrar = new SqlCommand(cmdSQL, conexion);
            conexion.Open();
            cmdborrar.CommandType = CommandType.StoredProcedure;

            cmdborrar.Parameters.AddWithValue("@codigo", cod);

            cmdborrar.ExecuteNonQuery();
            conexion.Close();
        }

        public void DeletePro(int cod)
        {
            string cmdSQL = "sp_Deletepro";
            SqlCommand cmdborrar = new SqlCommand(cmdSQL, conexion);
            conexion.Open();
            cmdborrar.CommandType = CommandType.StoredProcedure;

            cmdborrar.Parameters.AddWithValue("@codigo", cod);

            cmdborrar.ExecuteNonQuery();
            conexion.Close();
        }
        
          public void Deletedet(int cod)
        {
            string cmdSQL = "sp_deletedetalle";
            SqlCommand cmdborrar = new SqlCommand(cmdSQL, conexion);
            conexion.Open();
            cmdborrar.CommandType = CommandType.StoredProcedure;

            cmdborrar.Parameters.AddWithValue("@codigodet", cod);

            cmdborrar.ExecuteNonQuery();
            conexion.Close();
        }
        public void buscar (string cade, out string apellido, out string code, out string nom)
        {
            
            SqlCommand cmd = new SqlCommand(cade, conexion);
            conexion.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {

                apellido=registro["Ape_Cli"].ToString();
                code = registro["Cod_Cli"].ToString();
                nom = registro["Nom_Cli"].ToString();

            }
            else
            {
                apellido = "";
                code = "NULL";
                nom = "";
            }
            conexion.Close();
           


        }

         public void newfact(int codCli, string tipo)
        {
           
            DateTime fecha = DateTime.Today;
            string cmdSQL = "sp_newfact";
            SqlCommand cmdguardar = new SqlCommand(cmdSQL, conexion);
            conexion.Open();

            cmdguardar.CommandType = CommandType.StoredProcedure;

            cmdguardar.Parameters.AddWithValue("@codigocli",codCli);
            cmdguardar.Parameters.AddWithValue("@TipoFac", tipo);
            cmdguardar.Parameters.AddWithValue("@FECHA", fecha); 


            cmdguardar.ExecuteNonQuery();
            conexion.Close();

            
        }

       public  int buscarfact()
        {
            int cod ;
            SqlCommand cmd = new SqlCommand("SELECT TOP(1) Cod_Fac FROM Factura ORDER BY Cod_Fac DESC", conexion);
            conexion.Open();
            SqlDataReader codigo = cmd.ExecuteReader();

            if (codigo.Read())
            {
                cod = int.Parse(codigo["Cod_Fac"].ToString());
            }
            else
            {
                cod = -1;
            }
            conexion.Close();

            return cod;
        }

        public void cerrarfac(int total, int CODIGO)
        {
            try
            {

                string cmdSQL = "UPDATE Factura SET Tot_Fac = @TOTAL WHERE Cod_Fac = @CODIGO";
                SqlCommand guardar = new SqlCommand(cmdSQL, conexion);
                conexion.Open();
            
            guardar.Parameters.AddWithValue("@TOTAL", total);
            guardar.Parameters.AddWithValue("@CODIGO",CODIGO);

            guardar.ExecuteNonQuery();
            MessageBox.Show("Factura guardada" + total);
            conexion.Close();
                

                //return total;

           }
           catch
            {
                MessageBox.Show("Error al gaurdar la factura");
                //int total = 0;
                //return total;
            }

        }

        
    }
}
