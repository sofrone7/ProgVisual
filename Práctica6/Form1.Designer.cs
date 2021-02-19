namespace Práctica6
{
    partial class Principal
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
            this.bp_Progreso = new System.Windows.Forms.ProgressBar();
            this.bt_Mostrar = new System.Windows.Forms.Button();
            this.bt_Iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_Velocidad = new System.Windows.Forms.NumericUpDown();
            this.pb_Imagen = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Velocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bp_Progreso
            // 
            this.bp_Progreso.Location = new System.Drawing.Point(114, 260);
            this.bp_Progreso.Name = "bp_Progreso";
            this.bp_Progreso.Size = new System.Drawing.Size(237, 23);
            this.bp_Progreso.Step = 1;
            this.bp_Progreso.TabIndex = 0;
            this.bp_Progreso.Click += new System.EventHandler(this.bp_Progreso_Click);
            // 
            // bt_Mostrar
            // 
            this.bt_Mostrar.Location = new System.Drawing.Point(114, 323);
            this.bt_Mostrar.Name = "bt_Mostrar";
            this.bt_Mostrar.Size = new System.Drawing.Size(130, 36);
            this.bt_Mostrar.TabIndex = 1;
            this.bt_Mostrar.Text = "Ocultar Imagen";
            this.bt_Mostrar.UseVisualStyleBackColor = true;
            this.bt_Mostrar.Click += new System.EventHandler(this.bt_Mostrar_Click);
            // 
            // bt_Iniciar
            // 
            this.bt_Iniciar.Location = new System.Drawing.Point(250, 323);
            this.bt_Iniciar.Name = "bt_Iniciar";
            this.bt_Iniciar.Size = new System.Drawing.Size(101, 36);
            this.bt_Iniciar.TabIndex = 2;
            this.bt_Iniciar.Text = "Iniciar";
            this.bt_Iniciar.UseVisualStyleBackColor = true;
            this.bt_Iniciar.Click += new System.EventHandler(this.bt_Iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Velocidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ct_Velocidad
            // 
            this.ct_Velocidad.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ct_Velocidad.Location = new System.Drawing.Point(231, 383);
            this.ct_Velocidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ct_Velocidad.Name = "ct_Velocidad";
            this.ct_Velocidad.Size = new System.Drawing.Size(120, 22);
            this.ct_Velocidad.TabIndex = 5;
            this.ct_Velocidad.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ct_Velocidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.Image = global::Práctica6.Properties.Resources.Image2;
            this.pb_Imagen.Location = new System.Drawing.Point(114, 50);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(237, 183);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagen.TabIndex = 6;
            this.pb_Imagen.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rchivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rchivoToolStripMenuItem
            // 
            this.rchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.rchivoToolStripMenuItem.Name = "rchivoToolStripMenuItem";
            this.rchivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.rchivoToolStripMenuItem.Text = "Archivo";
            this.rchivoToolStripMenuItem.Click += new System.EventHandler(this.rchivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 437);
            this.Controls.Add(this.pb_Imagen);
            this.Controls.Add(this.ct_Velocidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Iniciar);
            this.Controls.Add(this.bt_Mostrar);
            this.Controls.Add(this.bp_Progreso);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Hilos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ct_Velocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar bp_Progreso;
        private System.Windows.Forms.Button bt_Mostrar;
        private System.Windows.Forms.Button bt_Iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ct_Velocidad;
        private System.Windows.Forms.PictureBox pb_Imagen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
    }
}

