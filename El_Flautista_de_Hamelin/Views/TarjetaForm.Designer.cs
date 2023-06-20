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
            ((System.ComponentModel.ISupportInitialize)foto).BeginInit();
            SuspendLayout();
            // 
            // foto
            // 
            foto.BackgroundImageLayout = ImageLayout.Stretch;
            foto.ImageLocation = "https://drive.google.com/file/d/1Quf6wXt7bfSULynYDUgegRWVODlO4UGL/view?usp=drive_link";
            foto.InitialImage = null;
            foto.Location = new Point(27, 16);
            foto.Margin = new Padding(2);
            foto.Name = "foto";
            foto.Size = new Size(118, 67);
            foto.SizeMode = PictureBoxSizeMode.StretchImage;
            foto.TabIndex = 0;
            foto.TabStop = false;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Enabled = false;
            nombre.Location = new Point(27, 93);
            nombre.Margin = new Padding(2, 0, 2, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(42, 15);
            nombre.TabIndex = 1;
            nombre.Text = "aquiiiii";
            // 
            // precio
            // 
            precio.AutoSize = true;
            precio.Enabled = false;
            precio.Location = new Point(27, 118);
            precio.Margin = new Padding(2, 0, 2, 0);
            precio.Name = "precio";
            precio.Size = new Size(38, 15);
            precio.TabIndex = 2;
            precio.Text = "label2";
            // 
            // TarjetaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(171, 158);
            Controls.Add(precio);
            Controls.Add(nombre);
            Controls.Add(foto);
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
    }
}