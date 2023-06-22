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
            foto = new PictureBox();
            nombre = new Label();
            precio = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)foto).BeginInit();
            SuspendLayout();
            // 
            // foto
            // 
            foto.BackgroundImageLayout = ImageLayout.Stretch;
            foto.Enabled = false;
            foto.ErrorImage = null;
            foto.ImageLocation = "";
            foto.InitialImage = null;
            foto.Location = new Point(11, 11);
            foto.Margin = new Padding(2);
            foto.Name = "foto";
            foto.Size = new Size(231, 157);
            foto.SizeMode = PictureBoxSizeMode.Zoom;
            foto.TabIndex = 0;
            foto.TabStop = false;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Enabled = false;
            nombre.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(27, 188);
            nombre.Margin = new Padding(2, 0, 2, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(60, 21);
            nombre.TabIndex = 1;
            nombre.Text = "aquiiiii";
            // 
            // precio
            // 
            precio.AutoSize = true;
            precio.Enabled = false;
            precio.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            precio.Location = new Point(50, 220);
            precio.Margin = new Padding(2, 0, 2, 0);
            precio.Name = "precio";
            precio.Size = new Size(55, 21);
            precio.TabIndex = 2;
            precio.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 220);
            label1.Name = "label1";
            label1.Size = new Size(18, 21);
            label1.TabIndex = 3;
            label1.Text = "$";
            // 
            // TarjetaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(253, 259);
            Controls.Add(label1);
            Controls.Add(precio);
            Controls.Add(nombre);
            Controls.Add(foto);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "TarjetaForm";
            Text = "Tarjeta";
            ((System.ComponentModel.ISupportInitialize)foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox foto;
        private Label nombre;
        private Label precio;
        private Label label1;
    }
}