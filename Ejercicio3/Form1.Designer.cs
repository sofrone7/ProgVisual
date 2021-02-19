namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bpProgreso = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numCargaUCP = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hiloTrabajador = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numCargaUCP)).BeginInit();
            this.SuspendLayout();
            // 
            // bpProgreso
            // 
            this.bpProgreso.Location = new System.Drawing.Point(55, 82);
            this.bpProgreso.Name = "bpProgreso";
            this.bpProgreso.Size = new System.Drawing.Size(335, 23);
            this.bpProgreso.Step = 1;
            this.bpProgreso.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // numCargaUCP
            // 
            this.numCargaUCP.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCargaUCP.Location = new System.Drawing.Point(270, 206);
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
            this.numCargaUCP.Size = new System.Drawing.Size(120, 22);
            this.numCargaUCP.TabIndex = 3;
            this.numCargaUCP.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hiloTrabajador
            // 
            this.hiloTrabajador.WorkerReportsProgress = true;
            this.hiloTrabajador.WorkerSupportsCancellation = true;
            this.hiloTrabajador.DoWork += new System.ComponentModel.DoWorkEventHandler(this.hiloTrabajador_DoWork);
            this.hiloTrabajador.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.hiloTrabajador_ProgressChanged);
            this.hiloTrabajador.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.hiloTrabajador_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 265);
            this.Controls.Add(this.numCargaUCP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bpProgreso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numCargaUCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar bpProgreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCargaUCP;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker hiloTrabajador;
    }
}

