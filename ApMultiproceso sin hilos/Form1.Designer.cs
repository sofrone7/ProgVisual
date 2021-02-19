namespace ApMultiproceso
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.numCargaUCP = new System.Windows.Forms.NumericUpDown();
      this.etCargaUCP = new System.Windows.Forms.Label();
      this.btCalcular = new System.Windows.Forms.Button();
      this.bpProgreso = new System.Windows.Forms.ProgressBar();
      this.etHora = new System.Windows.Forms.Label();
      this.Temporizador = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.numCargaUCP)).BeginInit();
      this.SuspendLayout();
      // 
      // numCargaUCP
      // 
      this.numCargaUCP.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numCargaUCP.Location = new System.Drawing.Point(218, 236);
      this.numCargaUCP.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
      this.numCargaUCP.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numCargaUCP.Name = "numCargaUCP";
      this.numCargaUCP.Size = new System.Drawing.Size(65, 20);
      this.numCargaUCP.TabIndex = 14;
      this.numCargaUCP.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      // 
      // etCargaUCP
      // 
      this.etCargaUCP.AutoSize = true;
      this.etCargaUCP.Location = new System.Drawing.Point(149, 238);
      this.etCargaUCP.Name = "etCargaUCP";
      this.etCargaUCP.Size = new System.Drawing.Size(63, 13);
      this.etCargaUCP.TabIndex = 13;
      this.etCargaUCP.Text = "Carga UCP:";
      // 
      // btCalcular
      // 
      this.btCalcular.Location = new System.Drawing.Point(95, 141);
      this.btCalcular.Name = "btCalcular";
      this.btCalcular.Size = new System.Drawing.Size(109, 23);
      this.btCalcular.TabIndex = 12;
      this.btCalcular.Text = "Calcular";
      this.btCalcular.UseVisualStyleBackColor = true;
      this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
      // 
      // bpProgreso
      // 
      this.bpProgreso.Location = new System.Drawing.Point(15, 96);
      this.bpProgreso.Name = "bpProgreso";
      this.bpProgreso.Size = new System.Drawing.Size(268, 23);
      this.bpProgreso.Step = 1;
      this.bpProgreso.TabIndex = 11;
      // 
      // etHora
      // 
      this.etHora.AutoSize = true;
      this.etHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.etHora.Location = new System.Drawing.Point(10, 11);
      this.etHora.Name = "etHora";
      this.etHora.Size = new System.Drawing.Size(119, 29);
      this.etHora.TabIndex = 10;
      this.etHora.Text = "00:00:00";
      // 
      // Temporizador
      // 
      this.Temporizador.Enabled = true;
      this.Temporizador.Interval = 1000;
      this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.numCargaUCP);
      this.Controls.Add(this.etCargaUCP);
      this.Controls.Add(this.btCalcular);
      this.Controls.Add(this.bpProgreso);
      this.Controls.Add(this.etHora);
      this.Name = "Form1";
      this.Text = "Multiproceso";
      ((System.ComponentModel.ISupportInitialize)(this.numCargaUCP)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numCargaUCP;
    private System.Windows.Forms.Label etCargaUCP;
    private System.Windows.Forms.Button btCalcular;
    private System.Windows.Forms.ProgressBar bpProgreso;
    private System.Windows.Forms.Label etHora;
    private System.Windows.Forms.Timer Temporizador;
  }
}

