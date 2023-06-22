namespace El_Flautista_de_Hamelin.Views
{
    partial class Plato
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
            plato_name = new Label();
            plato_x = new Label();
            plato_delete = new Button();
            plato_quantity = new Label();
            plato_gold = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // plato_name
            // 
            plato_name.AutoSize = true;
            plato_name.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            plato_name.Location = new Point(3, 9);
            plato_name.MaximumSize = new Size(170, 16);
            plato_name.Name = "plato_name";
            plato_name.Size = new Size(166, 16);
            plato_name.TabIndex = 0;
            plato_name.Text = "fsdfasdfasffsdfasdfasffsdfasdfasf";
            // 
            // plato_x
            // 
            plato_x.AutoSize = true;
            plato_x.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            plato_x.Location = new Point(176, 5);
            plato_x.Name = "plato_x";
            plato_x.Size = new Size(16, 18);
            plato_x.TabIndex = 1;
            plato_x.Text = "x";
            // 
            // plato_delete
            // 
            plato_delete.Cursor = Cursors.Hand;
            plato_delete.FlatAppearance.BorderColor = Color.Maroon;
            plato_delete.FlatStyle = FlatStyle.Flat;
            plato_delete.Location = new Point(289, 5);
            plato_delete.Name = "plato_delete";
            plato_delete.Size = new Size(45, 23);
            plato_delete.TabIndex = 2;
            plato_delete.Text = "X";
            plato_delete.UseVisualStyleBackColor = true;
            plato_delete.Click += HandleClickPlatoClose;
            // 
            // plato_quantity
            // 
            plato_quantity.AutoSize = true;
            plato_quantity.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            plato_quantity.Location = new Point(190, 7);
            plato_quantity.Name = "plato_quantity";
            plato_quantity.Size = new Size(14, 16);
            plato_quantity.TabIndex = 3;
            plato_quantity.Text = "1";
            // 
            // plato_gold
            // 
            plato_gold.AutoSize = true;
            plato_gold.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            plato_gold.Location = new Point(232, 7);
            plato_gold.MaximumSize = new Size(60, 18);
            plato_gold.Name = "plato_gold";
            plato_gold.Size = new Size(49, 16);
            plato_gold.TabIndex = 4;
            plato_gold.Text = "515151";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(220, 7);
            label1.Name = "label1";
            label1.Size = new Size(14, 16);
            label1.TabIndex = 5;
            label1.Text = "$";
            // 
            // Plato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(340, 31);
            Controls.Add(label1);
            Controls.Add(plato_gold);
            Controls.Add(plato_quantity);
            Controls.Add(plato_delete);
            Controls.Add(plato_x);
            Controls.Add(plato_name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Plato";
            Text = "Plato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label plato_name;
        private Label plato_x;
        private Button plato_delete;
        private Label plato_quantity;
        private Label plato_gold;
        private Label label1;
    }
}