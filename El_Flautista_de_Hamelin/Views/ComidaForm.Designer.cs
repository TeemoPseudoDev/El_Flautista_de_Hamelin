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
            this.Contenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.AutoScroll = true;
            this.Contenedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Contenedor.Location = new System.Drawing.Point(47, 45);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1039, 446);
            this.Contenedor.TabIndex = 0;
            // 
            // ComidaForm
            // 
            this.ClientSize = new System.Drawing.Size(1334, 518);
            this.Controls.Add(this.Contenedor);
            this.Name = "ComidaForm";
            this.Load += new System.EventHandler(this.Comida_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Contenedor;
    }
}