using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica5
{
    public partial class VisorImágenes : Form
    {
        public VisorImágenes()
        {
            InitializeComponent();
            ActualizarMenús();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 dlg = new AboutBox1();
            dlg.ShowDialog();
        }

        private void VentanaCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void VentanaMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void VentanaMosaicoVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void VisorImágenes_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArchivoNuevo_Click(object sender, EventArgs e)
        {
            int númeroHijas = this.MdiChildren.Length;
            string título = "Doc" + (númeroHijas + 1);
            NuevaHija(título);
        }

        private void NuevaHija(string título)
        {
            VentanaHija hija = new VentanaHija(título);
            hija.MdiParent = this;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();
            this.HijaActiva.PictureBox.Image = Properties.Resources.Imagen3;
        }

        public VentanaHija HijaActiva 
        {
            get { return (VentanaHija)this.ActiveMdiChild; }
        }

        private void ArchivoCerrar_Click(object sender, EventArgs e)
        {
            this.HijaActiva.Close();
        }

        private void ArchivoAbrir_Click(object sender, EventArgs e)
        {
            // Mostrar diálogo OpenFileDialog
            OpenFileDialog DlgAbrir = new OpenFileDialog();
            // Mediante la propiedad Filter indicamos el tipo de archivos
            // que se permiten abrir y mediante Title especificamos
            // un título explicativo para la ventana.
            //DlgAbrir.InitialDirectory = Directory.GetCurrentDirectory();
            DlgAbrir.Filter = "Ficheros BMP|*.bmp" +
                                "|Ficheros GIF|*.gif" +
                                "|Ficheros JPG o JPEG|*.jpg;*.jpeg" +
                                "|Ficheros PNG|*.png";
            DlgAbrir.FilterIndex = 3;
            // Si el resultado del diálogo es distinto de OK, terminar.
            if (DlgAbrir.ShowDialog() == DialogResult.OK)
            {
                byte[] contenidoArchivo = File.ReadAllBytes(DlgAbrir.FileName);
                //string título = DlgAbrir.SafeFileName;
                string título = DlgAbrir.FileName;

                //Properties.Resources a = new Properties.Resources();
                
                // Creamos un flujo de tipo MemoryStream pasándole el contenido
                // del archivo.
                // Usamos el método FromStream de la clase Image para crear una
                // "imagen" a partir del flujo anterior.

                //Image.FromStream(new MemoryStream(contenidoArchivo));
                // Creamos una nueva ventana hija con el método NuevaHija,
                // pasándole como título el nombre del archivo abierto.
                NuevaHija(título);
                // Obtenemos una referencia a la nueva ventana mediante la
                // propiedad HijaActiva.
                // Asignamos "imagen" al picture box de la nueva ventana 
                HijaActiva.PictureBox.Image = Image.FromStream(new MemoryStream(contenidoArchivo));
            }
        }

        private void VisorImágenes_MdiChildActivate(object sender, EventArgs e)
        {
            ActualizarMenús();
            ToolStripManager.RevertMerge(this.toolStripPadre);
            VentanaHija ventanaHijaActiva = this.ActiveMdiChild as VentanaHija;
            if (ventanaHijaActiva != null)
                ToolStripManager.Merge(ventanaHijaActiva.toolStripHija, this.toolStripPadre);
            
            // invocar a Merge

        }

        private void ActualizarMenús()
        {
            ArchivoCerrar.Enabled = this.HijaActiva != null;
            VentanaMosaicoHorizontal.Enabled = this.HijaActiva != null;
            VentanaMosaicoVertical.Enabled = this.HijaActiva != null;
        }

        private void VisorImágenes_DragEnter(object sender, DragEventArgs e)
        {
            // Nos aseguramos de que lo que se está arrastrando son archivos
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!file.ToUpper().EndsWith(".JPG") &&
                !file.ToUpper().EndsWith(".BMP") &&
                !file.ToUpper().EndsWith(".GIF"))
                {
                    e.Effect = DragDropEffects.None; // Alguno de los archivos
                                                     // no es una imagen
                    return;
                }
            }
            e.Effect = DragDropEffects.Copy; // Correcto, son todo imágenes

        }

        private void VisorImágenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                AbrirArchivo(file);

        }

        private void AbrirArchivo(string file)
        {
            byte[] contenidoArchivo = File.ReadAllBytes(file);
            NuevaHija(file);
            HijaActiva.PictureBox.Image = Image.FromStream(new MemoryStream(contenidoArchivo));
        }

        private void ArchivoNuevo_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Crear una nueva ventana con una imagen predefinida";
        }

        private void ArchivoNuevo_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Listo";
        }

        private void ArchivoAbrir_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Crear una nueva ventana con una imagen a seleccionar";
        }

        private void ArchivoAbrir_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Listo";
        }

        private void VentanaCascada_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Cascada";
        }

        private void ocultarBarraDeEstado_Click(object sender, EventArgs e)
        {
            if(statusStrip1.Visible)
            {
                statusStrip1.Hide();
                ocultarBarraDeEstado.Text = "Mostrar barra de estado";
            }
            else
            {
                statusStrip1.Visible = true;
                ocultarBarraDeEstado.Text = "Ocultar barra de estado";
            }
        }

        private void verToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (statusStrip1.Visible)
                ocultarBarraDeEstado.Checked = true;
            else
                ocultarBarraDeEstado.Checked = false;
            if (toolStripPadre.Visible)
                ocultarBarraDeHerramientas.Checked = true;
            else
                ocultarBarraDeHerramientas.Checked = false;
        }

        private void ocultarBarraDeHerramientas_Click(object sender, EventArgs e)
        {
            if(toolStripPadre.Visible)
            {
                toolStripPadre.Hide();
                ocultarBarraDeHerramientas.Text = "Mostrar barra de herramientas";
            }
            else
            {
                toolStripPadre.Visible = true;
                ocultarBarraDeHerramientas.Text = "Ocultar barra de herramientas";
            }
        }
    }
}
