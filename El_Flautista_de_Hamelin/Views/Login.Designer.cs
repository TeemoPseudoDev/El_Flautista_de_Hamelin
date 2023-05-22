using System.Windows.Forms;

namespace El_Flautista_de_Hamelin
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            login_input_user = new TextBox();
            user_container = new Panel();
            psw_container = new Panel();
            login_input_psw = new TextBox();
            login_close = new PictureBox();
            login_submit = new PictureBox();
            user_message = new Label();
            psw_message = new Label();
            login_new = new Label();
            general_message_error = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            user_container.SuspendLayout();
            psw_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)login_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)login_submit).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImage = Properties.Resources.moto_delivery;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(691, 706);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // login_input_user
            // 
            login_input_user.BackColor = Color.FromArgb(224, 224, 224);
            login_input_user.BorderStyle = BorderStyle.None;
            login_input_user.Cursor = Cursors.Hand;
            login_input_user.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            login_input_user.Location = new Point(3, 14);
            login_input_user.MaxLength = 15;
            login_input_user.Name = "login_input_user";
            login_input_user.PlaceholderText = "Nombre de usuario";
            login_input_user.Size = new Size(174, 20);
            login_input_user.TabIndex = 1;
            login_input_user.TextChanged += HandleChanged;
            login_input_user.Enter += login_input_user_Enter;
            login_input_user.Leave += login_input_user_Leave;
            // 
            // user_container
            // 
            user_container.BackColor = Color.FromArgb(224, 224, 224);
            user_container.BorderStyle = BorderStyle.FixedSingle;
            user_container.Controls.Add(login_input_user);
            user_container.Cursor = Cursors.Hand;
            user_container.Location = new Point(913, 234);
            user_container.Name = "user_container";
            user_container.Size = new Size(180, 51);
            user_container.TabIndex = 4;
            user_container.Click += User_container_Click;
            // 
            // psw_container
            // 
            psw_container.BackColor = Color.FromArgb(224, 224, 224);
            psw_container.Controls.Add(login_input_psw);
            psw_container.Cursor = Cursors.Hand;
            psw_container.Location = new Point(913, 350);
            psw_container.Name = "psw_container";
            psw_container.Size = new Size(180, 51);
            psw_container.TabIndex = 5;
            psw_container.Click += Psw_container_Click;
            // 
            // login_input_psw
            // 
            login_input_psw.BackColor = Color.FromArgb(224, 224, 224);
            login_input_psw.BorderStyle = BorderStyle.None;
            login_input_psw.Cursor = Cursors.Hand;
            login_input_psw.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            login_input_psw.Location = new Point(3, 14);
            login_input_psw.MaxLength = 15;
            login_input_psw.Name = "login_input_psw";
            login_input_psw.PlaceholderText = "Contraseña";
            login_input_psw.Size = new Size(174, 20);
            login_input_psw.TabIndex = 1;
            login_input_psw.UseSystemPasswordChar = true;
            login_input_psw.TextChanged += HandleChanged;
            login_input_psw.Enter += login_input_psw_Enter;
            login_input_psw.Leave += login_input_psw_Leave;
            // 
            // login_close
            // 
            login_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            login_close.BackgroundImage = Properties.Resources.tenedor_y_cuchillo_en_cruz;
            login_close.BackgroundImageLayout = ImageLayout.Stretch;
            login_close.Cursor = Cursors.Hand;
            login_close.Location = new Point(1222, 8);
            login_close.Name = "login_close";
            login_close.Size = new Size(35, 35);
            login_close.TabIndex = 6;
            login_close.TabStop = false;
            login_close.Click += HandleClose;
            // 
            // login_submit
            // 
            login_submit.BackgroundImage = Properties.Resources.pizza;
            login_submit.BackgroundImageLayout = ImageLayout.Stretch;
            login_submit.Cursor = Cursors.Hand;
            login_submit.Location = new Point(966, 499);
            login_submit.Name = "login_submit";
            login_submit.Size = new Size(80, 80);
            login_submit.TabIndex = 7;
            login_submit.TabStop = false;
            login_submit.Click += HandleSubmit;
            // 
            // user_message
            // 
            user_message.AutoSize = true;
            user_message.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            user_message.ForeColor = Color.Red;
            user_message.Location = new Point(898, 288);
            user_message.Name = "user_message";
            user_message.Size = new Size(217, 19);
            user_message.TabIndex = 8;
            user_message.Text = "Sólo se admiten letras y números";
            user_message.TextAlign = ContentAlignment.MiddleCenter;
            user_message.Visible = false;
            // 
            // psw_message
            // 
            psw_message.AutoSize = true;
            psw_message.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            psw_message.ForeColor = Color.Red;
            psw_message.Location = new Point(927, 404);
            psw_message.Name = "psw_message";
            psw_message.Size = new Size(151, 19);
            psw_message.TabIndex = 9;
            psw_message.Text = "Letras, números, '!' y '_'";
            psw_message.TextAlign = ContentAlignment.MiddleCenter;
            psw_message.Visible = false;
            psw_message.Click += psw_message_Click;
            // 
            // login_new
            // 
            login_new.AutoSize = true;
            login_new.Location = new Point(900, 610);
            login_new.Name = "login_new";
            login_new.Size = new Size(212, 19);
            login_new.TabIndex = 11;
            login_new.Text = "¿Eres nuevo? Crea tu cuenta aquí";
            // 
            // general_message_error
            // 
            general_message_error.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            general_message_error.AutoSize = true;
            general_message_error.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            general_message_error.ForeColor = Color.Red;
            general_message_error.Location = new Point(890, 181);
            general_message_error.Name = "general_message_error";
            general_message_error.Size = new Size(233, 19);
            general_message_error.TabIndex = 10;
            general_message_error.Text = "Usuario y/o contraseña inexistentes";
            general_message_error.Visible = false;
            general_message_error.Click += general_message_error_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1264, 704);
            ControlBox = false;
            Controls.Add(login_new);
            Controls.Add(general_message_error);
            Controls.Add(psw_message);
            Controls.Add(user_message);
            Controls.Add(login_submit);
            Controls.Add(login_close);
            Controls.Add(psw_container);
            Controls.Add(user_container);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Padding = new Padding(4, 5, 4, 5);
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            user_container.ResumeLayout(false);
            user_container.PerformLayout();
            psw_container.ResumeLayout(false);
            psw_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)login_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)login_submit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox login_input_user;
        private Panel user_container;
        private Panel psw_container;
        private TextBox login_input_psw;
        private PictureBox login_close;
        private PictureBox login_submit;
        private Label user_message;
        private Label psw_message;
        private Label login_new;
        private Label general_message_error;
    }
}