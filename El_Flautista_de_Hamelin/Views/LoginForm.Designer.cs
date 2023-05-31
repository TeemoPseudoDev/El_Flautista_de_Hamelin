using System.Windows.Forms;

namespace El_Flautista_de_Hamelin
{
    partial class LoginForm
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
            newaccount_title = new Label();
            panel1 = new Panel();
            login_minimize = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            user_container.SuspendLayout();
            psw_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)login_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)login_submit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)login_minimize).BeginInit();
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
            pictureBox1.Size = new Size(691, 722);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // login_input_user
            // 
            login_input_user.BackColor = Color.FromArgb(224, 224, 224);
            login_input_user.BorderStyle = BorderStyle.None;
            login_input_user.Cursor = Cursors.Hand;
            login_input_user.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            login_input_user.Location = new Point(3, 14);
            login_input_user.MaxLength = 15;
            login_input_user.Name = "login_input_user";
            login_input_user.PlaceholderText = "Nombre de usuario";
            login_input_user.Size = new Size(174, 20);
            login_input_user.TabIndex = 1;
            login_input_user.TextChanged += HandleChanged;
            login_input_user.Enter += input_Enter;
            login_input_user.Leave += input_Leave;
            // 
            // user_container
            // 
            user_container.BackColor = Color.FromArgb(224, 224, 224);
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
            login_input_psw.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            login_input_psw.Location = new Point(3, 14);
            login_input_psw.MaxLength = 15;
            login_input_psw.Name = "login_input_psw";
            login_input_psw.PlaceholderText = "Contraseña";
            login_input_psw.Size = new Size(174, 20);
            login_input_psw.TabIndex = 1;
            login_input_psw.UseSystemPasswordChar = true;
            login_input_psw.TextChanged += HandleChanged;
            login_input_psw.Enter += input_Enter;
            login_input_psw.Leave += input_Leave;
            // 
            // login_close
            // 
            login_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            login_close.BackgroundImage = Properties.Resources.tenedor_y_cuchillo_en_cruz;
            login_close.BackgroundImageLayout = ImageLayout.Stretch;
            login_close.Cursor = Cursors.Hand;
            login_close.Location = new Point(1248, 8);
            login_close.Name = "login_close";
            login_close.Size = new Size(25, 25);
            login_close.TabIndex = 6;
            login_close.TabStop = false;
            login_close.Click += form_close;
            // 
            // login_submit
            // 
            login_submit.BackColor = SystemColors.Control;
            login_submit.BackgroundImage = Properties.Resources.entrar;
            login_submit.BackgroundImageLayout = ImageLayout.Stretch;
            login_submit.Cursor = Cursors.Hand;
            login_submit.Location = new Point(962, 505);
            login_submit.Name = "login_submit";
            login_submit.Size = new Size(60, 60);
            login_submit.TabIndex = 7;
            login_submit.TabStop = false;
            login_submit.Click += HandleSubmit;
            // 
            // user_message
            // 
            user_message.AutoSize = true;
            user_message.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            user_message.ForeColor = Color.Red;
            user_message.Location = new Point(880, 288);
            user_message.Name = "user_message";
            user_message.Size = new Size(248, 42);
            user_message.TabIndex = 8;
            user_message.Text = "Sólo se admiten letras y números.\r\nMínimo 5 caracteres.\r\n";
            user_message.TextAlign = ContentAlignment.MiddleCenter;
            user_message.Visible = false;
            // 
            // psw_message
            // 
            psw_message.AutoSize = true;
            psw_message.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            psw_message.ForeColor = Color.Red;
            psw_message.Location = new Point(910, 404);
            psw_message.Name = "psw_message";
            psw_message.Size = new Size(188, 42);
            psw_message.TabIndex = 9;
            psw_message.Text = "Letras, números, '!' y '_'.\r\nMínimo 5 caracteres.\r\n";
            psw_message.TextAlign = ContentAlignment.MiddleCenter;
            psw_message.Visible = false;
            // 
            // login_new
            // 
            login_new.AutoSize = true;
            login_new.Cursor = Cursors.Hand;
            login_new.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            login_new.Location = new Point(880, 613);
            login_new.Name = "login_new";
            login_new.Size = new Size(249, 21);
            login_new.TabIndex = 11;
            login_new.Text = "¿Eres nuevo? Crea tu cuenta aquí";
            login_new.Click += login_new_Click;
            // 
            // general_message_error
            // 
            general_message_error.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            general_message_error.AutoSize = true;
            general_message_error.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            general_message_error.ForeColor = Color.Red;
            general_message_error.Location = new Point(876, 190);
            general_message_error.Name = "general_message_error";
            general_message_error.Size = new Size(258, 21);
            general_message_error.TabIndex = 10;
            general_message_error.Text = "Usuario y/o contraseña inexistentes";
            general_message_error.Visible = false;
            // 
            // newaccount_title
            // 
            newaccount_title.AutoSize = true;
            newaccount_title.BackColor = SystemColors.Control;
            newaccount_title.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point);
            newaccount_title.ForeColor = SystemColors.WindowText;
            newaccount_title.Location = new Point(904, 58);
            newaccount_title.Name = "newaccount_title";
            newaccount_title.Size = new Size(204, 54);
            newaccount_title.TabIndex = 30;
            newaccount_title.Text = "Ingresar";
            // 
            // panel1
            // 
            panel1.Location = new Point(698, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 31;
            // 
            // login_minimize
            // 
            login_minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            login_minimize.BackgroundImage = Properties.Resources.tenedor;
            login_minimize.BackgroundImageLayout = ImageLayout.Stretch;
            login_minimize.Cursor = Cursors.Hand;
            login_minimize.Location = new Point(1203, 0);
            login_minimize.Name = "login_minimize";
            login_minimize.Size = new Size(32, 40);
            login_minimize.TabIndex = 32;
            login_minimize.TabStop = false;
            login_minimize.Click += login_minimize_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1280, 720);
            ControlBox = false;
            Controls.Add(login_minimize);
            Controls.Add(panel1);
            Controls.Add(newaccount_title);
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
            Name = "LoginForm";
            Padding = new Padding(4, 5, 4, 5);
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            user_container.ResumeLayout(false);
            user_container.PerformLayout();
            psw_container.ResumeLayout(false);
            psw_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)login_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)login_submit).EndInit();
            ((System.ComponentModel.ISupportInitialize)login_minimize).EndInit();
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
        private Label newaccount_title;
        private Panel panel1;
        private PictureBox login_minimize;
    }
}