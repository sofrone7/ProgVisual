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
            InitializeComponent(); //Bih
            timer1.Start();
            ct_HoraActual.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            ct_HoraActual.BackColor = Color.White;
            ct_HoraActual.ForeColor = Color.Blue;
            

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

        }

        internal void CambiarHora(int horas, int minutos, int segundos)
        {
            DateTime actual = DateTime.Now;
            DateTime hora = new DateTime(actual.Year, actual.Month, actual.Day, horas, minutos, segundos);
            m_DesfaseHorario = hora - actual;
            MostrarHoraActual();
        }

        private void mostrarAnalógicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_RelojAnalógico.Visible)
                m_RelojAnalógico.Hide();
            else
                m_RelojAnalógico.Show();
        }

        private void opcionesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (m_RelojAnalógico.Visible)
                mostrarAnalógicoToolStripMenuItem.Checked = true;
            else
                mostrarAnalógicoToolStripMenuItem.Checked = false;
        }

        private void ajustesDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();
            //ct_HoraActual.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            if (fuente.ShowDialog() == DialogResult.OK)
                ct_HoraActual.Font = fuente.Font;
            ColorDialog color_fuente = new ColorDialog();
            if (color_fuente.ShowDialog() == DialogResult.OK)
                ct_HoraActual.ForeColor = color_fuente.Color;
        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color_fondo = new ColorDialog();
            if (color_fondo.ShowDialog() == DialogResult.OK)
                ct_HoraActual.BackColor = color_fondo.Color;
        }
    }
}
