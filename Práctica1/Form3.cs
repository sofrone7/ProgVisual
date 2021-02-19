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

namespace Práctica1
{
    
    public partial class RelojAnalógico : Form
    {
        private Point m_Centro = new Point();
        int m_Radio;


        DateTime m_Hora = DateTime.Now;
        public RelojAnalógico()
        {
            ActualizarDimensiones();
            InitializeComponent();
            
        }

       
        private void ActualizarDimensiones()
        {
            m_Centro.X = this.ClientSize.Width / 2;
            m_Centro.Y = this.ClientSize.Height / 2;
            m_Radio = Math.Min(m_Centro.X, m_Centro.Y);
        }

        private void RelojAnalógico_Load(object sender, EventArgs e)
        {

        }

        private void RelojAnalógico_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (this.Focused)
            {
                e.Cancel = true;
            }
        }

        public DateTime Hora
        {
            set
            {
                m_Hora = value;
                Invalidate();
            }
        }

        private void RelojAnalógico_Resize(object sender, EventArgs e)
        {
            ActualizarDimensiones();
            Invalidate();
        }

        private void RelojAnalógico_Paint(object sender, PaintEventArgs e)
        {
            if (m_Radio <= 10)
                return;

            Graphics gfx = e.Graphics;

            Pen lápizNormal = new Pen(Color.Black, 1);
            HatchBrush brochaGris = new HatchBrush(HatchStyle.Sphere, Color.Gray, Color.Gray);
            Pen lápizMuyGordoAzul = new Pen(Color.Blue, 4);
            double alfa, x, y;
            //Manecilla de las horas
            alfa = (m_Hora.Hour % 12) * Math.PI * 2 / 12;
            alfa += (m_Hora.Minute) * Math.PI * 2 / 12 / 60;

            x = Math.Sin(alfa) * m_Radio;
            y = -Math.Cos(alfa) * m_Radio;

            gfx.DrawLine(lápizMuyGordoAzul, m_Centro.X, m_Centro.Y, m_Centro.X + (int)(x * .5), m_Centro.Y + (int)(y * .5));

            // Manecilla de los minutos
            // Escriba su código aquí
            Pen lápizGordoNegro = new Pen(Color.Black, 3);
            double beta, m, n;

            beta = (m_Hora.Minute) * Math.PI * 2 / 60;
            beta += (m_Hora.Second) * Math.PI * 2 / 60 / 60;

            m = Math.Sin(beta) * m_Radio;
            n = -Math.Cos(beta) * m_Radio;

            gfx.DrawLine(lápizGordoNegro, m_Centro.X, m_Centro.Y, m_Centro.X + (int)(m * .7), m_Centro.Y + (int)(n * .7));
            // Manecilla de los segundos
            // Escriba su código aquí
            Pen lápizFinoRojo = new Pen(Color.Red, 2);
            double ganma, a, b;

            ganma = (m_Hora.Second) * Math.PI * 2 / 60;


            a = Math.Sin(ganma) * m_Radio;
            b = -Math.Cos(ganma) * m_Radio;

            gfx.DrawLine(lápizFinoRojo, m_Centro.X, m_Centro.Y, m_Centro.X + (int)(a * .8), m_Centro.Y + (int)(b * .8));

            float alfa1, x1, y1;
            // Llevamos el origen de coordenadas al centro de la ventana
            // y hacemos que el eje "y" aumente hacia arriba
            Matrix matriz = new Matrix(1, 0, 0, -1, m_Centro.X, m_Centro.Y);
            gfx.Transform = matriz;
            //Esfera
            float radioEsfera = m_Radio * .95f;
            gfx.DrawEllipse(lápizNormal, -radioEsfera, -radioEsfera, radioEsfera * 2, radioEsfera * 2);
            // Marcas de los minutos
            for (int i = 0; i < 60; i++)
            {
                alfa1 = (float)(i * Math.PI * 2 / 60);
                x1 = (float)(Math.Sin(alfa1) * m_Radio);
                y1 = (float)(Math.Cos(alfa1) * m_Radio);
                if (i % 5 == 0)
                    gfx.DrawLine(lápizGordoNegro, x1 * .85f, y1 * .85f, x1 * .95f, y1 * .95f);
                else
                    gfx.DrawLine(lápizNormal, x1 * .9f, y1 * .9f, x1 * .95f, y1 * .95f);
            }

            // Botón Central
            float radioBotón = m_Radio * .1f / 2;
            gfx.DrawEllipse(lápizGordoNegro, -radioBotón, -radioBotón, radioBotón * 2, radioBotón * 2);
            gfx.FillEllipse(brochaGris, -radioBotón, -radioBotón, radioBotón * 2, radioBotón * 2);

        }

        private void RelojAnalógico_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarAgujas(sender, e);
        }

        private void RelojAnalógico_MouseMove(object sender, MouseEventArgs e)
        {
            ArrastrarAgujas(sender, e);
        }

        private void ArrastrarAgujas(object sender, MouseEventArgs e)
        {
            bool botonDerIzq = e.Button == MouseButtons.Right || e.Button == MouseButtons.Left;

            bool pulsadoCentro = (e.X == m_Centro.X && e.Y == m_Centro.Y);
            if (m_Radio < 10 || !botonDerIzq || pulsadoCentro)
                return;
            double alfa;
            int horas, minutos;
            alfa = Math.Atan2(m_Centro.X - e.X, e.Y - m_Centro.Y);
            minutos = (int)((alfa / Math.PI / 2 * 12 + 6) * 60);
            horas = (minutos / 60) % 12;
            minutos %= 60;
            if (e.Button == MouseButtons.Right)
                horas += 12;
            //Console.WriteLine(horas + ":" + minutos + ":" + m_Hora.Second);
            RelojDigital relojD = (RelojDigital)this.Owner;
            relojD.CambiarHora(horas, minutos, m_Hora.Second);
        }

        

        

    }
}
