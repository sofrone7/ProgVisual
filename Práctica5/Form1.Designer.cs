namespace Práctica5
{
    partial class VisorImágenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorImágenes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarBarraDeEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarBarraDeHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripPadre = new System.Windows.Forms.ToolStrip();
            this.Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Abrir = new System.Windows.Forms.ToolStripButton();
            this.Acerca = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.etiquetaEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStripPadre.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.ventanaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocultarBarraDeEstado,
            this.ocultarBarraDeHerramientas});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.DropDownOpened += new System.EventHandler(this.verToolStripMenuItem_DropDownOpened);
            // 
            // ocultarBarraDeEstado
            // 
            this.ocultarBarraDeEstado.Name = "ocultarBarraDeEstado";
            this.ocultarBarraDeEstado.Size = new System.Drawing.Size(290, 26);
            this.ocultarBarraDeEstado.Text = "Ocultar barra de estado";
            this.ocultarBarraDeEstado.Click += new System.EventHandler(this.ocultarBarraDeEstado_Click);
            // 
            // ocultarBarraDeHerramientas
            // 
            this.ocultarBarraDeHerramientas.Name = "ocultarBarraDeHerramientas";
            this.ocultarBarraDeHerramientas.Size = new System.Drawing.Size(290, 26);
            this.ocultarBarraDeHerramientas.Text = "Ocultar barra de herramientas";
            this.ocultarBarraDeHerramientas.Click += new System.EventHandler(this.ocultarBarraDeHerramientas_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.ArchivoCerrar,
            this.ArchivoNuevo,
            this.ArchivoAbrir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ArchivoCerrar
            // 
            this.ArchivoCerrar.Name = "ArchivoCerrar";
            this.ArchivoCerrar.Size = new System.Drawing.Size(135, 26);
            this.ArchivoCerrar.Text = "Cerrar";
            this.ArchivoCerrar.Click += new System.EventHandler(this.ArchivoCerrar_Click);
            // 
            // ArchivoNuevo
            // 
            this.ArchivoNuevo.Name = "ArchivoNuevo";
            this.ArchivoNuevo.Size = new System.Drawing.Size(135, 26);
            this.ArchivoNuevo.Text = "Nuevo";
            this.ArchivoNuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
            this.ArchivoNuevo.MouseEnter += new System.EventHandler(this.ArchivoNuevo_MouseEnter);
            this.ArchivoNuevo.MouseLeave += new System.EventHandler(this.ArchivoNuevo_MouseLeave);
            // 
            // ArchivoAbrir
            // 
            this.ArchivoAbrir.Name = "ArchivoAbrir";
            this.ArchivoAbrir.Size = new System.Drawing.Size(135, 26);
            this.ArchivoAbrir.Text = "Abrir";
            this.ArchivoAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
            this.ArchivoAbrir.MouseEnter += new System.EventHandler(this.ArchivoAbrir_MouseEnter);
            this.ArchivoAbrir.MouseLeave += new System.EventHandler(this.ArchivoAbrir_MouseLeave);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentanaCascada,
            this.VentanaMosaicoHorizontal,
            this.VentanaMosaicoVertical});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // VentanaCascada
            // 
            this.VentanaCascada.Name = "VentanaCascada";
            this.VentanaCascada.Size = new System.Drawing.Size(224, 26);
            this.VentanaCascada.Text = "Cascada";
            this.VentanaCascada.Click += new System.EventHandler(this.VentanaCascada_Click);
            this.VentanaCascada.MouseEnter += new System.EventHandler(this.VentanaCascada_MouseEnter);
            this.VentanaCascada.MouseLeave += new System.EventHandler(this.ArchivoAbrir_MouseLeave);
            // 
            // VentanaMosaicoHorizontal
            // 
            this.VentanaMosaicoHorizontal.Name = "VentanaMosaicoHorizontal";
            this.VentanaMosaicoHorizontal.Size = new System.Drawing.Size(224, 26);
            this.VentanaMosaicoHorizontal.Text = "Mosaico horizontal";
            this.VentanaMosaicoHorizontal.Click += new System.EventHandler(this.VentanaMosaicoHorizontal_Click);
            // 
            // VentanaMosaicoVertical
            // 
            this.VentanaMosaicoVertical.Name = "VentanaMosaicoVertical";
            this.VentanaMosaicoVertical.Size = new System.Drawing.Size(224, 26);
            this.VentanaMosaicoVertical.Text = "Mosaico vertical";
            this.VentanaMosaicoVertical.Click += new System.EventHandler(this.VentanaMosaicoVertical_Click);
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
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripPadre
            // 
            this.toolStripPadre.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripPadre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Abrir,
            this.Acerca});
            this.toolStripPadre.Location = new System.Drawing.Point(0, 28);
            this.toolStripPadre.Name = "toolStripPadre";
            this.toolStripPadre.Size = new System.Drawing.Size(888, 27);
            this.toolStripPadre.TabIndex = 3;
            this.toolStripPadre.Text = "toolStrip1";
            // 
            // Nuevo
            // 
            this.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(29, 24);
            this.Nuevo.Text = "Nueva imagen";
            this.Nuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
            this.Nuevo.MouseEnter += new System.EventHandler(this.ArchivoNuevo_MouseEnter);
            this.Nuevo.MouseLeave += new System.EventHandler(this.ArchivoNuevo_MouseLeave);
            this.Nuevo.MouseHover += new System.EventHandler(this.ArchivoNuevo_MouseEnter);
            // 
            // Abrir
            // 
            this.Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Abrir.Image")));
            this.Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(29, 24);
            this.Abrir.Text = "Abrir una imagen de tu ordenador";
            this.Abrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
            this.Abrir.MouseEnter += new System.EventHandler(this.ArchivoAbrir_MouseEnter);
            this.Abrir.MouseLeave += new System.EventHandler(this.ArchivoAbrir_MouseLeave);
            // 
            // Acerca
            // 
            this.Acerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Acerca.Image = ((System.Drawing.Image)(resources.GetObject("Acerca.Image")));
            this.Acerca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(29, 24);
            this.Acerca.Text = "Acerca de...";
            this.Acerca.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetaEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(0, 16);
            this.etiquetaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VisorImágenes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 568);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripPadre);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VisorImágenes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VisorImágenes_Load);
            this.MdiChildActivate += new System.EventHandler(this.VisorImágenes_MdiChildActivate);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.VisorImágenes_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VisorImágenes_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripPadre.ResumeLayout(false);
            this.toolStripPadre.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VentanaCascada;
        private System.Windows.Forms.ToolStripMenuItem VentanaMosaicoHorizontal;
        private System.Windows.Forms.ToolStripMenuItem VentanaMosaicoVertical;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArchivoCerrar;
        private System.Windows.Forms.ToolStripMenuItem ArchivoNuevo;
        private System.Windows.Forms.ToolStripMenuItem ArchivoAbrir;
        private System.Windows.Forms.ToolStrip toolStripPadre;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Abrir;
        private System.Windows.Forms.ToolStripButton Acerca;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaEstado;
        private System.Windows.Forms.ToolStripMenuItem ocultarBarraDeEstado;
        private System.Windows.Forms.ToolStripMenuItem ocultarBarraDeHerramientas;
    }
}

