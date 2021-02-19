using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace ApMultiproceso
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Temporizador_Tick(object sender, EventArgs e)
    {
      etHora.Text = DateTime.Now.ToLongTimeString();
    }

    private void TareaSecundaria(BackgroundWorker hiloTr, DoWorkEventArgs e)
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
          System.Diagnostics.Debug.WriteLine(tpHecho); // válida sólo en configuración Debug
          // La llamada a ReportProgress genera el evento ProgressChanged
          hiloTr.ReportProgress(tpHecho);
        }
        // ¿Se ha cancelado la operación?
        if (hiloTr.CancellationPending)
        {
          e.Cancel = true;
          break;
        }
      }
    }

    private void btCalcular_Click(object sender, EventArgs e)
    {
      // Inhabilitar controles. Se habilitarán de nuevo cuando se
      // genere el evento RunWorkerCompleted
      btCalcular.Enabled = false;
      numCargaUCP.Enabled = false;
      bpProgreso.Value = 0;
      // Iniciar el hilo secundario encapsulado por
      // el objeto BackgroundWorker
      hiloTrabajador.RunWorkerAsync();
    }

    private void hiloTrabajador_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker hiloTr = (BackgroundWorker)sender;
      TareaSecundaria(hiloTr, e);
    }

    private void hiloTrabajador_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      // Mostrar progreso
      bpProgreso.Value = e.ProgressPercentage;
    }

    private void hiloTrabajador_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      // Primero se verifica si lanzó una excepción
      if (e.Error != null)
        // Ocurrió un error
        MessageBox.Show(e.Error.Message);
      else if (e.Cancelled)
        // Operación cancelada
        MessageBox.Show("Operación cancelada");
      else
      {
        // La operación finalizó correctamente
        btCalcular.Enabled = true;
        numCargaUCP.Enabled = true;
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      // Cancelar la operación asíncrona
      hiloTrabajador.CancelAsync();

      // Otras operaciones
    }
  }
}
