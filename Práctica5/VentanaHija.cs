using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica5
{
    public partial class VentanaHija : Form
    {
        public VentanaHija(string título)
        {
            InitializeComponent();
            this.Text = título;
        }

        public PictureBox PictureBox 
        {
            get { return m_PictureBox; }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ImagenAjustar_Click(object sender, EventArgs e)
        {
            // Si no estamos en modo ajustar, activamos este modo
            if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.AutoSize)
            {
                this.AutoScroll = false;
                this.PictureBox.Size = this.ClientSize;
                this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            // Si estamos en modo ajustar, desactivamos este modo
            else if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.Zoom)
            {
                this.AutoScroll = true;
                this.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            ImagenAjustar.Checked =
                this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom;

        }

        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
                this.PictureBox.Size = this.ClientSize;

        }

        private void rotar90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image == null) 
                return;
            int ancho = PictureBox.Width;
            PictureBox.Width = PictureBox.Height;
            PictureBox.Height = ancho;
            PictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PictureBox.Size = this.ClientSize;
            PictureBox.Refresh();
        }

        private void VentanaHija_Click(object sender, EventArgs e)
        {

        }

        private void ImagenAñadirTexto_Click(object sender, EventArgs e)
        {
            using (Graphics gfx = Graphics.FromImage(this.PictureBox.Image))
            {
                // Utilizar el método DrawString de gfx para pintar el texto
                // "Programación Visual" en la posición 0,0 del área de
                // cliente, utilizando una fuente Arial de 20 ptos
                // y una brocha del color deseado.
                //RectangleF rectf = new RectangleF(70,90,90,50);

                String drawString = "Programación Visual";

                // Create font and brush.
                Font drawFont = new Font("Arial", 20);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                // Create point for upper-left corner of drawing.
                //float x = 0;
                //float y = 0;

                // Set format of string.
                StringFormat drawFormat = new StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.NoWrap;

                // Draw string to screen.
                gfx.DrawString(drawString, drawFont, drawBrush, new PointF(0, 0));
                
            }
            // Refrescar el picture box
            PictureBox.Refresh();
        }

        private void ImagenEscalaDeGrises_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = this.PictureBox;
            Image imagen = pictureBox.Image;
            using (Graphics gfx = Graphics.FromImage(imagen))
            {
                // Matriz para realizar una transformación al gris
                // manteniendo los valores de luminancia correctos
                ColorMatrix cm = new ColorMatrix(new float[][]{
                         new float[]{0.3f,0.3f,0.3f,0,0},
                         new float[]{0.59f,0.59f,0.59f,0,0},
                         new float[]{0.11f,0.11f,0.11f,0,0},
                         new float[]{0,0,0,1,0},
                         new float[]{0,0,0,0,1}});
                // Información acerca de la manipulación de los colores del
                // mapa de bits
                ImageAttributes atrImg = new ImageAttributes();
                atrImg.SetColorMatrix(cm);
                gfx.DrawImage(imagen,
                            new Rectangle(0, 0, imagen.Width, imagen.Height),
                            0, 0, imagen.Width, imagen.Height,
                            GraphicsUnit.Pixel, atrImg);
                // Dibujar la imagen:
                // DrawImage(Imagen, RectImgDestino,
                // XImgFuente, YImgFuente, anchoImgFuente, anchoImgFuente,
                // UnidadesGráficas, AtributosImagen)
            }
            // Refrescar pictureBox
            PictureBox.Refresh();
        }

        private void m_PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ArchivoGuardarComo_Click(object sender, EventArgs e)
        {
            // Mostrar el diálogo SaveFileDialog y configurarlo de forma
            // análoga al OpenFileDialog de la opción "Abrir".
            Guardar();
        }

        private void Guardar()
        {
            SaveFileDialog dlgGuardar = new SaveFileDialog();
            // Si el resultado del diálogo es distinto de OK, terminar.
            if (dlgGuardar.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(dlgGuardar.FileName);
                string título = fi.Name;
                //Properties.Resources file = new Properties.Resources();
                
                if (dlgGuardar.FileName.ToUpper().EndsWith(".JPG"))
                    PictureBox.Image.Save(dlgGuardar.FileName, ImageFormat.Jpeg);
                if (dlgGuardar.FileName.ToUpper().EndsWith(".BMP"))
                    PictureBox.Image.Save(dlgGuardar.FileName, ImageFormat.Bmp);
                if (dlgGuardar.FileName.ToUpper().EndsWith(".GIF"))
                    PictureBox.Image.Save(dlgGuardar.FileName, ImageFormat.Gif);
                if (dlgGuardar.FileName.ToUpper().EndsWith(".PNG"))
                    PictureBox.Image.Save(dlgGuardar.FileName, ImageFormat.Png);
                // Usar el método Save para guardar la imagen en formato jpg.
                //Análogamente con el resto de formatos permitidos.
                //this.Text = título;
                this.Text = dlgGuardar.FileName;

                // Actualizar el título de esta ventana.
            }
        }

        private void ArchivoGuardar_Click(object sender, EventArgs e)
        {
            if(this.Text.ToUpper().StartsWith("DOC"))
            {
                Guardar();
            }
            else
            {
                //System.IO.FileInfo info = new System.IO.FileInfo(this.Text);
                if (this.Text.ToUpper().EndsWith(".JPG"))
                    PictureBox.Image.Save(this.Text, ImageFormat.Jpeg);
                if (this.Text.ToUpper().EndsWith(".BMP"))
                    PictureBox.Image.Save(this.Text, ImageFormat.Bmp);
                if (this.Text.ToUpper().EndsWith(".GIF"))
                    PictureBox.Image.Save(this.Text, ImageFormat.Gif);
                if (this.Text.ToUpper().EndsWith(".PNG"))
                    PictureBox.Image.Save(this.Text, ImageFormat.Png);
            }

        }

        private void VentanaHija_Load(object sender, EventArgs e)
        {

        }
    }
}
