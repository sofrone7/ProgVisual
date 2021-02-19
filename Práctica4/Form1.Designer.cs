namespace Práctica1
{
    partial class RelojDigital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelojDigital));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesDeFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarColorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAnalógicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despertadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menúContextoAlarma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpcionesDespertadorActivar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesDespertadorDesactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.menúZona = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.zonaEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cv_Despertador = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ct_Alarma = new Práctica1.EditHora();
            this.menuStrip1.SuspendLayout();
            this.menúContextoAlarma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.menúZona});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesDeFuenteToolStripMenuItem,
            this.cambiarColorDeFondoToolStripMenuItem,
            this.mostrarAnalógicoToolStripMenuItem,
            this.despertadorToolStripMenuItem1});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.DropDownOpened += new System.EventHandler(this.opcionesToolStripMenuItem_DropDownOpened);
            // 
            // ajustesDeFuenteToolStripMenuItem
            // 
            this.ajustesDeFuenteToolStripMenuItem.Name = "ajustesDeFuenteToolStripMenuItem";
            this.ajustesDeFuenteToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ajustesDeFuenteToolStripMenuItem.Text = "Ajustes de fuente";
            this.ajustesDeFuenteToolStripMenuItem.Click += new System.EventHandler(this.ajustesDeFuenteToolStripMenuItem_Click);
            // 
            // cambiarColorDeFondoToolStripMenuItem
            // 
            this.cambiarColorDeFondoToolStripMenuItem.Name = "cambiarColorDeFondoToolStripMenuItem";
            this.cambiarColorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.cambiarColorDeFondoToolStripMenuItem.Text = "Cambiar color de fondo";
            this.cambiarColorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.cambiarColorDeFondoToolStripMenuItem_Click);
            // 
            // mostrarAnalógicoToolStripMenuItem
            // 
            this.mostrarAnalógicoToolStripMenuItem.Name = "mostrarAnalógicoToolStripMenuItem";
            this.mostrarAnalógicoToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.mostrarAnalógicoToolStripMenuItem.Text = "Mostrar analógico";
            this.mostrarAnalógicoToolStripMenuItem.Click += new System.EventHandler(this.mostrarAnalógicoToolStripMenuItem_Click);
            // 
            // despertadorToolStripMenuItem1
            // 
            this.despertadorToolStripMenuItem1.DropDown = this.menúContextoAlarma;
            this.despertadorToolStripMenuItem1.Name = "despertadorToolStripMenuItem1";
            this.despertadorToolStripMenuItem1.Size = new System.Drawing.Size(251, 26);
            this.despertadorToolStripMenuItem1.Text = "Despertador";
            // 
            // menúContextoAlarma
            // 
            this.menúContextoAlarma.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menúContextoAlarma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesDespertadorActivar,
            this.OpcionesDespertadorDesactivar});
            this.menúContextoAlarma.Name = "menúContextoAlarma";
            this.menúContextoAlarma.OwnerItem = this.despertadorToolStripMenuItem1;
            this.menúContextoAlarma.Size = new System.Drawing.Size(148, 52);
            // 
            // OpcionesDespertadorActivar
            // 
            this.OpcionesDespertadorActivar.Name = "OpcionesDespertadorActivar";
            this.OpcionesDespertadorActivar.Size = new System.Drawing.Size(147, 24);
            this.OpcionesDespertadorActivar.Text = "Activar";
            this.OpcionesDespertadorActivar.Click += new System.EventHandler(this.activarToolStripMenuItem_Click);
            // 
            // OpcionesDespertadorDesactivar
            // 
            this.OpcionesDespertadorDesactivar.Enabled = false;
            this.OpcionesDespertadorDesactivar.Name = "OpcionesDespertadorDesactivar";
            this.OpcionesDespertadorDesactivar.Size = new System.Drawing.Size(147, 24);
            this.OpcionesDespertadorDesactivar.Text = "Desactivar";
            this.OpcionesDespertadorDesactivar.Click += new System.EventHandler(this.desactivarToolStripMenuItem_Click);
            // 
            // menúZona
            // 
            this.menúZona.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zonaAñadir,
            this.zonaSeparador,
            this.zonaEliminar});
            this.menúZona.Name = "menúZona";
            this.menúZona.Size = new System.Drawing.Size(57, 26);
            this.menúZona.Text = "Zona";
            this.menúZona.DropDownOpened += new System.EventHandler(this.menúZona_DropDownOpened);
            this.menúZona.Click += new System.EventHandler(this.menúZona_Click);
            // 
            // zonaAñadir
            // 
            this.zonaAñadir.Name = "zonaAñadir";
            this.zonaAñadir.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.zonaAñadir.Size = new System.Drawing.Size(250, 26);
            this.zonaAñadir.Text = "Añadir";
            this.zonaAñadir.Click += new System.EventHandler(this.zonaAñadir_Click);
            // 
            // zonaSeparador
            // 
            this.zonaSeparador.Name = "zonaSeparador";
            this.zonaSeparador.Size = new System.Drawing.Size(247, 6);
            // 
            // zonaEliminar
            // 
            this.zonaEliminar.Name = "zonaEliminar";
            this.zonaEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.zonaEliminar.Size = new System.Drawing.Size(250, 26);
            this.zonaEliminar.Text = "Eliminar";
            this.zonaEliminar.Click += new System.EventHandler(this.zonaEliminar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ct_HoraActual
            // 
            this.ct_HoraActual.ForeColor = System.Drawing.Color.Blue;
            this.ct_HoraActual.Location = new System.Drawing.Point(305, 172);
            this.ct_HoraActual.Name = "ct_HoraActual";
            this.ct_HoraActual.ReadOnly = true;
            this.ct_HoraActual.Size = new System.Drawing.Size(156, 22);
            this.ct_HoraActual.TabIndex = 1;
            this.ct_HoraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora actual";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alarma:";
            // 
            // cv_Despertador
            // 
            this.cv_Despertador.AutoSize = true;
            this.cv_Despertador.Location = new System.Drawing.Point(300, 301);
            this.cv_Despertador.Name = "cv_Despertador";
            this.cv_Despertador.Size = new System.Drawing.Size(166, 21);
            this.cv_Despertador.TabIndex = 7;
            this.cv_Despertador.Text = "Despertador activado";
            this.cv_Despertador.UseVisualStyleBackColor = true;
            this.cv_Despertador.Click += new System.EventHandler(this.cv_Despertador_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mostrar zonas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ct_Alarma
            // 
            this.ct_Alarma.BeepOnError = true;
            this.ct_Alarma.ContextMenuStrip = this.menúContextoAlarma;
            this.ct_Alarma.Hora = new System.DateTime(((long)(0)));
            this.ct_Alarma.Location = new System.Drawing.Point(305, 259);
            this.ct_Alarma.Mask = "90:00:99";
            this.ct_Alarma.Name = "ct_Alarma";
            this.ct_Alarma.PromptChar = '-';
            this.ct_Alarma.Size = new System.Drawing.Size(156, 22);
            this.ct_Alarma.TabIndex = 4;
            this.ct_Alarma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Alarma.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cv_Despertador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ct_Alarma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ct_HoraActual);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RelojDigital";
            this.Text = "Reloj Digital";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RelojDigital_FormClosing);
            this.Load += new System.EventHandler(this.RelojDigital_Load);
            this.Shown += new System.EventHandler(this.RelojDigital_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menúContextoAlarma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ct_HoraActual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesDeFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarColorDeFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarAnalógicoToolStripMenuItem;
        private EditHora ct_Alarma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem despertadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menúZona;
        private System.Windows.Forms.ToolStripMenuItem zonaAñadir;
        private System.Windows.Forms.ToolStripSeparator zonaSeparador;
        private System.Windows.Forms.ToolStripMenuItem zonaEliminar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip menúContextoAlarma;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorActivar;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorDesactivar;
        private System.Windows.Forms.CheckBox cv_Despertador;
        private System.Windows.Forms.Button button1;
    }
}

