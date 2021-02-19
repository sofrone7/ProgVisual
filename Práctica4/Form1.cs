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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Práctica1
{
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        RelojAnalógico m_RelojAnalógico = new RelojAnalógico();
        private bool m_DespertadorActivado = false;
        
        private List<ZonaHoraria> m_Zonas = new List<ZonaHoraria>();
        public RelojDigital()
        {
            InitializeComponent();
            timer1.Start(); //supp
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

        /*private void bt_ZonaHoraria_Click(object sender, EventArgs e)
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
        }*/

        public bool DespertadorActivado 
        {   
            get { return m_DespertadorActivado; }
            set { m_DespertadorActivado = value;
                //DespertadorActivar.Text =
                //m_DespertadorActivado ? "Desacti&var" : "Acti&var";
                //DespertadorActivar.Checked = m_DespertadorActivado;
                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = m_DespertadorActivado;
                cv_Despertador.Checked = m_DespertadorActivado;
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
            get { return m_Zonas.Count; }
        }

        private void menúZona_DropDownOpened(object sender, EventArgs e)
        {
            if(NúmeroZonas == 0)
                this.zonaEliminar.Visible = false;
            else
                this.zonaEliminar.Visible = true;
        }

        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            DlgDatosZona dlg = new DlgDatosZona();
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bool existe = m_Zonas.Exists(
                                 delegate (ZonaHoraria zona) // predicado anónimo
                                 {
                                     return zona.Nombre == dlg.Nombre;
                                 }
                );
                if (existe)
                {
                    MessageBox.Show("Ya existe una zona llamada "
                    + dlg.Nombre);
                    return; // salimos sin modificar nada
                }

                AñadirOrdenZona(dlg);

                /*string nombre = unaZona.Nombre;
                string desfase = unaZona.Diferencia.ToString();
                string signo = unaZona.Positivo ? "Positivo" : "Negativo";
                MessageBox.Show(String.Format("{0}, {1}, {2}:", nombre, desfase, signo));*/
            }
            //dlg.Click += new EventHandler(zona_Click);
        }

        private void AñadirOrdenZona(DlgDatosZona dlg)
        {
            ZonaHoraria unaZona = new ZonaHoraria();
            unaZona.Nombre = dlg.Nombre;
            unaZona.Diferencia = dlg.Diferencia;
            unaZona.Positivo = dlg.Positivo;
            Zonas.Add(unaZona);

            ToolStripMenuItem zonaNueva = new ToolStripMenuItem();
            zonaNueva.Text = unaZona.Nombre;
            menúZona.DropDownItems.Add(zonaNueva);
            zonaNueva.Click += new EventHandler(zona_Click);
        }

        private void zona_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ToolStripMenuItem zonaNueva = (ToolStripMenuItem)sender;
            string nombreZona = sender.ToString();
            ZonaHoraria zonaSeleccionada =
            m_Zonas.Find(
            delegate (ZonaHoraria zona) // predicado anónimo
            {
                return zona.Nombre == nombreZona;
            }
            );
            TimeSpan desfase = zonaSeleccionada.Diferencia;
            /*int horas = desfase.Hours;
            int minutos = desfase.Minutes;
            int segundos = desfase.Seconds;
            DateTime actual = DateTime.Now;
            DateTime horaDesfasadax = new DateTime(actual.Year, actual.Month, actual.Day, horas, minutos, segundos);*/
            TimeSpan horaDesfasada;
            
            string signo = zonaSeleccionada.Positivo ? "Positivo" : "Negativo";
            if(signo.CompareTo("Positivo") == 0)
                horaDesfasada = DateTime.Now.TimeOfDay + desfase;
            else
                horaDesfasada = DateTime.Now.TimeOfDay - desfase;

            string HoraDesfasada = horaDesfasada.ToString();
            MessageBox.Show(String.Format("{0}, {1}:", zonaNueva.Text, HoraDesfasada));
            
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
            //int últimaZona = menúZona.DropDownItems.Count - 1;
            //menúZona.DropDownItems.RemoveAt(últimaZona);

            DlgEliminarZona dlg = new DlgEliminarZona();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                m_Zonas.RemoveAt(dlg.ZonaSeleccionada);
                menúZona.DropDownItems.RemoveAt(dlg.ZonaSeleccionada +3);
            }
           
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = !this.DespertadorActivado;
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = !this.DespertadorActivado;
        }

        private void cv_Despertador_Click(object sender, EventArgs e)
        {
            DespertadorActivado = !DespertadorActivado;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < NúmeroZonas; i++)
            {
                string nombre = m_Zonas[i].Nombre;
                string desfase = m_Zonas[i].Diferencia.ToString();
                string signo = m_Zonas[i].Positivo ? "Positivo" : "Negativo";
                MessageBox.Show(String.Format("{0}, {1}, {2}:", nombre, desfase, signo));
            }*/
            DlgEliminarZona dlg = new DlgEliminarZona();
            dlg.ShowDialog();
        }
        public List<ZonaHoraria> Zonas
        {
            get { return m_Zonas; }
            set { m_Zonas = value; }
        }

        private void RelojDigital_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (Stream stream =
                File.Open("reloj.dat", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, m_Zonas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo crear el archivo de zonas. "
                + " Causa: " + ex.Message);
            }
        }

        private void RelojDigital_Load(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.OpenRead("reloj.dat"))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    m_Zonas = (List<ZonaHoraria>)bin.Deserialize(stream); // Deseriamos
                    foreach (ZonaHoraria nuevaZona in m_Zonas)
                    {
                        ZonaHoraria unaZona = new ZonaHoraria();
                        unaZona.Nombre = nuevaZona.Nombre;
                        unaZona.Diferencia = nuevaZona.Diferencia;
                        unaZona.Positivo = nuevaZona.Positivo;
                        //Zonas.Add(unaZona);

                        ToolStripMenuItem zonaNueva = new ToolStripMenuItem();
                        zonaNueva.Text = unaZona.Nombre;
                        menúZona.DropDownItems.Add(zonaNueva);
                        zonaNueva.Click += new EventHandler(zona_Click);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo abrir el archivo de zonas. "
                    + " Causa: " + ex.Message);

                // Mensaje de error a la consola
            }

            /* string[] lines = File.ReadAllLines("Zonas.txt");
             //string[] fields;
             //ZonaHoraria unaZona = new ZonaHoraria();
             string[] fields;

             for (int i = 0; i < lines.Length; i++)
             {
                 fields = lines[i].Split(' ');
                 if (Zonas.Count == i)
                 {
                     ZonaHoraria unaZona = new ZonaHoraria();
                     unaZona.Nombre = fields[0];
                     unaZona.Diferencia = TimeSpan.Parse(fields[1]);
                     if (fields[2].CompareTo("Positivo") == 0)
                         unaZona.Positivo = true;
                     else
                         unaZona.Positivo = false;
                     Zonas.Add(unaZona);
                 }
             }*/


        }
    }
}
