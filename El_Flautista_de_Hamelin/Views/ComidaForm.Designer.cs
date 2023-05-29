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
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(47, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 299);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(414, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 299);
            panel2.TabIndex = 0;
            // 
            // ComidaForm
            // 
            ClientSize = new Size(736, 403);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ComidaForm";
            Load += Comida_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
    }
}