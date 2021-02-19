using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica1
{
    public partial class DlgEliminarZona : Form
    {
        private List<ZonaHoraria> m_Zonas = new List<ZonaHoraria>();
        private int m_ZonaSeleccionada = -1;

        public DlgEliminarZona()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            
        }
        public List<ZonaHoraria> Zonas
        { get { return m_Zonas; }
            set { m_Zonas = value; } 
        }

        private void DlgEliminarZona_Load(object sender, EventArgs e)
        {
            this.Owner = RelojDigital.ActiveForm;
            Zonas = ((RelojDigital)this.Owner).Zonas;

            //List<ZonaHoraria> m_Zonas = ((RelojDigital)this.Owner).Zonas;
            if (m_Zonas.Count != 0)
            {
                foreach (ZonaHoraria nombre in m_Zonas)
                    lb_Zonas.Items.Add(nombre.Nombre);
                lb_Zonas.SelectedIndex = 0;
                
            }
        }

        private void lb_Zonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string nombreZona = this.lb_Zonas.SelectedItem.ToString(); // zona seleccionada
            string nombreZona = this.lb_Zonas.Text;
            ZonaHoraria zonaSeleccionada =
            m_Zonas.Find(
            delegate (ZonaHoraria zona) // predicado anónimo
                {
                    return zona.Nombre == nombreZona;
                }
            );
            this.ct_Diferencia.Text = zonaSeleccionada.Diferencia.ToString();
            this.ct_Signo.Text = zonaSeleccionada.Positivo ? "Positivo" : "Negativo";
        }
        public int ZonaSeleccionada
        {
            get { return m_ZonaSeleccionada; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_ZonaSeleccionada = lb_Zonas.SelectedIndex;
        }
    }
}
