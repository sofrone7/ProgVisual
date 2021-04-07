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
            this.famosoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etNomApEdad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtFechaNaci = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgFamoso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.famosoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFamoso
            // 
            this.imgFamoso.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.famosoBindingSource, "Imagen", true));
            this.imgFamoso.Location = new System.Drawing.Point(20, 28);
            this.imgFamoso.Name = "imgFamoso";
            this.imgFamoso.Size = new System.Drawing.Size(308, 306);
            this.imgFamoso.TabIndex = 0;
            this.imgFamoso.TabStop = false;
            // 
            // famosoBindingSource
            // 
            this.famosoBindingSource.DataSource = typeof(BDFamosos.CFamosoBO);
            // 
            // etNomApEdad
            // 
            this.etNomApEdad.AutoSize = true;
            this.etNomApEdad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "NombreAprellidosEdad", true));
            this.etNomApEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNomApEdad.Location = new System.Drawing.Point(349, 28);
            this.etNomApEdad.Name = "etNomApEdad";
            this.etNomApEdad.Size = new System.Drawing.Size(52, 17);
            this.etNomApEdad.TabIndex = 1;
            this.etNomApEdad.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "Apellidos", true));
            this.txtApellidos.Location = new System.Drawing.Point(521, 152);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(168, 22);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtFechaNaci
            // 
            this.txtFechaNaci.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "Cumple", true));
            this.txtFechaNaci.Location = new System.Drawing.Point(521, 195);
            this.txtFechaNaci.Name = "txtFechaNaci";
            this.txtFechaNaci.Size = new System.Drawing.Size(168, 22);
            this.txtFechaNaci.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(521, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 22);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ElementoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFechaNaci);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etNomApEdad);
            this.Controls.Add(this.imgFamoso);
            this.Name = "ElementoLista";
            this.Size = new System.Drawing.Size(723, 416);
            ((System.ComponentModel.ISupportInitialize)(this.imgFamoso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.famosoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource famosoBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.PictureBox imgFamoso;
        public System.Windows.Forms.Label etNomApEdad;
        public System.Windows.Forms.TextBox txtApellidos;
        public System.Windows.Forms.TextBox txtFechaNaci;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label label2;
    }
}
