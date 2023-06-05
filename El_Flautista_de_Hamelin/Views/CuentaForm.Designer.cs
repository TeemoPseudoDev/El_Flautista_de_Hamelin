namespace El_Flautista_de_Hamelin.Views
{
    partial class CuentaForm
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
            label_nacimiento = new Label();
            new_nacimiento = new TextBox();
            container_new_nombre = new Panel();
            label_nombre = new Label();
            new_nombre = new TextBox();
            container_new_apellido = new Panel();
            label_apellido = new Label();
            new_apellido = new TextBox();
            container_new_telefono = new Panel();
            label_telefono = new Label();
            new_telefono = new TextBox();
            container_new_calle = new Panel();
            label_calle = new Label();
            new_calle = new TextBox();
            container_new_usuario = new Panel();
            label_usuario = new Label();
            new_usuario = new TextBox();
            container_new_contrasena = new Panel();
            label_contrasena = new Label();
            new_contrasena = new TextBox();
            container_new_contrasena2 = new Panel();
            label_contrasena2 = new Label();
            new_contrasena2 = new TextBox();
            newaccount_submit = new PictureBox();
            container_new_altura = new Panel();
            label_altura = new Label();
            new_altura = new TextBox();
            container_new_foto = new Panel();
            label_foto = new Label();
            new_foto = new TextBox();
            container_new_email = new Panel();
            label_email = new Label();
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            new_nacimiento_error = new Label();
            database_response_error = new Label();
            database_response_success = new Label();
            label8 = new Label();
            label9 = new Label();
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
            container_new_nacimiento.BackColor = SystemColors.ScrollBar;
            container_new_nacimiento.Controls.Add(label_nacimiento);
            container_new_nacimiento.Controls.Add(new_nacimiento);
            container_new_nacimiento.Cursor = Cursors.Hand;
            container_new_nacimiento.Location = new Point(74, 302);
            container_new_nacimiento.Name = "container_new_nacimiento";
            container_new_nacimiento.Size = new Size(180, 55);
            container_new_nacimiento.TabIndex = 14;
            container_new_nacimiento.Click += PanelClickHandler;
            // 
            // label_nacimiento
            // 
            label_nacimiento.AutoSize = true;
            label_nacimiento.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_nacimiento.ForeColor = SystemColors.WindowText;
            label_nacimiento.Location = new Point(18, 18);
            label_nacimiento.Name = "label_nacimiento";
            label_nacimiento.Size = new Size(88, 21);
            label_nacimiento.TabIndex = 51;
            label_nacimiento.Text = "Nacimiento";
            label_nacimiento.Click += LabelClickHandler;
            // 
            // new_nacimiento
            // 
            new_nacimiento.BackColor = SystemColors.ScrollBar;
            new_nacimiento.BorderStyle = BorderStyle.None;
            new_nacimiento.Cursor = Cursors.Hand;
            new_nacimiento.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_nacimiento.Location = new Point(3, 19);
            new_nacimiento.MaxLength = 10;
            new_nacimiento.Name = "new_nacimiento";
            new_nacimiento.Size = new Size(174, 20);
            new_nacimiento.TabIndex = 3;
            new_nacimiento.TextChanged += HandleChanged;
            new_nacimiento.Enter += input_Enter;
            new_nacimiento.KeyPress += inputs_KeyPress;
            new_nacimiento.Leave += input_Leave;
            // 
            // container_new_nombre
            // 
            container_new_nombre.BackColor = SystemColors.ScrollBar;
            container_new_nombre.Controls.Add(label_nombre);
            container_new_nombre.Controls.Add(new_nombre);
            container_new_nombre.Cursor = Cursors.Hand;
            container_new_nombre.Location = new Point(74, 174);
            container_new_nombre.Name = "container_new_nombre";
            container_new_nombre.Size = new Size(180, 55);
            container_new_nombre.TabIndex = 12;
            container_new_nombre.Click += PanelClickHandler;
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_nombre.ForeColor = SystemColors.WindowText;
            label_nombre.Location = new Point(18, 18);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(63, 21);
            label_nombre.TabIndex = 50;
            label_nombre.Text = "Nombre";
            label_nombre.Click += LabelClickHandler;
            // 
            // new_nombre
            // 
            new_nombre.BackColor = SystemColors.ScrollBar;
            new_nombre.BorderStyle = BorderStyle.None;
            new_nombre.Cursor = Cursors.Hand;
            new_nombre.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_nombre.ForeColor = SystemColors.InactiveCaptionText;
            new_nombre.Location = new Point(3, 19);
            new_nombre.MaxLength = 20;
            new_nombre.Name = "new_nombre";
            new_nombre.Size = new Size(174, 20);
            new_nombre.TabIndex = 1;
            new_nombre.TextChanged += HandleChanged;
            new_nombre.Enter += input_Enter;
            new_nombre.KeyPress += inputs_KeyPress;
            new_nombre.Leave += input_Leave;
            // 
            // container_new_apellido
            // 
            container_new_apellido.BackColor = SystemColors.ScrollBar;
            container_new_apellido.Controls.Add(label_apellido);
            container_new_apellido.Controls.Add(new_apellido);
            container_new_apellido.Cursor = Cursors.Hand;
            container_new_apellido.Location = new Point(321, 174);
            container_new_apellido.Name = "container_new_apellido";
            container_new_apellido.Size = new Size(180, 55);
            container_new_apellido.TabIndex = 13;
            container_new_apellido.Click += PanelClickHandler;
            // 
            // label_apellido
            // 
            label_apellido.AutoSize = true;
            label_apellido.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_apellido.ForeColor = SystemColors.WindowText;
            label_apellido.Location = new Point(18, 18);
            label_apellido.Name = "label_apellido";
            label_apellido.Size = new Size(64, 21);
            label_apellido.TabIndex = 51;
            label_apellido.Text = "Apellido";
            label_apellido.Click += LabelClickHandler;
            // 
            // new_apellido
            // 
            new_apellido.BackColor = SystemColors.ScrollBar;
            new_apellido.BorderStyle = BorderStyle.None;
            new_apellido.Cursor = Cursors.Hand;
            new_apellido.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_apellido.Location = new Point(3, 19);
            new_apellido.MaxLength = 20;
            new_apellido.Name = "new_apellido";
            new_apellido.Size = new Size(174, 20);
            new_apellido.TabIndex = 2;
            new_apellido.TextChanged += HandleChanged;
            new_apellido.Enter += input_Enter;
            new_apellido.KeyPress += inputs_KeyPress;
            new_apellido.Leave += input_Leave;
            // 
            // container_new_telefono
            // 
            container_new_telefono.BackColor = SystemColors.ScrollBar;
            container_new_telefono.Controls.Add(label_telefono);
            container_new_telefono.Controls.Add(new_telefono);
            container_new_telefono.Cursor = Cursors.Hand;
            container_new_telefono.Location = new Point(74, 430);
            container_new_telefono.Name = "container_new_telefono";
            container_new_telefono.Size = new Size(180, 55);
            container_new_telefono.TabIndex = 16;
            container_new_telefono.Click += PanelClickHandler;
            // 
            // label_telefono
            // 
            label_telefono.AutoSize = true;
            label_telefono.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_telefono.ForeColor = SystemColors.WindowText;
            label_telefono.Location = new Point(18, 18);
            label_telefono.Name = "label_telefono";
            label_telefono.Size = new Size(67, 21);
            label_telefono.TabIndex = 52;
            label_telefono.Text = "Teléfono";
            label_telefono.Click += LabelClickHandler;
            // 
            // new_telefono
            // 
            new_telefono.BackColor = SystemColors.ScrollBar;
            new_telefono.BorderStyle = BorderStyle.None;
            new_telefono.Cursor = Cursors.Hand;
            new_telefono.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_telefono.Location = new Point(3, 19);
            new_telefono.MaxLength = 20;
            new_telefono.Name = "new_telefono";
            new_telefono.Size = new Size(174, 20);
            new_telefono.TabIndex = 5;
            new_telefono.Enter += input_Enter;
            new_telefono.Leave += input_Leave;
            // 
            // container_new_calle
            // 
            container_new_calle.BackColor = SystemColors.ScrollBar;
            container_new_calle.Controls.Add(label_calle);
            container_new_calle.Controls.Add(new_calle);
            container_new_calle.Cursor = Cursors.Hand;
            container_new_calle.Location = new Point(74, 558);
            container_new_calle.Name = "container_new_calle";
            container_new_calle.Size = new Size(180, 55);
            container_new_calle.TabIndex = 18;
            container_new_calle.Click += PanelClickHandler;
            // 
            // label_calle
            // 
            label_calle.AutoSize = true;
            label_calle.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_calle.ForeColor = SystemColors.WindowText;
            label_calle.Location = new Point(18, 18);
            label_calle.Name = "label_calle";
            label_calle.Size = new Size(42, 21);
            label_calle.TabIndex = 54;
            label_calle.Text = "Calle";
            label_calle.Click += LabelClickHandler;
            // 
            // new_calle
            // 
            new_calle.BackColor = SystemColors.ScrollBar;
            new_calle.BorderStyle = BorderStyle.None;
            new_calle.Cursor = Cursors.Hand;
            new_calle.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_calle.Location = new Point(3, 19);
            new_calle.MaxLength = 20;
            new_calle.Name = "new_calle";
            new_calle.Size = new Size(174, 20);
            new_calle.TabIndex = 7;
            new_calle.Enter += input_Enter;
            new_calle.Leave += input_Leave;
            // 
            // container_new_usuario
            // 
            container_new_usuario.BackColor = SystemColors.ScrollBar;
            container_new_usuario.Controls.Add(label_usuario);
            container_new_usuario.Controls.Add(new_usuario);
            container_new_usuario.Cursor = Cursors.Hand;
            container_new_usuario.Location = new Point(682, 174);
            container_new_usuario.Name = "container_new_usuario";
            container_new_usuario.Size = new Size(180, 55);
            container_new_usuario.TabIndex = 20;
            container_new_usuario.Click += PanelClickHandler;
            // 
            // label_usuario
            // 
            label_usuario.AutoSize = true;
            label_usuario.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_usuario.ForeColor = SystemColors.WindowText;
            label_usuario.Location = new Point(18, 18);
            label_usuario.Name = "label_usuario";
            label_usuario.Size = new Size(63, 21);
            label_usuario.TabIndex = 52;
            label_usuario.Text = "Usuario";
            label_usuario.Click += LabelClickHandler;
            // 
            // new_usuario
            // 
            new_usuario.BackColor = SystemColors.ScrollBar;
            new_usuario.BorderStyle = BorderStyle.None;
            new_usuario.Cursor = Cursors.Hand;
            new_usuario.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_usuario.Location = new Point(3, 19);
            new_usuario.MaxLength = 15;
            new_usuario.Name = "new_usuario";
            new_usuario.Size = new Size(174, 20);
            new_usuario.TabIndex = 9;
            new_usuario.Enter += input_Enter;
            new_usuario.KeyPress += inputs_KeyPress;
            new_usuario.Leave += input_Leave;
            // 
            // container_new_contrasena
            // 
            container_new_contrasena.BackColor = SystemColors.ScrollBar;
            container_new_contrasena.Controls.Add(label_contrasena);
            container_new_contrasena.Controls.Add(new_contrasena);
            container_new_contrasena.Cursor = Cursors.Hand;
            container_new_contrasena.Location = new Point(682, 302);
            container_new_contrasena.Name = "container_new_contrasena";
            container_new_contrasena.Size = new Size(180, 55);
            container_new_contrasena.TabIndex = 21;
            container_new_contrasena.Click += PanelClickHandler;
            // 
            // label_contrasena
            // 
            label_contrasena.AutoSize = true;
            label_contrasena.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_contrasena.ForeColor = SystemColors.WindowText;
            label_contrasena.Location = new Point(18, 18);
            label_contrasena.Name = "label_contrasena";
            label_contrasena.Size = new Size(85, 21);
            label_contrasena.TabIndex = 53;
            label_contrasena.Text = "Contraseña";
            label_contrasena.Click += LabelClickHandler;
            // 
            // new_contrasena
            // 
            new_contrasena.BackColor = SystemColors.ScrollBar;
            new_contrasena.BorderStyle = BorderStyle.None;
            new_contrasena.Cursor = Cursors.Hand;
            new_contrasena.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_contrasena.Location = new Point(3, 19);
            new_contrasena.MaxLength = 15;
            new_contrasena.Name = "new_contrasena";
            new_contrasena.Size = new Size(174, 20);
            new_contrasena.TabIndex = 10;
            new_contrasena.UseSystemPasswordChar = true;
            new_contrasena.TextChanged += HandleChanged;
            new_contrasena.Enter += input_Enter;
            new_contrasena.KeyPress += inputs_KeyPress;
            new_contrasena.Leave += input_Leave;
            // 
            // container_new_contrasena2
            // 
            container_new_contrasena2.BackColor = SystemColors.ScrollBar;
            container_new_contrasena2.Controls.Add(label_contrasena2);
            container_new_contrasena2.Controls.Add(new_contrasena2);
            container_new_contrasena2.Cursor = Cursors.Hand;
            container_new_contrasena2.Location = new Point(682, 430);
            container_new_contrasena2.Name = "container_new_contrasena2";
            container_new_contrasena2.Size = new Size(180, 55);
            container_new_contrasena2.TabIndex = 22;
            container_new_contrasena2.Click += PanelClickHandler;
            // 
            // label_contrasena2
            // 
            label_contrasena2.AutoSize = true;
            label_contrasena2.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_contrasena2.ForeColor = SystemColors.WindowText;
            label_contrasena2.Location = new Point(18, 18);
            label_contrasena2.Name = "label_contrasena2";
            label_contrasena2.Size = new Size(151, 21);
            label_contrasena2.TabIndex = 54;
            label_contrasena2.Text = "Repite la contraseña";
            label_contrasena2.Click += LabelClickHandler;
            // 
            // new_contrasena2
            // 
            new_contrasena2.BackColor = SystemColors.ScrollBar;
            new_contrasena2.BorderStyle = BorderStyle.None;
            new_contrasena2.Cursor = Cursors.Hand;
            new_contrasena2.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_contrasena2.Location = new Point(3, 19);
            new_contrasena2.MaxLength = 15;
            new_contrasena2.Name = "new_contrasena2";
            new_contrasena2.Size = new Size(174, 20);
            new_contrasena2.TabIndex = 11;
            new_contrasena2.UseSystemPasswordChar = true;
            new_contrasena2.TextChanged += HandleChanged;
            new_contrasena2.Enter += input_Enter;
            new_contrasena2.KeyPress += inputs_KeyPress;
            new_contrasena2.Leave += input_Leave;
            // 
            // newaccount_submit
            // 
            newaccount_submit.BackgroundImage = Properties.Resources.agregar_usuario;
            newaccount_submit.BackgroundImageLayout = ImageLayout.Stretch;
            newaccount_submit.Cursor = Cursors.Hand;
            newaccount_submit.Location = new Point(743, 598);
            newaccount_submit.Name = "newaccount_submit";
            newaccount_submit.Size = new Size(60, 60);
            newaccount_submit.TabIndex = 24;
            newaccount_submit.TabStop = false;
            newaccount_submit.Click += newaccount_submit_Click;
            // 
            // container_new_altura
            // 
            container_new_altura.BackColor = SystemColors.ScrollBar;
            container_new_altura.Controls.Add(label_altura);
            container_new_altura.Controls.Add(new_altura);
            container_new_altura.Cursor = Cursors.Hand;
            container_new_altura.Location = new Point(321, 558);
            container_new_altura.Name = "container_new_altura";
            container_new_altura.Size = new Size(180, 55);
            container_new_altura.TabIndex = 19;
            container_new_altura.Click += PanelClickHandler;
            // 
            // label_altura
            // 
            label_altura.AutoSize = true;
            label_altura.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_altura.ForeColor = SystemColors.WindowText;
            label_altura.Location = new Point(18, 18);
            label_altura.Name = "label_altura";
            label_altura.Size = new Size(52, 21);
            label_altura.TabIndex = 55;
            label_altura.Text = "Altura";
            label_altura.Click += LabelClickHandler;
            // 
            // new_altura
            // 
            new_altura.BackColor = SystemColors.ScrollBar;
            new_altura.BorderStyle = BorderStyle.None;
            new_altura.Cursor = Cursors.Hand;
            new_altura.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_altura.Location = new Point(3, 19);
            new_altura.MaxLength = 10;
            new_altura.Name = "new_altura";
            new_altura.Size = new Size(174, 20);
            new_altura.TabIndex = 8;
            new_altura.Enter += input_Enter;
            new_altura.KeyPress += inputs_KeyPress;
            new_altura.Leave += input_Leave;
            // 
            // container_new_foto
            // 
            container_new_foto.BackColor = SystemColors.ScrollBar;
            container_new_foto.Controls.Add(label_foto);
            container_new_foto.Controls.Add(new_foto);
            container_new_foto.Cursor = Cursors.Hand;
            container_new_foto.Location = new Point(321, 430);
            container_new_foto.Name = "container_new_foto";
            container_new_foto.Size = new Size(180, 55);
            container_new_foto.TabIndex = 17;
            container_new_foto.Click += PanelClickHandler;
            // 
            // label_foto
            // 
            label_foto.AutoSize = true;
            label_foto.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_foto.ForeColor = SystemColors.WindowText;
            label_foto.Location = new Point(18, 18);
            label_foto.Name = "label_foto";
            label_foto.Size = new Size(39, 21);
            label_foto.TabIndex = 53;
            label_foto.Text = "Foto";
            label_foto.Click += LabelClickHandler;
            // 
            // new_foto
            // 
            new_foto.BackColor = SystemColors.ScrollBar;
            new_foto.BorderStyle = BorderStyle.None;
            new_foto.Cursor = Cursors.Hand;
            new_foto.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_foto.Location = new Point(3, 19);
            new_foto.MaxLength = 50;
            new_foto.Name = "new_foto";
            new_foto.Size = new Size(174, 20);
            new_foto.TabIndex = 6;
            new_foto.Enter += input_Enter;
            new_foto.Leave += input_Leave;
            // 
            // container_new_email
            // 
            container_new_email.BackColor = SystemColors.ScrollBar;
            container_new_email.Controls.Add(label_email);
            container_new_email.Controls.Add(new_email);
            container_new_email.Cursor = Cursors.Hand;
            container_new_email.Location = new Point(321, 302);
            container_new_email.Name = "container_new_email";
            container_new_email.Size = new Size(180, 55);
            container_new_email.TabIndex = 15;
            container_new_email.Click += PanelClickHandler;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_email.ForeColor = SystemColors.WindowText;
            label_email.Location = new Point(18, 18);
            label_email.Name = "label_email";
            label_email.Size = new Size(49, 21);
            label_email.TabIndex = 52;
            label_email.Text = "Email";
            label_email.Click += LabelClickHandler;
            // 
            // new_email
            // 
            new_email.BackColor = SystemColors.ScrollBar;
            new_email.BorderStyle = BorderStyle.None;
            new_email.Cursor = Cursors.Hand;
            new_email.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_email.Location = new Point(3, 19);
            new_email.MaxLength = 50;
            new_email.Name = "new_email";
            new_email.Size = new Size(174, 20);
            new_email.TabIndex = 4;
            new_email.Enter += input_Enter;
            new_email.Leave += input_Leave;
            // 
            // login_close
            // 
            login_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            login_close.BackgroundImage = Properties.Resources.atras;
            login_close.BackgroundImageLayout = ImageLayout.Stretch;
            login_close.Cursor = Cursors.Hand;
            login_close.Location = new Point(15, 15);
            login_close.Name = "login_close";
            login_close.Size = new Size(45, 45);
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
            newaccount_title.Location = new Point(270, 33);
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
            pictureBox1.Location = new Point(812, 124);
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
            pictureBox3.Location = new Point(672, 37);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Abyssinica SIL", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(62, 284);
            label1.Name = "label1";
            label1.Size = new Size(205, 16);
            label1.TabIndex = 26;
            label1.Text = "Formato: dd/mm/aaaa (1940 a 2005)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(258, 175);
            label2.Name = "label2";
            label2.Size = new Size(19, 25);
            label2.TabIndex = 24;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(508, 175);
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
            user_message.Location = new Point(656, 232);
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
            psw_message.Location = new Point(679, 360);
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
            psw_message2.Location = new Point(656, 488);
            psw_message2.Name = "psw_message2";
            psw_message2.Size = new Size(236, 21);
            psw_message2.TabIndex = 38;
            psw_message2.Text = "Las contraseñas deben coincidir.";
            psw_message2.TextAlign = ContentAlignment.MiddleCenter;
            psw_message2.Visible = false;
            // 
            // custom_loader
            // 
            custom_loader.BackgroundImageLayout = ImageLayout.Stretch;
            custom_loader.Image = Properties.Resources.loader;
            custom_loader.Location = new Point(749, 532);
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
            new_nombre_error.Location = new Point(77, 232);
            new_nombre_error.Name = "new_nombre_error";
            new_nombre_error.Size = new Size(168, 42);
            new_nombre_error.TabIndex = 40;
            new_nombre_error.Text = "Sólo letras y espacios.\r\nAl menos 3 caracteres.";
            new_nombre_error.TextAlign = ContentAlignment.MiddleCenter;
            new_nombre_error.Visible = false;
            // 
            // new_apellido_error
            // 
            new_apellido_error.AutoSize = true;
            new_apellido_error.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            new_apellido_error.ForeColor = Color.Red;
            new_apellido_error.Location = new Point(324, 232);
            new_apellido_error.Name = "new_apellido_error";
            new_apellido_error.Size = new Size(168, 42);
            new_apellido_error.TabIndex = 41;
            new_apellido_error.Text = "Sólo letras y espacios.\r\nAl menos 3 caracteres.";
            new_apellido_error.TextAlign = ContentAlignment.MiddleCenter;
            new_apellido_error.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(868, 175);
            label4.Name = "label4";
            label4.Size = new Size(19, 25);
            label4.TabIndex = 42;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(865, 303);
            label5.Name = "label5";
            label5.Size = new Size(19, 25);
            label5.TabIndex = 43;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(865, 425);
            label6.Name = "label6";
            label6.Size = new Size(19, 25);
            label6.TabIndex = 44;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Abyssinica SIL", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(74, 125);
            label7.Name = "label7";
            label7.Size = new Size(138, 16);
            label7.TabIndex = 45;
            label7.Text = "(*) campos obligatorios";
            // 
            // new_nacimiento_error
            // 
            new_nacimiento_error.AutoSize = true;
            new_nacimiento_error.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            new_nacimiento_error.ForeColor = Color.Red;
            new_nacimiento_error.Location = new Point(89, 360);
            new_nacimiento_error.Name = "new_nacimiento_error";
            new_nacimiento_error.Size = new Size(146, 21);
            new_nacimiento_error.TabIndex = 47;
            new_nacimiento_error.Text = "Formato incorrecto.";
            new_nacimiento_error.TextAlign = ContentAlignment.MiddleCenter;
            new_nacimiento_error.Visible = false;
            // 
            // database_response_error
            // 
            database_response_error.AutoSize = true;
            database_response_error.Font = new Font("Abyssinica SIL", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            database_response_error.ForeColor = Color.Red;
            database_response_error.Location = new Point(699, 548);
            database_response_error.Name = "database_response_error";
            database_response_error.Size = new Size(151, 21);
            database_response_error.TabIndex = 48;
            database_response_error.Text = "La cuenta ya existe.";
            database_response_error.TextAlign = ContentAlignment.MiddleCenter;
            database_response_error.Visible = false;
            // 
            // database_response_success
            // 
            database_response_success.AutoSize = true;
            database_response_success.Font = new Font("Abyssinica SIL", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            database_response_success.ForeColor = Color.Green;
            database_response_success.Location = new Point(652, 548);
            database_response_success.Name = "database_response_success";
            database_response_success.Size = new Size(252, 26);
            database_response_success.TabIndex = 49;
            database_response_success.Text = "¡Usuario creado con éxito!";
            database_response_success.TextAlign = ContentAlignment.MiddleCenter;
            database_response_success.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 63);
            label8.Name = "label8";
            label8.Size = new Size(66, 24);
            label8.TabIndex = 50;
            label8.Text = "Volver";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(740, 661);
            label9.Name = "label9";
            label9.Size = new Size(64, 24);
            label9.TabIndex = 51;
            label9.Text = "Crear";
            // 
            // CuentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(950, 720);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(database_response_success);
            Controls.Add(database_response_error);
            Controls.Add(new_nacimiento_error);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
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
            Name = "CuentaForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewAccount";
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label new_nacimiento_error;
        private Label database_response_error;
        private Label database_response_success;
        private Label label_nombre;
        private Label label_apellido;
        private Label label_nacimiento;
        private Label label_telefono;
        private Label label_foto;
        private Label label_email;
        private Label label_calle;
        private Label label_usuario;
        private Label label_contrasena;
        private Label label_contrasena2;
        private Label label_altura;
        private Label label8;
        private Label label9;
    }
}