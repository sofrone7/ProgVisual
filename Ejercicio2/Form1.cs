using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private Point m_Centro = new Point();
        int m_Radio;
        public Form1()
        {
            InitializeComponent();
            ActualizarDimensiones();
        }

        private void ActualizarDimensiones()
        {
            m_Centro.X = this.ClientSize.Width / 2;
            m_Centro.Y = this.ClientSize.Height / 2;
            m_Radio = Math.Min(m_Centro.X, m_Centro.Y);
        }

        private void bt_Dibujar_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen lápizNegro = new Pen(Color.Black, 3);
            Rectangle rect = new Rectangle(100, 100, 100, 100);
            g.DrawRectangle(lápizNegro, rect);

            Pen lápizAzul = new Pen(Color.Blue, 3);
            Point[] points2 = { new Point(100, 100), new Point(200, 100), new Point(150, 10) };
            g.DrawPolygon(lápizAzul, points2);

            Pen lápizAmarillo = new Pen(Color.Yellow, 3);
            g.DrawEllipse(lápizAmarillo, 250, 5, 100, 100);
            g.FillEllipse(new SolidBrush(Color.Yellow), 250, 5, 100, 100);
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ActualizarDimensiones();
            Invalidate();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
