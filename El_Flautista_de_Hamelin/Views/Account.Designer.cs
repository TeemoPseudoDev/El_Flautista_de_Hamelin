namespace El_Flautista_de_Hamelin.Views
{
    partial class Account
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
            container_new_nacimiento = new Panel();
            new_nacimiento = new TextBox();
            container_new_nombre = new Panel();
            new_nombre = new TextBox();
            container_new_apellido = new Panel();
            new_apellido = new TextBox();
            container_new_telefono = new Panel();
            new_telefono = new TextBox();
            container_new_calle = new Panel();
            new_calle = new TextBox();
            container_new_usuario = new Panel();
            new_usuario = new TextBox();
            container_new_contrasena = new Panel();
            new_contrasena = new TextBox();
            container_new_contrasena2 = new Panel();
            new_contrasena2 = new TextBox();
            newaccount_submit = new PictureBox();
            container_new_altura = new Panel();
            new_altura = new TextBox();
            container_new_foto = new Panel();
            new_foto = new TextBox();
            container_new_email = new Panel();
            new_email = new TextBox();
            login_close = new PictureBox();
            newaccount_title = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            user_message = new Label();
            psw_message = new Label();
            psw_message2 = new Label();
            custom_loader = new PictureBox();
            new_nombre_error = new Label();
            new_apellido_error = new Label();
            container_new_nacimiento.SuspendLayout();
            container_new_nombre.SuspendLayout();
            container_new_apellido.SuspendLayout();
            container_new_telefono.SuspendLayout();
            container_new_calle.SuspendLayout();
            container_new_usuario.SuspendLayout();
            container_new_contrasena.SuspendLayout();
            container_new_contrasena2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newaccount_submit).BeginInit();
            container_new_altura.SuspendLayout();
            container_new_foto.SuspendLayout();
            container_new_email.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)login_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)custom_loader).BeginInit();
            SuspendLayout();
            // 
            // container_new_nacimiento
            // 
            container_new_nacimiento.BackColor = Color.FromArgb(224, 224, 224);
            container_new_nacimiento.Controls.Add(new_nacimiento);
            container_new_nacimiento.Cursor = Cursors.Hand;
            container_new_nacimiento.Location = new Point(43, 303);
            container_new_nacimiento.Name = "container_new_nacimiento";
            container_new_nacimiento.Size = new Size(180, 51);
            container_new_nacimiento.TabIndex = 14;
            container_new_nacimiento.Click += PanelClickHandler;
            // 
            // new_nacimiento
            // 
            new_nacimiento.BackColor = Color.FromArgb(224, 224, 224);
            new_nacimiento.BorderStyle = BorderStyle.None;
            new_nacimiento.Cursor = Cursors.Hand;
            new_nacimiento.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_nacimiento.Location = new Point(3, 14);
            new_nacimiento.MaxLength = 15;
            new_nacimiento.Name = "new_nacimiento";
            new_nacimiento.PlaceholderText = "Nacimiento";
            new_nacimiento.Size = new Size(174, 20);
            new_nacimiento.TabIndex = 3;
            new_nacimiento.Enter += input_Enter;
            new_nacimiento.Leave += input_Leave;
            // 
            // container_new_nombre
            // 
            container_new_nombre.BackColor = Color.FromArgb(224, 224, 224);
            container_new_nombre.Controls.Add(new_nombre);
            container_new_nombre.Cursor = Cursors.Hand;
            container_new_nombre.Location = new Point(43, 175);
            container_new_nombre.Name = "container_new_nombre";
            container_new_nombre.Size = new Size(180, 51);
            container_new_nombre.TabIndex = 12;
            container_new_nombre.Click += PanelClickHandler;
            // 
            // new_nombre
            // 
            new_nombre.BackColor = Color.FromArgb(224, 224, 224);
            new_nombre.BorderStyle = BorderStyle.None;
            new_nombre.Cursor = Cursors.Hand;
            new_nombre.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_nombre.Location = new Point(3, 14);
            new_nombre.MaxLength = 20;
            new_nombre.Name = "new_nombre";
            new_nombre.PlaceholderText = "Nombre";
            new_nombre.Size = new Size(174, 20);
            new_nombre.TabIndex = 1;
            new_nombre.TextChanged += HandleChanged;
            new_nombre.Enter += input_Enter;
            new_nombre.KeyPress += letters_KeyPress;
            new_nombre.Leave += input_Leave;
            // 
            // container_new_apellido
            // 
            container_new_apellido.BackColor = Color.FromArgb(224, 224, 224);
            container_new_apellido.Controls.Add(new_apellido);
            container_new_apellido.Cursor = Cursors.Hand;
            container_new_apellido.Location = new Point(290, 175);
            container_new_apellido.Name = "container_new_apellido";
            container_new_apellido.Size = new Size(180, 51);
            container_new_apellido.TabIndex = 13;
            container_new_apellido.Click += PanelClickHandler;
            // 
            // new_apellido
            // 
            new_apellido.BackColor = Color.FromArgb(224, 224, 224);
            new_apellido.BorderStyle = BorderStyle.None;
            new_apellido.Cursor = Cursors.Hand;
            new_apellido.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_apellido.Location = new Point(3, 14);
            new_apellido.MaxLength = 20;
            new_apellido.Name = "new_apellido";
            new_apellido.PlaceholderText = "Apellido";
            new_apellido.Size = new Size(174, 20);
            new_apellido.TabIndex = 2;
            new_apellido.TextChanged += HandleChanged;
            new_apellido.Enter += input_Enter;
            new_apellido.KeyPress += letters_KeyPress;
            new_apellido.Leave += input_Leave;
            // 
            // container_new_telefono
            // 
            container_new_telefono.BackColor = Color.FromArgb(224, 224, 224);
            container_new_telefono.Controls.Add(new_telefono);
            container_new_telefono.Cursor = Cursors.Hand;
            container_new_telefono.Location = new Point(43, 425);
            container_new_telefono.Name = "container_new_telefono";
            container_new_telefono.Size = new Size(180, 51);
            container_new_telefono.TabIndex = 16;
            container_new_telefono.Click += PanelClickHandler;
            // 
            // new_telefono
            // 
            new_telefono.BackColor = Color.FromArgb(224, 224, 224);
            new_telefono.BorderStyle = BorderStyle.None;
            new_telefono.Cursor = Cursors.Hand;
            new_telefono.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_telefono.Location = new Point(3, 14);
            new_telefono.MaxLength = 20;
            new_telefono.Name = "new_telefono";
            new_telefono.PlaceholderText = "Teléfono";
            new_telefono.Size = new Size(174, 20);
            new_telefono.TabIndex = 5;
            new_telefono.Enter += input_Enter;
            new_telefono.Leave += input_Leave;
            // 
            // container_new_calle
            // 
            container_new_calle.BackColor = Color.FromArgb(224, 224, 224);
            container_new_calle.Controls.Add(new_calle);
            container_new_calle.Cursor = Cursors.Hand;
            container_new_calle.Location = new Point(43, 548);
            container_new_calle.Name = "container_new_calle";
            container_new_calle.Size = new Size(180, 51);
            container_new_calle.TabIndex = 18;
            container_new_calle.Click += PanelClickHandler;
            // 
            // new_calle
            // 
            new_calle.BackColor = Color.FromArgb(224, 224, 224);
            new_calle.BorderStyle = BorderStyle.None;
            new_calle.Cursor = Cursors.Hand;
            new_calle.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_calle.Location = new Point(3, 14);
            new_calle.MaxLength = 20;
            new_calle.Name = "new_calle";
            new_calle.PlaceholderText = "Calle";
            new_calle.Size = new Size(174, 20);
            new_calle.TabIndex = 7;
            new_calle.Enter += input_Enter;
            new_calle.Leave += input_Leave;
            // 
            // container_new_usuario
            // 
            container_new_usuario.BackColor = Color.FromArgb(224, 224, 224);
            container_new_usuario.Controls.Add(new_usuario);
            container_new_usuario.Cursor = Cursors.Hand;
            container_new_usuario.Location = new Point(651, 175);
            container_new_usuario.Name = "container_new_usuario";
            container_new_usuario.Size = new Size(180, 51);
            container_new_usuario.TabIndex = 20;
            container_new_usuario.Click += PanelClickHandler;
            // 
            // new_usuario
            // 
            new_usuario.BackColor = Color.FromArgb(224, 224, 224);
            new_usuario.BorderStyle = BorderStyle.None;
            new_usuario.Cursor = Cursors.Hand;
            new_usuario.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_usuario.Location = new Point(3, 14);
            new_usuario.MaxLength = 15;
            new_usuario.Name = "new_usuario";
            new_usuario.PlaceholderText = "Usuario";
            new_usuario.Size = new Size(174, 20);
            new_usuario.TabIndex = 9;
            new_usuario.TextChanged += HandleChanged;
            new_usuario.Enter += input_Enter;
            new_usuario.Leave += input_Leave;
            // 
            // container_new_contrasena
            // 
            container_new_contrasena.BackColor = Color.FromArgb(224, 224, 224);
            container_new_contrasena.Controls.Add(new_contrasena);
            container_new_contrasena.Cursor = Cursors.Hand;
            container_new_contrasena.Location = new Point(651, 303);
            container_new_contrasena.Name = "container_new_contrasena";
            container_new_contrasena.Size = new Size(180, 51);
            container_new_contrasena.TabIndex = 21;
            container_new_contrasena.Click += PanelClickHandler;
            // 
            // new_contrasena
            // 
            new_contrasena.BackColor = Color.FromArgb(224, 224, 224);
            new_contrasena.BorderStyle = BorderStyle.None;
            new_contrasena.Cursor = Cursors.Hand;
            new_contrasena.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_contrasena.Location = new Point(3, 14);
            new_contrasena.MaxLength = 15;
            new_contrasena.Name = "new_contrasena";
            new_contrasena.PlaceholderText = "Contraseña";
            new_contrasena.Size = new Size(174, 20);
            new_contrasena.TabIndex = 10;
            new_contrasena.UseSystemPasswordChar = true;
            new_contrasena.TextChanged += HandleChanged;
            new_contrasena.Enter += input_Enter;
            new_contrasena.Leave += input_Leave;
            // 
            // container_new_contrasena2
            // 
            container_new_contrasena2.BackColor = Color.FromArgb(224, 224, 224);
            container_new_contrasena2.Controls.Add(new_contrasena2);
            container_new_contrasena2.Cursor = Cursors.Hand;
            container_new_contrasena2.Location = new Point(651, 425);
            container_new_contrasena2.Name = "container_new_contrasena2";
            container_new_contrasena2.Size = new Size(180, 51);
            container_new_contrasena2.TabIndex = 22;
            container_new_contrasena2.Click += PanelClickHandler;
            // 
            // new_contrasena2
            // 
            new_contrasena2.BackColor = Color.FromArgb(224, 224, 224);
            new_contrasena2.BorderStyle = BorderStyle.None;
            new_contrasena2.Cursor = Cursors.Hand;
            new_contrasena2.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_contrasena2.Location = new Point(3, 14);
            new_contrasena2.MaxLength = 15;
            new_contrasena2.Name = "new_contrasena2";
            new_contrasena2.PlaceholderText = "Repite la contraseña";
            new_contrasena2.Size = new Size(174, 20);
            new_contrasena2.TabIndex = 11;
            new_contrasena2.UseSystemPasswordChar = true;
            new_contrasena2.TextChanged += HandleChanged;
            new_contrasena2.Enter += input_Enter;
            new_contrasena2.Leave += input_Leave;
            // 
            // newaccount_submit
            // 
            newaccount_submit.BackgroundImage = Properties.Resources.agregar_usuario;
            newaccount_submit.BackgroundImageLayout = ImageLayout.Stretch;
            newaccount_submit.Cursor = Cursors.Hand;
            newaccount_submit.Location = new Point(712, 598);
            newaccount_submit.Name = "newaccount_submit";
            newaccount_submit.Size = new Size(60, 60);
            newaccount_submit.TabIndex = 24;
            newaccount_submit.TabStop = false;
            newaccount_submit.Click += newaccount_submit_Click;
            // 
            // container_new_altura
            // 
            container_new_altura.BackColor = Color.FromArgb(224, 224, 224);
            container_new_altura.Controls.Add(new_altura);
            container_new_altura.Cursor = Cursors.Hand;
            container_new_altura.Location = new Point(290, 548);
            container_new_altura.Name = "container_new_altura";
            container_new_altura.Size = new Size(180, 51);
            container_new_altura.TabIndex = 19;
            container_new_altura.Click += PanelClickHandler;
            // 
            // new_altura
            // 
            new_altura.BackColor = Color.FromArgb(224, 224, 224);
            new_altura.BorderStyle = BorderStyle.None;
            new_altura.Cursor = Cursors.Hand;
            new_altura.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_altura.Location = new Point(3, 14);
            new_altura.MaxLength = 10;
            new_altura.Name = "new_altura";
            new_altura.PlaceholderText = "Altura";
            new_altura.Size = new Size(174, 20);
            new_altura.TabIndex = 8;
            new_altura.Enter += input_Enter;
            new_altura.KeyPress += numbers_KeyPress;
            new_altura.Leave += input_Leave;
            // 
            // container_new_foto
            // 
            container_new_foto.BackColor = Color.FromArgb(224, 224, 224);
            container_new_foto.Controls.Add(new_foto);
            container_new_foto.Cursor = Cursors.Hand;
            container_new_foto.Location = new Point(290, 425);
            container_new_foto.Name = "container_new_foto";
            container_new_foto.Size = new Size(180, 51);
            container_new_foto.TabIndex = 17;
            container_new_foto.Click += PanelClickHandler;
            // 
            // new_foto
            // 
            new_foto.BackColor = Color.FromArgb(224, 224, 224);
            new_foto.BorderStyle = BorderStyle.None;
            new_foto.Cursor = Cursors.Hand;
            new_foto.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_foto.Location = new Point(3, 14);
            new_foto.MaxLength = 50;
            new_foto.Name = "new_foto";
            new_foto.PlaceholderText = "Foto";
            new_foto.Size = new Size(174, 20);
            new_foto.TabIndex = 6;
            new_foto.Enter += input_Enter;
            new_foto.Leave += input_Leave;
            // 
            // container_new_email
            // 
            container_new_email.BackColor = Color.FromArgb(224, 224, 224);
            container_new_email.Controls.Add(new_email);
            container_new_email.Cursor = Cursors.Hand;
            container_new_email.Location = new Point(290, 303);
            container_new_email.Name = "container_new_email";
            container_new_email.Size = new Size(180, 51);
            container_new_email.TabIndex = 15;
            container_new_email.Click += PanelClickHandler;
            // 
            // new_email
            // 
            new_email.BackColor = Color.FromArgb(224, 224, 224);
            new_email.BorderStyle = BorderStyle.None;
            new_email.Cursor = Cursors.Hand;
            new_email.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            new_email.Location = new Point(3, 14);
            new_email.MaxLength = 50;
            new_email.Name = "new_email";
            new_email.PlaceholderText = "Email";
            new_email.Size = new Size(174, 20);
            new_email.TabIndex = 4;
            new_email.Enter += input_Enter;
            new_email.Leave += input_Leave;
            // 
            // login_close
            // 
            login_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            login_close.BackgroundImage = Properties.Resources.tenedor_y_cuchillo_en_cruz;
            login_close.BackgroundImageLayout = ImageLayout.Stretch;
            login_close.Cursor = Cursors.Hand;
            login_close.Location = new Point(903, 12);
            login_close.Name = "login_close";
            login_close.Size = new Size(35, 35);
            login_close.TabIndex = 28;
            login_close.TabStop = false;
            login_close.Click += HandleClose;
            // 
            // newaccount_title
            // 
            newaccount_title.AutoSize = true;
            newaccount_title.BackColor = SystemColors.Control;
            newaccount_title.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point);
            newaccount_title.ForeColor = SystemColors.WindowText;
            newaccount_title.Location = new Point(43, 38);
            newaccount_title.Name = "newaccount_title";
            newaccount_title.Size = new Size(396, 54);
            newaccount_title.TabIndex = 23;
            newaccount_title.Text = "Datos de usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.comida;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(781, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.comiendo;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(445, 42);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Abyssinica SIL", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 357);
            label1.Name = "label1";
            label1.Size = new Size(128, 16);
            label1.TabIndex = 26;
            label1.Text = "Formato: dd/mm/aaaa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(227, 175);
            label2.Name = "label2";
            label2.Size = new Size(19, 25);
            label2.TabIndex = 24;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(477, 175);
            label3.Name = "label3";
            label3.Size = new Size(19, 25);
            label3.TabIndex = 25;
            label3.Text = "*";
            // 
            // user_message
            // 
            user_message.AutoSize = true;
            user_message.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            user_message.ForeColor = Color.Red;
            user_message.Location = new Point(625, 229);
            user_message.Name = "user_message";
            user_message.Size = new Size(248, 42);
            user_message.TabIndex = 36;
            user_message.Text = "Sólo se admiten letras y números.\r\nMínimo 5 caracteres.";
            user_message.TextAlign = ContentAlignment.MiddleCenter;
            user_message.Visible = false;
            // 
            // psw_message
            // 
            psw_message.AutoSize = true;
            psw_message.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            psw_message.ForeColor = Color.Red;
            psw_message.Location = new Point(648, 357);
            psw_message.Name = "psw_message";
            psw_message.Size = new Size(188, 42);
            psw_message.TabIndex = 37;
            psw_message.Text = "Letras, números, '!' y '_'.\r\nMínimo 5 caracteres.";
            psw_message.TextAlign = ContentAlignment.MiddleCenter;
            psw_message.Visible = false;
            // 
            // psw_message2
            // 
            psw_message2.AutoSize = true;
            psw_message2.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            psw_message2.ForeColor = Color.Red;
            psw_message2.Location = new Point(625, 478);
            psw_message2.Name = "psw_message2";
            psw_message2.Size = new Size(231, 21);
            psw_message2.TabIndex = 38;
            psw_message2.Text = "Las contraseñas deben coincidir";
            psw_message2.TextAlign = ContentAlignment.MiddleCenter;
            psw_message2.Visible = false;
            // 
            // custom_loader
            // 
            custom_loader.BackgroundImageLayout = ImageLayout.Stretch;
            custom_loader.Image = Properties.Resources.loader;
            custom_loader.Location = new Point(718, 532);
            custom_loader.Name = "custom_loader";
            custom_loader.Size = new Size(50, 50);
            custom_loader.SizeMode = PictureBoxSizeMode.StretchImage;
            custom_loader.TabIndex = 39;
            custom_loader.TabStop = false;
            custom_loader.Visible = false;
            // 
            // new_nombre_error
            // 
            new_nombre_error.AutoSize = true;
            new_nombre_error.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            new_nombre_error.ForeColor = Color.Red;
            new_nombre_error.Location = new Point(58, 229);
            new_nombre_error.Name = "new_nombre_error";
            new_nombre_error.Size = new Size(126, 21);
            new_nombre_error.TabIndex = 40;
            new_nombre_error.Text = "Mínimo 3 letras.";
            new_nombre_error.TextAlign = ContentAlignment.MiddleCenter;
            new_nombre_error.Visible = false;
            // 
            // new_apellido_error
            // 
            new_apellido_error.AutoSize = true;
            new_apellido_error.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            new_apellido_error.ForeColor = Color.Red;
            new_apellido_error.Location = new Point(311, 229);
            new_apellido_error.Name = "new_apellido_error";
            new_apellido_error.Size = new Size(121, 21);
            new_apellido_error.TabIndex = 41;
            new_apellido_error.Text = "Mínimo 3 letras";
            new_apellido_error.TextAlign = ContentAlignment.MiddleCenter;
            new_apellido_error.Visible = false;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(950, 720);
            Controls.Add(new_apellido_error);
            Controls.Add(new_nombre_error);
            Controls.Add(custom_loader);
            Controls.Add(psw_message2);
            Controls.Add(psw_message);
            Controls.Add(user_message);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(newaccount_title);
            Controls.Add(login_close);
            Controls.Add(container_new_email);
            Controls.Add(container_new_foto);
            Controls.Add(container_new_altura);
            Controls.Add(newaccount_submit);
            Controls.Add(container_new_contrasena2);
            Controls.Add(container_new_contrasena);
            Controls.Add(container_new_usuario);
            Controls.Add(container_new_calle);
            Controls.Add(container_new_telefono);
            Controls.Add(container_new_apellido);
            Controls.Add(container_new_nombre);
            Controls.Add(container_new_nacimiento);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewAccount";
            FormClosed += Account_FormClosed;
            Load += Account_Load;
            container_new_nacimiento.ResumeLayout(false);
            container_new_nacimiento.PerformLayout();
            container_new_nombre.ResumeLayout(false);
            container_new_nombre.PerformLayout();
            container_new_apellido.ResumeLayout(false);
            container_new_apellido.PerformLayout();
            container_new_telefono.ResumeLayout(false);
            container_new_telefono.PerformLayout();
            container_new_calle.ResumeLayout(false);
            container_new_calle.PerformLayout();
            container_new_usuario.ResumeLayout(false);
            container_new_usuario.PerformLayout();
            container_new_contrasena.ResumeLayout(false);
            container_new_contrasena.PerformLayout();
            container_new_contrasena2.ResumeLayout(false);
            container_new_contrasena2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)newaccount_submit).EndInit();
            container_new_altura.ResumeLayout(false);
            container_new_altura.PerformLayout();
            container_new_foto.ResumeLayout(false);
            container_new_foto.PerformLayout();
            container_new_email.ResumeLayout(false);
            container_new_email.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)login_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)custom_loader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel psw_container;
        private TextBox login_input_psw;
        private Panel container_new_nacimiento;
        private TextBox new_nacimiento;
        private Panel container_new_nombre;
        private TextBox new_nombre;
        private Panel container_new_apellido;
        private TextBox new_apellido;
        private Panel container_new_telefono;
        private TextBox new_telefono;
        private Panel container_new_calle;
        private TextBox new_calle;
        private Panel container_new_usuario;
        private TextBox new_usuario;
        private Panel container_new_contrasena;
        private TextBox new_contrasena;
        private Panel container_new_contrasena2;
        private TextBox new_contrasena2;
        private PictureBox newaccount_submit;
        private Panel container_new_altura;
        private TextBox new_altura;
        private Panel container_new_foto;
        private TextBox new_foto;
        private Panel container_new_email;
        private TextBox new_email;
        private PictureBox login_close;
        private Label newaccount_title;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label user_message;
        private Label psw_message;
        private Label psw_message2;
        private PictureBox custom_loader;
        private Label new_nombre_error;
        private Label new_apellido_error;
    }
}