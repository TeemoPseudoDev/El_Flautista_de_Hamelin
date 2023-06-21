namespace El_Flautista_de_Hamelin.Views
{
    partial class PlatoNoAbominacion
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
            label5no = new Label();
            comida_precio = new Label();
            comida_cantidad = new Label();
            label1no = new Label();
            comida_title = new Label();
            SuspendLayout();
            // 
            // label5no
            // 
            label5no.AutoSize = true;
            label5no.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5no.Location = new Point(247, 9);
            label5no.Name = "label5no";
            label5no.Size = new Size(14, 16);
            label5no.TabIndex = 10;
            label5no.Text = "$";
            // 
            // comida_precio
            // 
            comida_precio.AutoSize = true;
            comida_precio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comida_precio.Location = new Point(260, 7);
            comida_precio.MaximumSize = new Size(60, 18);
            comida_precio.Name = "comida_precio";
            comida_precio.Size = new Size(49, 16);
            comida_precio.TabIndex = 9;
            comida_precio.Text = "515151";
            // 
            // comida_cantidad
            // 
            comida_cantidad.AutoSize = true;
            comida_cantidad.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comida_cantidad.Location = new Point(218, 7);
            comida_cantidad.Name = "comida_cantidad";
            comida_cantidad.Size = new Size(14, 16);
            comida_cantidad.TabIndex = 8;
            comida_cantidad.Text = "1";
            // 
            // label1no
            // 
            label1no.AutoSize = true;
            label1no.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1no.Location = new Point(204, 5);
            label1no.Name = "label1no";
            label1no.Size = new Size(16, 18);
            label1no.TabIndex = 7;
            label1no.Text = "x";
            // 
            // comida_title
            // 
            comida_title.AutoSize = true;
            comida_title.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comida_title.Location = new Point(31, 9);
            comida_title.MaximumSize = new Size(170, 16);
            comida_title.Name = "comida_title";
            comida_title.Size = new Size(166, 16);
            comida_title.TabIndex = 6;
            comida_title.Text = "fsdfasdfasffsdfasdfasffsdfasdfasf";
            // 
            // PlatoNoAbominacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 31);
            Controls.Add(label5no);
            Controls.Add(comida_precio);
            Controls.Add(comida_cantidad);
            Controls.Add(label1no);
            Controls.Add(comida_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlatoNoAbominacion";
            Text = "PlatoNoAbominacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5no;
        private Label comida_precio;
        private Label comida_cantidad;
        private Label label1no;
        private Label comida_title;
    }
}