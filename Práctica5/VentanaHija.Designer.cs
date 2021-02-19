namespace Práctica5
{
    partial class VentanaHija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaHija));
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.rotar90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenAñadirTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenEscalaDeGrises = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchivoGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHija = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripHija.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(600, 330);
            this.m_PictureBox.TabIndex = 0;
            this.m_PictureBox.TabStop = false;
            this.m_PictureBox.Click += new System.EventHandler(this.m_PictureBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImagenAjustar,
            this.rotar90ToolStripMenuItem,
            this.ImagenAñadirTexto,
            this.ImagenEscalaDeGrises});
            this.imagenToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.imagenToolStripMenuItem.MergeIndex = 2;
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // ImagenAjustar
            // 
            this.ImagenAjustar.Name = "ImagenAjustar";
            this.ImagenAjustar.Size = new System.Drawing.Size(224, 26);
            this.ImagenAjustar.Text = "Ajustar a ventana";
            this.ImagenAjustar.Click += new System.EventHandler(this.ImagenAjustar_Click);
            // 
            // rotar90ToolStripMenuItem
            // 
            this.rotar90ToolStripMenuItem.Name = "rotar90ToolStripMenuItem";
            this.rotar90ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rotar90ToolStripMenuItem.Text = "Rotar 90º ";
            this.rotar90ToolStripMenuItem.Click += new System.EventHandler(this.rotar90ToolStripMenuItem_Click);
            // 
            // ImagenAñadirTexto
            // 
            this.ImagenAñadirTexto.Name = "ImagenAñadirTexto";
            this.ImagenAñadirTexto.Size = new System.Drawing.Size(224, 26);
            this.ImagenAñadirTexto.Text = "Añadir texto";
            this.ImagenAñadirTexto.Click += new System.EventHandler(this.ImagenAñadirTexto_Click);
            // 
            // ImagenEscalaDeGrises
            // 
            this.ImagenEscalaDeGrises.Name = "ImagenEscalaDeGrises";
            this.ImagenEscalaDeGrises.Size = new System.Drawing.Size(224, 26);
            this.ImagenEscalaDeGrises.Text = "Escala de grises";
            this.ImagenEscalaDeGrises.Click += new System.EventHandler(this.ImagenEscalaDeGrises_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoGuardar,
            this.toolStripMenuItem1,
            this.ArchivoGuardarComo});
            this.archivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ArchivoGuardar
            // 
            this.ArchivoGuardar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ArchivoGuardar.MergeIndex = 3;
            this.ArchivoGuardar.Name = "ArchivoGuardar";
            this.ArchivoGuardar.Size = new System.Drawing.Size(224, 26);
            this.ArchivoGuardar.Text = "Guardar";
            this.ArchivoGuardar.Click += new System.EventHandler(this.ArchivoGuardar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem1.MergeIndex = 4;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // ArchivoGuardarComo
            // 
            this.ArchivoGuardarComo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ArchivoGuardarComo.MergeIndex = 5;
            this.ArchivoGuardarComo.Name = "ArchivoGuardarComo";
            this.ArchivoGuardarComo.Size = new System.Drawing.Size(224, 26);
            this.ArchivoGuardarComo.Text = "Guardar como...";
            this.ArchivoGuardarComo.Click += new System.EventHandler(this.ArchivoGuardarComo_Click);
            // 
            // toolStripHija
            // 
            this.toolStripHija.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripHija.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStripHija.Location = new System.Drawing.Point(0, 0);
            this.toolStripHija.Name = "toolStripHija";
            this.toolStripHija.Size = new System.Drawing.Size(800, 27);
            this.toolStripHija.TabIndex = 2;
            this.toolStripHija.Text = "toolStrip1";
            this.toolStripHija.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton1.MergeIndex = 2;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ArchivoGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 3;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton2.MergeIndex = 4;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.ImagenAjustar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton3.MergeIndex = 5;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.ImagenAñadirTexto_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton4.MergeIndex = 6;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.rotar90ToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton5.MergeIndex = 7;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.ImagenEscalaDeGrises_Click);
            // 
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripHija);
            this.Controls.Add(this.m_PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaHija";
            this.Text = "VentanaHija";
            this.Load += new System.EventHandler(this.VentanaHija_Load);
            this.Click += new System.EventHandler(this.VentanaHija_Click);
            this.Resize += new System.EventHandler(this.VentanaHija_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripHija.ResumeLayout(false);
            this.toolStripHija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImagenAjustar;
        private System.Windows.Forms.ToolStripMenuItem rotar90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImagenAñadirTexto;
        private System.Windows.Forms.ToolStripMenuItem ImagenEscalaDeGrises;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
        private System.Windows.Forms.ToolStripMenuItem ArchivoGuardarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        public System.Windows.Forms.ToolStrip toolStripHija;
    }
}