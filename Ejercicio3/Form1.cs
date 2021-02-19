using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void TareaSecundaria(BackgroundWorker hiloA, DoWorkEventArgs e)
        {
            int hecho = 0, tpHecho = 0;

            while (hecho < numCargaUCP.Value)
            {
                // Tarea secundaria
                hecho += 1;
                // Mostrar progreso
                tpHecho = (int)(hecho / numCargaUCP.Value * 100);
                if (tpHecho > bpProgreso.Value)
                {
                    //bpProgreso.Value = tpHecho;
                    System.Diagnostics.Debug.WriteLine(tpHecho);
                    hiloA.ReportProgress(tpHecho);
                }
            }
            //button1.Enabled = true;
            //numCargaUCP.Enabled = true;
            if(hiloA.CancellationPending)
            {
                e.Cancel = true;
                //break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            numCargaUCP.Enabled = false;
            bpProgreso.Value = 0;
            //TareaSecundaria();
            hiloTrabajador.RunWorkerAsync();
        }

        private void hiloTrabajador_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker hiloA = (BackgroundWorker)sender;
            TareaSecundaria(hiloA, e);
        }

        private void hiloTrabajador_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bpProgreso.Value = e.ProgressPercentage;
        }

        private void hiloTrabajador_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Operación cancelada");
            else
            {
                button1.Enabled = true;
                numCargaUCP.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hiloTrabajador.CancelAsync();
        }
    }
}
