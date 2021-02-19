using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using BDFamosos;

namespace ApWinForms
{
    public partial class ElementoLista : UserControl
    {
        public ElementoLista()
        {
            InitializeComponent();
            // Obtener el enlace con la propiedad Image del control imgFamoso
            // para gestionar su evento Format
            Binding bImagen = this.imgFamoso.DataBindings["Image"];
            bImagen.Format += this.StringToBitmap;
        }

        private void StringToBitmap(object sender, ConvertEventArgs e)
        {
            // Format ocurre siempre que haya que mostrar en imgFamoso
            // el valor de la propiedad Imagen (la ruta de la imagen)
            if (e.DesiredType != typeof(Image)) return;
            // Convertir la ruta de la imagen a un Bitmap
            e.Value = Bitmap.FromFile(ObtenerRutaImagen(e.Value as string));
        }

        public CFamosoBO ObjetoVinculado
        {
            get { return this.famosoBindingSource.DataSource as CFamosoBO; }
            set
            {
                // Vincular objeto
                this.famosoBindingSource.DataSource = value;
                // Establecer un tooltip en la imagen que muestre el ID correspondiente
                // al objeto CFamosoBO
                if (value != null)
                {
                    string msj = "ID famoso: " + value.Id;
                    this.toolTip1.SetToolTip(imgFamoso, msj);
                }
            }
        }

        private string ObtenerRutaImagen(string nombreImagen)
        {
            string carpeta =
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            carpeta = Path.Combine(carpeta, "Imagenes");
            return Path.Combine(carpeta, nombreImagen);
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
