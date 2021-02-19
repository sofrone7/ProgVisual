using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica1
{
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        RelojAnalógico m_RelojAnalógico = new RelojAnalógico();
        public RelojDigital()
        {
            InitializeComponent();
            timer1.Start();
            MostrarHoraActual();
            m_RelojAnalógico.Show(this);
        }

        private void MostrarHoraActual()
        {
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            ct_HoraActual.Text = hora.ToLongTimeString();
            m_RelojAnalógico.Hora = hora;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe dlg = new AcercaDe();
            dlg.ShowDialog();
        }

        

        private void RelojDigital_Shown(object sender, EventArgs e)
        {
            m_RelojAnalógico.Location = new Point(this.Location.X + 785 + 10, 172);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            MostrarHoraActual();
        }

        private void bt_Mostrar_Click(object sender, EventArgs e)
        {
            
            if (m_RelojAnalógico.Visible)
            {
                bt_Mostrar.Text = Properties.Resources.MostrarAnalogico;
                m_RelojAnalógico.Hide();
            }
            else
            {
                bt_Mostrar.Text = Properties.Resources.OcultarAnalogico;
                m_RelojAnalógico.Show();
            }
        }

        internal void CambiarHora(int horas, int minutos, int segundos)
        {
            DateTime actual = DateTime.Now;
            DateTime hora = new DateTime(actual.Year, actual.Month, actual.Day, horas, minutos, segundos);
            m_DesfaseHorario = hora - actual;
            MostrarHoraActual();
        }

        
    }
}
