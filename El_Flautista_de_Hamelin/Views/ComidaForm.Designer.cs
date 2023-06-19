namespace El_Flautista_de_Hamelin.Views
{
    partial class ComidaForm
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
            Contenedor = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // Contenedor
            // 
            Contenedor.AutoScroll = true;
            Contenedor.BackColor = SystemColors.ControlLightLight;
            Contenedor.Location = new Point(47, 45);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1039, 596);
            Contenedor.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(1143, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 596);
            panel1.TabIndex = 1;
            // 
            // ComidaForm
            // 
            ClientSize = new Size(1447, 720);
            Controls.Add(panel1);
            Controls.Add(Contenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComidaForm";
            Load += Comida_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel Contenedor;
        private Panel panel1;
    }
}