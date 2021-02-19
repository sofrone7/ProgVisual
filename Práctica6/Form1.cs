using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Práctica6
{
    public partial class Principal : Form
    {
        private List<int> m_Valores = new List<int>();
        private int m_Índice;
        private Thread m_HiloA;
        private Thread m_HiloB;
        private ManualResetEvent m_PararHiloA = new ManualResetEvent(false);
        private ManualResetEvent m_ParadoHiloA = new ManualResetEvent(false);
        private ManualResetEvent m_PararHiloB = new ManualResetEvent(false);
        private ManualResetEvent m_ParadoHiloB = new ManualResetEvent(false);

        public Principal()
        {
            InitializeComponent();
            bp_Progreso.Maximum = (int)ct_Velocidad.Value;
        }

        public List<int> Valores
        {
            get { return m_Valores; }
            set { m_Valores = value; } 
        }
        public int Índice {
            get { return m_Índice; }
            set { m_Índice = value; }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bp_Progreso.Value = 0;
            bp_Progreso.Maximum = (int)ct_Velocidad.Value;
        }

        private void bt_Mostrar_Click(object sender, EventArgs e)
        {
            if (pb_Imagen.Visible)
            {
                pb_Imagen.Hide();
                bt_Mostrar.Text = "Mostrar imagen";
            }
            else
            {
                pb_Imagen.Visible = true;
                bt_Mostrar.Text = "Ocultar imagen";
            }
        }

        private void bp_Progreso_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //bp_Progreso.Maximum = (int)ct_Velocidad.Value;
        }

        private void rchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Progresar()
        {
            Valores.Add(Índice);
                //bp_Progreso.Value = Valores[Índice];
            ActualizarBarraProgreso();
                //Thread.Sleep(0);
            m_Índice += 1;
            
            if(bp_Progreso.Value == bp_Progreso.Maximum)
            {
                //bp_Progreso.Value = 0;
                //m_Valores.Clear();
                //bt_Iniciar.Enabled = true;
                ActualizarBotonIniciar();
                //ct_Velocidad.Enabled = true;
                ActualizarCtVelocidad();
            }
        }

        private void ActualizarCtVelocidad()
        {
            if (ct_Velocidad.InvokeRequired)
            {
                MethodInvoker delegado2 = new MethodInvoker(ActualizarCtVelocidad);
                ct_Velocidad.Invoke(delegado2);
            }
            else
                ct_Velocidad.Enabled = true;
        }

        private void ActualizarBotonIniciar()
        {
            if (bt_Iniciar.InvokeRequired)
            {
                MethodInvoker delegado1 = new MethodInvoker(ActualizarBotonIniciar);
                bt_Iniciar.Invoke(delegado1);
            }
            else
                bt_Iniciar.Enabled = true;
        }

        private void ActualizarBarraProgreso()
        {
            if (bp_Progreso.InvokeRequired)
            {
                MethodInvoker delegado = new MethodInvoker(ActualizarBarraProgreso);
                bp_Progreso.Invoke(delegado);
            }
            else
            {
                //Valores.Add(Índice);
                bp_Progreso.PerformStep();
                //m_Índice += 1;
            }
        }
        
        private void ActualizarA()
        {
            while (m_Índice <= bp_Progreso.Maximum)
            {
                if(m_PararHiloA.WaitOne(0, false)) //verificamos en cada iteración si se ha activado la señal "Parar"
                {
                    m_ParadoHiloA.Set();
                    return;
                }
                lock (Valores)
                {
                    Progresar();
                }
                /*Monitor.Enter(Valores);
                try 
                {
                    Progresar();
                    // Código en exclusión mutua
                }
                finally
                {
                    Monitor.Exit(Valores);
                }*/

            }
            for (int i = 0; i < m_Valores.Count; i++)
                if (i != m_Valores[i])
                {
                    MessageBox.Show("valores[" + i + "] = " + m_Valores[i] +
                    " y debía valer " + i);
                    break;
                }

        }

        private void ActualizarB()
        {
            while (m_Índice <= bp_Progreso.Maximum)
            {
                if (m_PararHiloB.WaitOne(0, false))
                {
                    m_ParadoHiloB.Set();
                    return;
                }
                lock (Valores)
                {
                    Progresar();
                }
                /*Monitor.Enter(Valores);
                try
                {
                    Progresar();
                    // Código en exclusión mutua
                }
                finally
                {
                    Monitor.Exit(Valores);
                }*/
            }
          
        }

        private void bt_Iniciar_Click(object sender, EventArgs e)
        {
            Índice = 0;
            m_Valores.Clear();
            bt_Iniciar.Enabled = false;
            ct_Velocidad.Enabled = false;
            bp_Progreso.Value = 0;
            //ActualizarA();
            
            m_HiloA = new Thread(new ThreadStart(ActualizarA));
            m_HiloA.Start();
            
            m_HiloB = new Thread(new ThreadStart(ActualizarB));
            m_HiloB.Start();
            
        }

        private void PararHiloA()
        {
            if (m_HiloA != null && m_HiloA.IsAlive)
            {
                // Activamos el evento para decirle al hilo que pare
                m_PararHiloA.Set();
                // Esperar a que el hilo haya terminado
                while (m_HiloA.IsAlive)
                {
                    m_ParadoHiloA.WaitOne(200, false); // evitar una espera activa
                    Application.DoEvents(); // procesar eventos pendientes
                }
                MessageBox.Show("HiloA detenido");
            }

        }

        private void PararHiloB()
        {
            if (m_HiloB != null && m_HiloB.IsAlive)
            {
                // Activamos el evento para decirle al hilo que pare
                m_PararHiloB.Set();
                // Esperar a que el hilo haya terminado
                while (m_HiloB.IsAlive)
                {
                    m_ParadoHiloB.WaitOne(200, false); // evitar una espera activa
                    Application.DoEvents(); // procesar eventos pendientes
                }
                
                MessageBox.Show("HiloB detenidio");
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            PararHiloA();
            PararHiloB();
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PararHiloA();
            PararHiloB();
            //bp_Progreso.Value = 0;
            //ActualizarBotonIniciar();
            //ActualizarCtVelocidad();
            bt_Iniciar.Enabled = true;
            ct_Velocidad.Enabled = true;
            m_PararHiloA.Reset();
            m_PararHiloB.Reset();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 dlg = new AboutBox1();
            dlg.ShowDialog();
        }
    }
}
