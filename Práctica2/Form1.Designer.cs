﻿namespace Práctica1
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesDeFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarColorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAnalógicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.label1.Location = new System.Drawing.Point(343, 107);
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
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesDeFuenteToolStripMenuItem,
            this.cambiarColorDeFondoToolStripMenuItem,
            this.mostrarAnalógicoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
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
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ct_HoraActual);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RelojDigital";
            this.Text = "Reloj Digital";
            this.Shown += new System.EventHandler(this.RelojDigital_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
    }
}

