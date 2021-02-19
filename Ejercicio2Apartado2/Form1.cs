using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Apartado2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
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
    }
}
