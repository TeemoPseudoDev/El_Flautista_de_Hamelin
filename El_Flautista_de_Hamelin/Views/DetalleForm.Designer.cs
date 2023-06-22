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
            tarjeta_btn_tarjeta = new Button();
            tarjeta_btn_efectivo = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            total_precio = new Label();
            label5 = new Label();
            container_pago = new Panel();
            login_close = new PictureBox();
            panel_pago = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)login_close).BeginInit();
            panel_pago.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tarjeta_btn_tarjeta
            // 
            tarjeta_btn_tarjeta.BackColor = SystemColors.ActiveCaption;
            tarjeta_btn_tarjeta.Cursor = Cursors.Hand;
            tarjeta_btn_tarjeta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tarjeta_btn_tarjeta.ForeColor = SystemColors.ActiveCaptionText;
            tarjeta_btn_tarjeta.Location = new Point(280, 23);
            tarjeta_btn_tarjeta.Name = "tarjeta_btn_tarjeta";
            tarjeta_btn_tarjeta.Size = new Size(81, 41);
            tarjeta_btn_tarjeta.TabIndex = 5;
            tarjeta_btn_tarjeta.Text = "Tarjeta";
            tarjeta_btn_tarjeta.UseVisualStyleBackColor = false;
            tarjeta_btn_tarjeta.Click += button2_Click;
            // 
            // tarjeta_btn_efectivo
            // 
            tarjeta_btn_efectivo.BackColor = SystemColors.ActiveCaption;
            tarjeta_btn_efectivo.Cursor = Cursors.Hand;
            tarjeta_btn_efectivo.FlatAppearance.BorderColor = Color.Red;
            tarjeta_btn_efectivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            tarjeta_btn_efectivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            tarjeta_btn_efectivo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tarjeta_btn_efectivo.ForeColor = SystemColors.ActiveCaptionText;
            tarjeta_btn_efectivo.Location = new Point(162, 23);
            tarjeta_btn_efectivo.Name = "tarjeta_btn_efectivo";
            tarjeta_btn_efectivo.Size = new Size(81, 41);
            tarjeta_btn_efectivo.TabIndex = 4;
            tarjeta_btn_efectivo.Text = "Efectivo";
            tarjeta_btn_efectivo.UseVisualStyleBackColor = false;
            tarjeta_btn_efectivo.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 30);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 1;
            label2.Text = "Tipo de pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(163, 16);
            label3.Name = "label3";
            label3.Size = new Size(116, 42);
            label3.TabIndex = 6;
            label3.Text = "PAGO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 453);
            label4.Name = "label4";
            label4.Size = new Size(81, 24);
            label4.TabIndex = 7;
            label4.Text = "TOTAL:";
            // 
            // total_precio
            // 
            total_precio.AutoSize = true;
            total_precio.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            total_precio.Location = new Point(295, 453);
            total_precio.Name = "total_precio";
            total_precio.Size = new Size(94, 24);
            total_precio.TabIndex = 8;
            total_precio.Text = "*******";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(264, 452);
            label5.Name = "label5";
            label5.Size = new Size(25, 25);
            label5.TabIndex = 37;
            label5.Text = "$";
            // 
            // container_pago
            // 
            container_pago.AutoScroll = true;
            container_pago.Location = new Point(19, 61);
            container_pago.Name = "container_pago";
            container_pago.Size = new Size(395, 373);
            container_pago.TabIndex = 36;
            // 
            // login_close
            // 
            login_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            login_close.BackgroundImage = Properties.Resources.tenedor_y_cuchillo_en_cruz;
            login_close.BackgroundImageLayout = ImageLayout.Stretch;
            login_close.Cursor = Cursors.Hand;
            login_close.Location = new Point(469, 2);
            login_close.Name = "login_close";
            login_close.Size = new Size(25, 25);
            login_close.TabIndex = 35;
            login_close.TabStop = false;
            login_close.Click += login_close_Click;
            // 
            // panel_pago
            // 
            panel_pago.BackColor = SystemColors.Control;
            panel_pago.Controls.Add(label5);
            panel_pago.Controls.Add(label3);
            panel_pago.Controls.Add(total_precio);
            panel_pago.Controls.Add(container_pago);
            panel_pago.Controls.Add(label4);
            panel_pago.Location = new Point(31, 43);
            panel_pago.Name = "panel_pago";
            panel_pago.Size = new Size(430, 504);
            panel_pago.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tarjeta_btn_tarjeta);
            panel1.Controls.Add(tarjeta_btn_efectivo);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(31, 553);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 166);
            panel1.TabIndex = 37;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(146, 106);
            button1.Name = "button1";
            button1.Size = new Size(133, 49);
            button1.TabIndex = 6;
            button1.Text = "CONFIRMAR COMPRA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // DetalleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(497, 720);
            Controls.Add(panel1);
            Controls.Add(panel_pago);
            Controls.Add(login_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "detalle_pedido";
            Load += detalle_pedido_Load;
            ((System.ComponentModel.ISupportInitialize)login_close).EndInit();
            panel_pago.ResumeLayout(false);
            panel_pago.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button tarjeta_btn_tarjeta;
        private Button tarjeta_btn_efectivo;
        private Label label3;
        private Label label4;
        private Label total_precio;
        private PictureBox login_close;
        private Panel container_pago;
        private Label label5;
        private Panel panel_pago;
        private Panel panel1;
        private Button button1;
    }
}