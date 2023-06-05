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
using El_Flautista_de_Hamelin.Controllers;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace El_Flautista_de_Hamelin.Views
{
    public partial class CuentaForm : Form
    {

        private CuentaController controller;
        public CuentaForm()
        {
            InitializeComponent();
            controller = new CuentaController();
            this.MouseDown += AccountForm_MouseDown;
            this.MouseMove += AccountForm_MouseMove;
            this.MouseUp += AccountForm_MouseUp;
            RedondearPanel(container_new_nombre, 20);
            RedondearPanel(container_new_apellido, 20);
            RedondearPanel(container_new_nacimiento, 20);
            RedondearPanel(container_new_email, 20);
            RedondearPanel(container_new_telefono, 20);
            RedondearPanel(container_new_foto, 20);
            RedondearPanel(container_new_calle, 20);
            RedondearPanel(container_new_altura, 20);
            RedondearPanel(container_new_usuario, 20);
            RedondearPanel(container_new_contrasena, 20);
            RedondearPanel(container_new_contrasena2, 20);

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
            TextBox textBox = null;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    textBox = (TextBox)control;
                    break;
                }
            }

            if (textBox != null)
            {
                textBox.Focus();
            }
        }
        private void LabelClickHandler(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Panel panel = label.Parent as Panel;
            TextBox textBox = null;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    textBox = (TextBox)control;
                    break;
                }
            }

            if (textBox != null)
            {
                textBox.Focus();
            }
        }

        private void input_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Panel panel = (Panel)textBox.Parent;

            panel.BackColor = SystemColors.ControlLightLight;
            //panel.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = SystemColors.ControlLightLight;


            Label label = null;
            foreach (Control control in panel.Controls)
            {
                if (control is Label)
                {
                    label = (Label)control;
                    break;
                }
            }

            if (label != null)
            {
                LabelAnimationToTop(label);
            }
        }

        private void LabelAnimationToTop(Label label)
        {
            if (label.Left == 2 || label.Top == 2) return;

            label.Font = new Font(label.Font.FontFamily, 9, label.Font.Style);


            int originalX = label.Left;
            int originalY = label.Top;


            int targetX = 2;
            int targetY = 2;

            int step = 8; // Cantidad de píxeles para cada paso de la animación
            int interval = 2; // Intervalo de tiempo entre cada paso de la animación (en milisegundos)

            int deltaX = (targetX - label.Left) / step;
            int deltaY = (targetY - label.Top) / step;

            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = interval;

            animationTimer.Tick += (s, args) =>
            {
                if (label.Left != targetX)
                {
                    label.Left += deltaX;
                }

                if (label.Top != targetY)
                {
                    label.Top += deltaY;
                }

                if (label.Left == targetX && label.Top == targetY)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                    animationTimer = null;
                }
            };

            animationTimer.Start();

            // Guardar la posición original en la propiedad Tag del Label
            label.Tag = new Point(originalX, originalY);
        }
        private void input_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Panel panel = (Panel)textBox.Parent;
            panel.BackColor = SystemColors.ScrollBar;
            textBox.BackColor = SystemColors.ScrollBar;

            if (textBox.Text == "")
            {
                Label label = null;
                foreach (Control control in panel.Controls)
                {
                    if (control is Label)
                    {
                        label = (Label)control;
                        break;
                    }
                }

                if (label != null)
                {
                    LabelAnimationToOriginal(label);
                }
            }
        }

        private void LabelAnimationToOriginal(Label label)
        {
            if (label.Left != 2 || label.Top != 2) return;

            label.Font = new Font(label.Font.FontFamily, 11, label.Font.Style);

            Point originalPosition = (Point)label.Tag;

            int targetX = originalPosition.X;
            int targetY = originalPosition.Y;

            int step = 8; // Cantidad de píxeles para cada paso de la animación
            int interval = 2; // Intervalo de tiempo entre cada paso de la animación (en milisegundos)

            int deltaX = (targetX - label.Left) / step;
            int deltaY = (targetY - label.Top) / step;

            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = interval;

            animationTimer.Tick += (s, args) =>
            {
                if (label.Left != targetX)
                {
                    label.Left += deltaX;
                }

                if (label.Top != targetY)
                {
                    label.Top += deltaY;
                }

                if (label.Left == targetX && label.Top == targetY)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                    animationTimer = null;
                }
            };

            animationTimer.Start();
        }

        private void inputs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == new_nombre || sender == new_apellido || sender == new_usuario)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
            if (sender == new_nacimiento)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (sender == new_altura)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (sender == new_contrasena || sender == new_contrasena2)
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '!' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }

        private void HandleChanged(object sender, EventArgs e)
        {
            if (sender == new_contrasena || sender == new_contrasena2)
            {
                if (new_contrasena2.Text != new_contrasena.Text)
                {
                    psw_message2.Visible = true;
                }
                else
                {
                    psw_message2.Visible = false;
                }
            }
            if (sender == new_nacimiento && new_nacimiento.Text != "")
            {

                if (!Regex.IsMatch(new_nacimiento.Text, @"^(0[1-9]|1[0-9]|2[0-9]|3[01])/(0[1-9]|1[0-2])/(19[4-9][0-9]|200[0-5])$"))
                {
                    new_nacimiento_error.Visible = true;
                }
                else new_nacimiento_error.Visible = false;
            }
        }

        private bool IsValidDate(int dia, int mes, int año)
        {
            try
            {
                DateTime fecha = new DateTime(año, mes, dia);
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        private void ReiniciarCampos()
        {
            new_nombre.Text = "";
            new_apellido.Text = "";
            new_nacimiento.Text = "";
            new_email.Text = "";
            new_telefono.Text = "";
            new_foto.Text = "";
            new_calle.Text = "";
            new_altura.Text = "";
            new_usuario.Text = "";
            new_contrasena.Text = "";
            new_contrasena2.Text = "";
        }
        private void newaccount_submit_Click(object sender, EventArgs e)
        {
            custom_loader.Visible = true;
            database_response_error.Visible = false;

            string nombre = new_nombre.Text;

            if (!Regex.IsMatch(nombre, @"^[A-Za-z\s]{3,20}$"))
            {
                new_nombre_error.Visible = true;
                custom_loader.Visible = false;
                return;
            }
            else new_nombre_error.Visible = false;

            string apellido = new_apellido.Text;
            if (!Regex.IsMatch(apellido, @"^[A-Za-z\s]{3,20}$"))
            {
                new_apellido_error.Visible = true;
                custom_loader.Visible = false;
                return;
            }
            else new_apellido_error.Visible = false;


            DateTime? nacimiento = null;

            if (new_nacimiento.Text != "")
            {
                if (Regex.IsMatch(new_nacimiento.Text, @"^(0[1-9]|1[0-9]|2[0-9]|3[01])/(0[1-9]|1[0-2])/(19[4-9][0-9]|200[0-5])$"))
                {
                    string[] partes = new_nacimiento.Text.Split('/');
                    int dia = int.Parse(partes[0]);
                    int mes = int.Parse(partes[1]);
                    int año = int.Parse(partes[2]);

                    if (IsValidDate(dia, mes, año))
                    {
                        nacimiento = new DateTime(año, mes, dia);
                        new_nacimiento_error.Visible = false;
                    }
                }
                else
                {
                    new_nacimiento_error.Visible = true;
                    custom_loader.Visible = false;
                    return;
                }
            }
            else new_nacimiento_error.Visible = false;

            string usuario = new_usuario.Text;
            if (!Regex.IsMatch(usuario, @"^[A-Za-z1-9]{5,15}$"))
            {
                user_message.Visible = true;
                custom_loader.Visible = false;
                return;
            }
            else user_message.Visible = false;


            string contrasena = new_contrasena.Text;
            if (!Regex.IsMatch(contrasena, @"^[a-zA-Z0-9!_]{5,15}$"))
            {
                psw_message.Visible = true;
                custom_loader.Visible = false;
                return;
            }
            else psw_message.Visible = false;

            string contrasena2 = new_contrasena2.Text;
            if (!Regex.IsMatch(contrasena2, @"^[a-zA-Z0-9!_]{5,15}$"))
            {
                psw_message2.Visible = true;
                custom_loader.Visible = false;
                return;
            }
            else psw_message2.Visible = false;

            if (contrasena != contrasena2)
            {
                psw_message2.Visible = true;
                custom_loader.Visible = false;
                return;
            }

            string? email = new_email.Text;
            string? telefono = new_telefono.Text;
            string? foto = new_foto.Text;
            string? calle = new_calle.Text;
            string? altura = new_altura.Text;

            if (email == "") email = null;
            if (telefono == "") telefono = null;
            if (foto == "") foto = null;
            if (calle == "") calle = null;
            if (altura == "") altura = null;

            int existe = controller.VerificarCuenta(new_usuario.Text, new_contrasena.Text);

            if (existe == 0)
            {
                database_response_error.Visible = true;
                custom_loader.Visible = false;
                return;
            }
            else database_response_error.Visible = false;

            controller.CrearUsuario(nombre, apellido, nacimiento, email, telefono, foto, calle, altura, existe);
            custom_loader.Visible = false;
            database_response_success.Visible = true;


            ReiniciarCampos();

            new System.Threading.Timer(_ =>
            {
                database_response_success.Invoke((Action)(() =>
                {
                    database_response_success.Visible = false;
                }));
            }, null, 3000, Timeout.Infinite);


        }

        private void HandleClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            this.Select();
        }


        private void RedondearPanel(Panel panel, int radio)
        {

            GraphicsPath forma = new GraphicsPath();
            forma.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            forma.AddArc(new Rectangle(panel.Width - radio, 0, radio, radio), 270, 90);
            forma.AddArc(new Rectangle(panel.Width - radio, panel.Height - radio, radio, radio), 0, 90);
            forma.AddArc(new Rectangle(0, panel.Height - radio, radio, radio), 90, 90);
            forma.CloseFigure();

            Region region = new Region(forma);

            panel.Region = region;
        }

    }
}
