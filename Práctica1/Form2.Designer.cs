namespace Práctica1
{
    partial class AcercaDe
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
            this.bt_Aceptar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Aceptar1
            // 
            this.bt_Aceptar1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Aceptar1.Location = new System.Drawing.Point(104, 187);
            this.bt_Aceptar1.Name = "bt_Aceptar1";
            this.bt_Aceptar1.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar1.TabIndex = 0;
            this.bt_Aceptar1.Text = "Aceptar";
            this.bt_Aceptar1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programación";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Práctica1.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(80, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AcercaDe
            // 
            this.AcceptButton = this.bt_Aceptar1;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Aceptar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcercaDe";
            this.Text = "Acerca de...";
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Aceptar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}