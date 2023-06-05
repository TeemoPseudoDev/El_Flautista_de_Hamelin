namespace El_Flautista_de_Hamelin.Views
{
    partial class TarjetaForm
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
            this.foto = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(39, 27);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(169, 112);
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(39, 155);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(62, 25);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "aquiiiii";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(39, 197);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(59, 25);
            this.precio.TabIndex = 2;
            this.precio.Text = "label2";
            // 
            // TarjetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(244, 264);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TarjetaForm";
            this.Text = "Tarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox foto;
        private Label nombre;
        private Label precio;
    }
}