using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Práctica8
{
    public partial class añadir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void bt_Añadir_Click(object sender, EventArgs e)
        {
            if (FormularioCorrecto)
            {
                // La carpeta raíz del sitio web es "~/"
                string sRutaSitioWeb = Server.MapPath("~/"); // ver documentación de Page.Server
                                                             // Subimos los archivos al servidor
                sa_SubirArchivo.PostedFile.SaveAs(sRutaSitioWeb +
                "fotos/" + sa_SubirArchivo.FileName);

                //Guardamos la información en la base de datos
                string foto = "fotos/" + sa_SubirArchivo.FileName;
                string nombre = ct_Nombre.Text;
                string autor = ct_Autor.Text;

                string descripcion = ct_Descripcion.Text;
                if (descripcion.Length == 0)
                    descripcion = "-- Sin Descripción --";
                /*string sconexión = ConfigurationManager.ConnectionStrings["fotosConnectionString"].ConnectionString; // ver clase ConfigurationManager
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
                ordenSQL.Connection.Close();*/

                AlbumFotos.Service1Client servicio = new AlbumFotos.Service1Client();
                servicio.AñadirFoto(foto, nombre, autor, descripcion);

                this.Response.Redirect("../Default.aspx");
            }
        }

        protected bool FormularioCorrecto
        {
            get
            {
                bool bCorrecto = true;
                // Volvemos a dejar en blanco los comentarios
                et_Nombre.Text = "";
                et_Autor.Text = "";
                et_Archivo.Text = "";
                // Comprobamos el formulario
                if (sa_SubirArchivo.FileName.Length == 0)
                {
                    et_Archivo.Text = "* Error: Seleccione un archivo!!";
                    bCorrecto = false;
                }
                // Comprobar también el Nombre y el Autor
                // ...
                if(ct_Nombre.Text.Length == 0)
                {
                    et_Nombre.Text = "* Error: Introduzca un nombre!";
                    bCorrecto = false;
                }
                if (ct_Autor.Text.Length == 0)
                {
                    et_Autor.Text = "* Error: Introduzca un autor!";
                    bCorrecto = false;
                }
                return bCorrecto;
            }
        }
    }
}