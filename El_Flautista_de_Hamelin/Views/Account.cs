using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Flautista_de_Hamelin.Views
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            this.MouseDown += AccountForm_MouseDown;
            this.MouseMove += AccountForm_MouseMove;
            this.MouseUp += AccountForm_MouseUp;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void AccountForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AccountForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void AccountForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        // Definir la función controladora para manipular el Focus de los hijos
        private void PanelClickHandler(object sender, EventArgs e)
        {

            Panel panel = (Panel)sender;
            panel.Controls[0].Focus();

        }

        private void input_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            Panel panel = (Panel)textBox.Parent;

            panel.BackColor = SystemColors.Control;
            panel.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = SystemColors.Control;
        }
        private void input_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            Panel panel = (Panel)textBox.Parent;

            panel.BackColor = Color.FromArgb(224, 224, 224);
            panel.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void letters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void HandleChanged(object sender, EventArgs e)
        {

            if (sender == new_nombre)
            {
                string texto = new_nombre.Text;
                string patron = @"^[A-Za-z]{3,20}$";
                if (!Regex.IsMatch(texto, patron))
                {
                    new_nombre_error.Text = "Mínimo 3 letras.";
                    new_nombre_error.Visible = true;
                }
                else
                {
                    new_nombre_error.Text = "";
                    new_nombre_error.Visible = false;
                }

            }

            if (sender == new_apellido)
            {
                string texto = new_apellido.Text;
                string patron = @"^[A-Za-z]{3,20}$";

                if (!Regex.IsMatch(texto, patron))
                {
                    new_apellido_error.Text = "Mínimo 3 letras.";
                    new_apellido_error.Visible = true;
                }
                else
                {
                    new_apellido_error.Text = "";
                    new_apellido_error.Visible = false;
                }

            }
            if (sender == new_usuario)
            {
                string texto = new_usuario.Text;
                string patron = @"^[A-Za-z1-9]{5,15}$";
                if (!Regex.IsMatch(texto, patron))
                {
                    user_message.Text = "Sólo se admiten letras y números.\r\nMínimo 5 caracteres.";
                    user_message.Visible = true;
                }
                else
                {
                    user_message.Text = "";
                    user_message.Visible = false;
                }

            }

            if (sender == new_contrasena)
            {
                string texto = new_contrasena.Text;
                string patron = @"^[a-zA-Z0-9!_]{5,15}$";

                if (!Regex.IsMatch(texto, patron))
                {
                    psw_message.Text = "Letras, números, '!' y '_'\r\n.Mínimo 5 caracteres.";
                    psw_message.Visible = true;
                }
                else
                {
                    psw_message.Text = "";
                    psw_message.Visible = false;
                }

            }

            if (sender == new_contrasena2)
            {
                if (new_contrasena2.Text != new_contrasena.Text)
                {
                    psw_message2.Text = "Las contraseñas deben coincidir";
                    psw_message2.Visible = true;
                }
                else
                {
                    psw_message2.Text = "";
                    psw_message2.Visible = false;
                }

            }


        }


        private void newaccount_submit_Click(object sender, EventArgs e)
        {
            custom_loader.Visible = true;

            string nombre = new_nombre.Text;
            string apellido = new_apellido.Text;


            string patron = @"^(0[1-9]|1[0-9]|2[0-9]|3[01])/(0[1-9]|1[0-2])/((19|20)\d{2})$";
            if (new_nacimiento.Text != "" && Regex.IsMatch(new_nacimiento.Text, patron))
            {
                string[] partes = new_nacimiento.Text.Split('/');
                DateTime fecha = new DateTime(int.Parse(partes[2]), int.Parse(partes[1]), int.Parse(partes[0]));
            }

            string email = new_email.Text;
            string telefono = new_telefono.Text;
            string foto = new_foto.Text;
            string calle = new_calle.Text;
            string altura = new_altura.Text;

            /*if (psw_message.Text == "" || user_message.Text == "")
            {
                general_message_error.Text = "Usuario y/o contraseña con errores";
                general_message_error.Visible = true;
                return;
            }*/

            //ingresar usuario en la base de datos a través del controlador
            //obtener el id resultante del insert para agregar la cuenta

        }

        private void HandleClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = this.Owner as LoginForm;

            loginForm.Show();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            this.Select();
        }
    }
}
