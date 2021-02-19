using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public void BorrarFoto(string foto)
        {
            // Borramos de la base de datos la ruta de la foto
            // seleccionada tal y como lo hacíamos en el sitio web
            //string sRutaSitioWeb = Server.MapPath("~/");
            // Borramos la imagen de la carpeta fotos
            //File.Delete(sRutaSitioWeb + ls_Nombres.SelectedValue);
            // Borramos la ruta de la imagen de la base de datos
            SqlConnection conexión = new SqlConnection(ConfigurationManager.ConnectionStrings["fotosConnectionString"].ConnectionString); // ver clase ConfigurationManager
            //string sconexión = ConfigurationManager.ConnectionStrings["fotosConnectionString"].ConnectionString;
            //SqlConnection con = new SqlConnection(sconexión);
            /*SqlCommand cmd = new SqlCommand("DELETE from album where foto = @FOTO", con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds, "album");*/

            
            string sOrdenSQL = "DELETE from album where foto = @FOTO";
            SqlCommand ordenSQL = new SqlCommand(sOrdenSQL, conexión);
            ordenSQL.Parameters.AddWithValue("@FOTO", foto);
            // ...
            ordenSQL.Connection.Open();
            ordenSQL.ExecuteNonQuery();
            ordenSQL.Connection.Close();
            
        }
        public void AñadirFoto(string foto, string nombre,
                                string autor, string descripcion)
        {
            // Añadimos una entrada en la base de datos tal y como lo
            // hacíamos en el sitio web
            //if (FormularioCorrecto)
            //{
                // La carpeta raíz del sitio web es "~/"
                //string sRutaSitioWeb = Server.MapPath("~/"); // ver documentación de Page.Server
                                                             // Subimos los archivos al servidor
                //sa_SubirArchivo.PostedFile.SaveAs(sRutaSitioWeb +
                //"fotos/" + sa_SubirArchivo.FileName);

                //Guardamos la información en la base de datos
                //string foto = "fotos/" + sa_SubirArchivo.FileName;
                //string nombre = ct_Nombre.Text;
                //string autor = ct_Autor.Text;

                //string descripcion = ct_Descripcion.Text;
                //if (descripcion.Length == 0)
                    //descripcion = "-- Sin Descripción --";
                string sconexión = ConfigurationManager.ConnectionStrings["fotosConnectionString"].ConnectionString; // ver clase ConfigurationManager
                SqlConnection conexión = new SqlConnection(sconexión);
                string sOrdenSQL = "insert into album (foto, nombre, autor," +
                " descripcion) values (@FOTO,@NOMBRE,@AUTOR,@DESCRIPCION)";
                SqlCommand ordenSQL = new SqlCommand(sOrdenSQL, conexión);
                ordenSQL.Parameters.AddWithValue("@FOTO", foto);
                ordenSQL.Parameters.AddWithValue("@NOMBRE", nombre);
                ordenSQL.Parameters.AddWithValue("@AUTOR", autor);
                ordenSQL.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                // Idem para autor, descripcion...
                // ...
                ordenSQL.Connection.Open();
                ordenSQL.ExecuteNonQuery();
                ordenSQL.Connection.Close();
                //this.Response.Redirect("Default.aspx");
            //}
        }

        /*public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/
    }
}
