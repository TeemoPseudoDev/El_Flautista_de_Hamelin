namespace El_Flautista_de_Hamelin.Views
{
    partial class DetalleForm
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
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(678, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 182);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(145, 115);
            button2.Name = "button2";
            button2.Size = new Size(97, 49);
            button2.TabIndex = 5;
            button2.Text = "TARJETA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(19, 115);
            button1.Name = "button1";
            button1.Size = new Size(97, 49);
            button1.TabIndex = 4;
            button1.Text = "EFECTIVO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(178, 28);
            label2.TabIndex = 1;
            label2.Text = "Tipo de pago:";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 0;
            label1.Text = "PAGO";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 38);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 6;
            label3.Text = "PAGO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 385);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "TOTAL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 385);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 8;
            label5.Text = "**************";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(200, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 432);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(213, 115);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 15;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(150, 115);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 14;
            label8.Text = "x";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 115);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 13;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 115);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // DetalleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 595);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleForm";
            Text = "detalle_pedido";
            Load += detalle_pedido_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}