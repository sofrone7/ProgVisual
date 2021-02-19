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
    public partial class DlgDatosZona : Form
    {
        private string m_Nombre;
        private TimeSpan m_Diferencia; //Diferencia horaria en segundos
        private bool m_Positivo;
        public DlgDatosZona()
        {
            InitializeComponent();
        }

        public string Nombre 
        {
            get { return m_Nombre; }
            set
            {
                //m_Nombre = ct_Nombre.Text;
                m_Nombre = value;
            }
        }

        public TimeSpan Diferencia 
        {  
            get { return m_Diferencia; }
            set
            {
                //DateTime horaDiferencia = ct_Diferencia.Hora;
                //m_Diferencia = horaDiferencia.Second + horaDiferencia.Minute * 60 + horaDiferencia.Hour * 3600;
                //DateTime hora = ct_Diferencia.Hora;
                //this.Diferencia = new TimeSpan(hora.Hour, hora.Minute,
                //hora.Second);
                m_Diferencia = value;
            }
        }

        public bool Positivo 
        { 
            get { return m_Positivo; }
            set
            {
                m_Positivo = value;
                /*if (rb_Positivo.Checked)
                    m_Positivo = true;
                else
                    m_Positivo = false;*/
            }
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (ct_Nombre.Text != "")
                this.Nombre = ct_Nombre.Text;
            else
            {
                MessageBox.Show("Introduzca un nombre",
                    "Error en los datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ct_Nombre.Focus();
                ct_Nombre.SelectAll();
                return;
            }
            if (ct_Diferencia.HoraValida)
            {
                DateTime hora = ct_Diferencia.Hora;
                this.Diferencia = new TimeSpan(hora.Hour, hora.Minute,
                hora.Second);
            }
            else
            {
                MessageBox.Show("Introduzca una diferencia horaria válida",
                "Error en los datos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ct_Diferencia.Focus();
                ct_Diferencia.SelectAll();
                return;
            }
            this.Positivo = rb_Positivo.Checked;
            // Como los datos son válidos el resultado devuelto por el
            // diálogo debe ser OK
            this.DialogResult = DialogResult.OK;
        }
    }
}
