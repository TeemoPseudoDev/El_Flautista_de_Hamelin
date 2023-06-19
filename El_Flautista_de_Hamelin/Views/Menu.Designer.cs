namespace El_Flautista_de_Hamelin
{
    partial class Menu
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
            panel_btn_inicio = new Panel();
            text_inicio = new Label();
            pictureBox2 = new PictureBox();
            panel_btn_productos = new Panel();
            text_productos = new Label();
            pictureBox3 = new PictureBox();
            panel_btn_entregar = new Panel();
            text_entregar = new Label();
            pictureBox5 = new PictureBox();
            panel_btn_llevar = new Panel();
            text_llevar = new Label();
            pictureBox4 = new PictureBox();
            login_minimize = new PictureBox();
            login_close = new PictureBox();
            panel1.SuspendLayout();
            panel_btn_inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_btn_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel_btn_entregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel_btn_llevar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)login_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)login_close).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(panel_btn_inicio);
            panel1.Controls.Add(panel_btn_productos);
            panel1.Controls.Add(panel_btn_entregar);
            panel1.Controls.Add(panel_btn_llevar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 720);
            panel1.TabIndex = 0;
            // 
            // panel_btn_inicio
            // 
            panel_btn_inicio.AutoSize = true;
            panel_btn_inicio.Controls.Add(text_inicio);
            panel_btn_inicio.Controls.Add(pictureBox2);
            panel_btn_inicio.Cursor = Cursors.Hand;
            panel_btn_inicio.Location = new Point(8, 97);
            panel_btn_inicio.Name = "panel_btn_inicio";
            panel_btn_inicio.Size = new Size(157, 57);
            panel_btn_inicio.TabIndex = 38;
            panel_btn_inicio.Click += panel_btn_Click;
            // 
            // text_inicio
            // 
            text_inicio.AutoSize = true;
            text_inicio.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_inicio.ForeColor = SystemColors.ButtonHighlight;
            text_inicio.Location = new Point(64, 19);
            text_inicio.Name = "text_inicio";
            text_inicio.Size = new Size(49, 20);
            text_inicio.TabIndex = 41;
            text_inicio.Text = "Inicio";
            text_inicio.Click += panel_btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Image = Properties.Resources.home;
            pictureBox2.Location = new Point(8, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel_btn_productos
            // 
            panel_btn_productos.AutoSize = true;
            panel_btn_productos.BackColor = Color.FromArgb(41, 39, 40);
            panel_btn_productos.Controls.Add(text_productos);
            panel_btn_productos.Controls.Add(pictureBox3);
            panel_btn_productos.Cursor = Cursors.Hand;
            panel_btn_productos.ForeColor = SystemColors.ButtonHighlight;
            panel_btn_productos.Location = new Point(8, 175);
            panel_btn_productos.Name = "panel_btn_productos";
            panel_btn_productos.Size = new Size(157, 57);
            panel_btn_productos.TabIndex = 37;
            panel_btn_productos.Click += panel_btn_Click;
            // 
            // text_productos
            // 
            text_productos.AutoSize = true;
            text_productos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_productos.Location = new Point(64, 19);
            text_productos.Name = "text_productos";
            text_productos.Size = new Size(83, 20);
            text_productos.TabIndex = 40;
            text_productos.Text = "Productos";
            text_productos.Click += panel_btn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Enabled = false;
            pictureBox3.Image = Properties.Resources.com;
            pictureBox3.Location = new Point(8, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel_btn_entregar
            // 
            panel_btn_entregar.AutoSize = true;
            panel_btn_entregar.Controls.Add(text_entregar);
            panel_btn_entregar.Controls.Add(pictureBox5);
            panel_btn_entregar.Cursor = Cursors.Hand;
            panel_btn_entregar.Location = new Point(8, 253);
            panel_btn_entregar.Name = "panel_btn_entregar";
            panel_btn_entregar.Size = new Size(158, 57);
            panel_btn_entregar.TabIndex = 36;
            panel_btn_entregar.Click += panel_btn_Click;
            // 
            // text_entregar
            // 
            text_entregar.AutoSize = true;
            text_entregar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_entregar.ForeColor = SystemColors.ButtonHighlight;
            text_entregar.Location = new Point(64, 8);
            text_entregar.Name = "text_entregar";
            text_entregar.Size = new Size(71, 40);
            text_entregar.TabIndex = 39;
            text_entregar.Text = "Entregar\r\nen mesa";
            text_entregar.Click += panel_btn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Enabled = false;
            pictureBox5.Image = Properties.Resources.delivery;
            pictureBox5.Location = new Point(8, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // panel_btn_llevar
            // 
            panel_btn_llevar.AutoSize = true;
            panel_btn_llevar.Controls.Add(text_llevar);
            panel_btn_llevar.Controls.Add(pictureBox4);
            panel_btn_llevar.Cursor = Cursors.Hand;
            panel_btn_llevar.Location = new Point(8, 331);
            panel_btn_llevar.Name = "panel_btn_llevar";
            panel_btn_llevar.Size = new Size(157, 57);
            panel_btn_llevar.TabIndex = 35;
            panel_btn_llevar.Click += panel_btn_Click;
            // 
            // text_llevar
            // 
            text_llevar.AutoSize = true;
            text_llevar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_llevar.ForeColor = SystemColors.ButtonHighlight;
            text_llevar.Location = new Point(64, 19);
            text_llevar.Name = "text_llevar";
            text_llevar.Size = new Size(88, 20);
            text_llevar.TabIndex = 35;
            text_llevar.Text = "Para llevar";
            text_llevar.Click += panel_btn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Enabled = false;
            pictureBox4.Image = Properties.Resources.takeaway;
            pictureBox4.Location = new Point(8, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // login_minimize
            // 
            login_minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            login_minimize.BackgroundImage = Properties.Resources.tenedor;
            login_minimize.BackgroundImageLayout = ImageLayout.Stretch;
            login_minimize.Cursor = Cursors.Hand;
            login_minimize.Location = new Point(1194, 12);
            login_minimize.Name = "login_minimize";
            login_minimize.Size = new Size(32, 40);
            login_minimize.TabIndex = 33;
            login_minimize.TabStop = false;
            login_minimize.Click += login_minimize_Click;
            // 
            // login_close
            // 
            login_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            login_close.BackgroundImage = Properties.Resources.tenedor_y_cuchillo_en_cruz;
            login_close.BackgroundImageLayout = ImageLayout.Stretch;
            login_close.Cursor = Cursors.Hand;
            login_close.Location = new Point(1243, 20);
            login_close.Name = "login_close";
            login_close.Size = new Size(25, 25);
            login_close.TabIndex = 34;
            login_close.TabStop = false;
            login_close.Click += form_close;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(login_close);
            Controls.Add(login_minimize);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterParent;
            Load += LoginForm_Load;
            Click += login_minimize_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_btn_inicio.ResumeLayout(false);
            panel_btn_inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_btn_productos.ResumeLayout(false);
            panel_btn_productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel_btn_entregar.ResumeLayout(false);
            panel_btn_entregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel_btn_llevar.ResumeLayout(false);
            panel_btn_llevar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)login_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)login_close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox login_minimize;
        private PictureBox login_close;
        private Panel panel_btn_llevar;
        private Panel panel_btn_productos;
        private PictureBox pictureBox3;
        private Panel panel_btn_entregar;
        private PictureBox pictureBox5;
        private Panel panel_btn_inicio;
        private PictureBox pictureBox2;
        private Label text_inicio;
        private Label text_productos;
        private Label text_entregar;
        private Label text_llevar;
    }
}