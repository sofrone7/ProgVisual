namespace ApWinForms
{
    partial class ElementoLista
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgFamoso = new System.Windows.Forms.PictureBox();
            this.etNomApEdad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtFechaNaci = new System.Windows.Forms.TextBox();
            this.ttElementoLista = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgFamoso)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFamoso
            // 
            this.imgFamoso.Location = new System.Drawing.Point(15, 40);
            this.imgFamoso.Name = "imgFamoso";
            this.imgFamoso.Size = new System.Drawing.Size(136, 143);
            this.imgFamoso.TabIndex = 0;
            this.imgFamoso.TabStop = false;
            // 
            // etNomApEdad
            // 
            this.etNomApEdad.AutoSize = true;
            this.etNomApEdad.Location = new System.Drawing.Point(179, 40);
            this.etNomApEdad.Name = "etNomApEdad";
            this.etNomApEdad.Size = new System.Drawing.Size(46, 17);
            this.etNomApEdad.TabIndex = 1;
            this.etNomApEdad.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(319, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(319, 128);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(175, 22);
            this.txtApellidos.TabIndex = 6;
            this.txtApellidos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFechaNaci
            // 
            this.txtFechaNaci.Location = new System.Drawing.Point(319, 161);
            this.txtFechaNaci.Name = "txtFechaNaci";
            this.txtFechaNaci.Size = new System.Drawing.Size(175, 22);
            this.txtFechaNaci.TabIndex = 7;
            // 
            // ElementoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFechaNaci);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etNomApEdad);
            this.Controls.Add(this.imgFamoso);
            this.Name = "ElementoLista";
            this.Size = new System.Drawing.Size(514, 205);
            ((System.ComponentModel.ISupportInitialize)(this.imgFamoso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFamoso;
        private System.Windows.Forms.Label etNomApEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtFechaNaci;
        private System.Windows.Forms.ToolTip ttElementoLista;
    }
}
