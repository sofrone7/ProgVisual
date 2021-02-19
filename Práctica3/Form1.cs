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
        private bool m_DespertadorActivado = false;
        private const int MaxZonas = 4;
        public RelojDigital()
        {
            InitializeComponent();
            timer1.Start(); //sup
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

            if (DespertadorActivado)
            {
                if (!ct_Alarma.HoraValida)
                {
                    System.Diagnostics.Debug.WriteLine("Hora alarma nó válida");
                    return;
                }
                DateTime horaActual = DateTime.Now + m_DesfaseHorario;
                DateTime horaAlarma = ct_Alarma.Hora;
                int segundosActual = horaActual.Second
                + horaActual.Minute * 60
                + horaActual.Hour * 3600;
                // Segundos alarma:
                //...
                int segundosAlarma = horaAlarma.Second
                    + horaAlarma.Minute * 60
                    + horaAlarma.Hour * 3600;

                if (segundosActual >= segundosAlarma)
                {
                    if (segundosActual - segundosAlarma < 300) //suena durante 300 segundos(5 min) a partir de la hora establecida
                        Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                }
                else if (segundosAlarma - segundosActual > 86400 - 300)
                    Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
            }
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
            ct_HoraActual.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            if (fuente.ShowDialog() == DialogResult.OK)
                ct_HoraActual.Font = fuente.Font;
            ColorDialog color_fuente = new ColorDialog();
            if (color_fuente.ShowDialog() == DialogResult.OK)
                ct_HoraActual.ForeColor = color_fuente.Color;
        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ct_HoraActual.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            ColorDialog color_fondo = new ColorDialog();
            if (color_fondo.ShowDialog() == DialogResult.OK)
                ct_HoraActual.BackColor = color_fondo.Color;
        }

        private void bt_ZonaHoraria_Click(object sender, EventArgs e)
        {
            DlgDatosZona dlg = new DlgDatosZona();
            //dlg.ShowDialog();

            //if(dlg.AcceptButton.DialogResult == DialogResult.OK)
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string nombre = dlg.Nombre;
                string desfase = dlg.Diferencia.ToString();
                string signo = dlg.Positivo ? "Positivo" : "Negativo";

                // Visualizar una caja de diálogo que muestre los datos
                // de la zona recogidos en el diálogo

                MessageBox.Show(String.Format("{0}, {1}, {2}:", nombre, desfase, signo));
            }
        }

        public bool DespertadorActivado 
        {   
            get { return m_DespertadorActivado; }
            set { m_DespertadorActivado = value;
                //DespertadorActivar.Text =
                //m_DespertadorActivado ? "Desacti&var" : "Acti&var";
                //DespertadorActivar.Checked = m_DespertadorActivado;
                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = m_DespertadorActivado;
            }
        }

        private void DespertadorActivar_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = !this.DespertadorActivado;
        }

        private void OpcionesDespertadorDesactivar_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = !this.DespertadorActivado;
        }

        public int NúmeroZonas //permite conocer el número de zonas que el usuario ha añadido
        { 
            get { return menúZona.DropDownItems.Count - 3; }
        }

        private void menúZona_DropDownOpened(object sender, EventArgs e)
        {
            if (NúmeroZonas == MaxZonas)
                this.zonaAñadir.Visible = false;
            else
                this.zonaAñadir.Visible = true;
            if (NúmeroZonas == 0)
                this.zonaEliminar.Visible = false;
            else
                this.zonaEliminar.Visible = true;
        }

        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            if (this.NúmeroZonas == MaxZonas)
            {
                Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                return;
            }

            ToolStripMenuItem zonaNueva = new ToolStripMenuItem();
            zonaNueva.Text = "Zona " + (this.NúmeroZonas + 1);
            // Especifique el manejador del evento Click de zonaNueva; la
            // respuesta a este evento vendrá dada por el método zona_Click.
            // Añada el elemento zonaNueva al menú menúZona.
            menúZona.DropDownItems.Add(zonaNueva);
            zonaNueva.Click += new EventHandler(zona_Click);
        }

        private void zona_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ToolStripMenuItem zonaNueva = (ToolStripMenuItem)sender;
            MessageBox.Show(zonaNueva.Text);
        }

        private void menúZona_Click(object sender, EventArgs e)
        {

        }

        private void zonaEliminar_Click(object sender, EventArgs e)
        {
            if (this.NúmeroZonas == 0)
            {
                Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                return;
            }
            int últimaZona = menúZona.DropDownItems.Count - 1;
            menúZona.DropDownItems.RemoveAt(últimaZona);
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = !this.DespertadorActivado;
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = !this.DespertadorActivado;
        }
    }
}
