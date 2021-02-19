using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    
    public partial class FormPrincipal : Form
    {
        //private bool button1WasClicked = false;
        public FormPrincipal()
        {
            InitializeComponent();
            
        }




        private void Contraseña_Load(object sender, EventArgs e)
        {
            if (!contraseña()) 
                Close();
        }

        private bool contraseña()
        {
            int count = 0;
            string password;
            DlgContraseña dlg = new DlgContraseña();

            do
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    password = dlg.ct_Contraseña.Text;
                else
                    return false; //sino no me deja acceder a password
                
                
                if (password.Length != 0 && password.CompareTo("1234") != 0)
                {
                    MessageBox.Show("La contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    count += 1;
                }
                else
                    count = 4; //Tiene que ser 4 para que cuando introduzcamos la contraseña correcta al tercer intento podamos ver el formulario->podamos complir el siguiente if
            }
            while (count < 3);
            if (password.Length == 0 || count == 3)
                return false;
            MessageBox.Show("La contraseña es correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
            
        }


        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            //if (!contraseña()) Close();
        }
    }
}
