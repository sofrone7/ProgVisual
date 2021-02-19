using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    private void TareaSecundaria()
    {
      int hecho = 0, tpHecho = 0;

      while (hecho < numCargaUCP.Value)
      {
        // Tarea secundaria
        hecho += 1;
        // Mostrar progreso
        tpHecho = (int)(hecho / numCargaUCP.Value * 100);
        if (tpHecho > bpProgreso.Value)
          bpProgreso.Value = tpHecho;
      }
      btCalcular.Enabled = true;
      numCargaUCP.Enabled = true;
    }

    private void btCalcular_Click(object sender, EventArgs e)
    {
      btCalcular.Enabled = false;
      numCargaUCP.Enabled = false;
      bpProgreso.Value = 0;
      TareaSecundaria();
    }
  }
}
