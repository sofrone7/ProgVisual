using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDFamosos;

namespace ApWinForms
{
    public partial class Form1 : Form
    {
        ColCFamosos colFamosos;
        CFamosoBLL bd;

        public Form1()
        {
            InitializeComponent();
            bd = new CFamosoBLL();
            colFamosos = bd.ObtenerFilasFamosos();
            // Agregar al panel un control ElementoLista por cada objeto CFamosoBO
            foreach (CFamosoBO obj in colFamosos)
            {
                ElementoLista elemento = new ElementoLista();
                elemento.ObjetoVinculado = obj;

                //elemento.txtNombre.Text = elemento.ObjetoVinculado.Nombre;

                //elemento.txtApellidos.Text = elemento.ObjetoVinculado.Apellidos;

                //elemento.txtFechaNaci.Text = elemento.ObjetoVinculado.Cumple.ToString();

                //elemento.etNomApEdad.Text = elemento.ObjetoVinculado.NombreAprellidosEdad;

                flowLayoutPanel1.Controls.Add(elemento);
            }
        }

      

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //for (int i = 0; i < colFamosos.Count; i++)
            //{
            // Actualizar la base de datos con los cambios realizados
            foreach (CFamosoBO obj in colFamosos)
                bd.ActualizarFamosos(obj);
            //}
        }
    }
}
