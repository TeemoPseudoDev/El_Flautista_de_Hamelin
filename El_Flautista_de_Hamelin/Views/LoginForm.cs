using El_Flautista_de_Hamelin.Views;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using El_Flautista_de_Hamelin.Controllers;
using System.Drawing.Drawing2D;

namespace El_Flautista_de_Hamelin
{


    public partial class LoginForm : Form
    {
        private LoginController controller;
        public int user_id;

        public LoginForm()
        {
            InitializeComponent();
            controller = new LoginController();
            RedondearPanel(user_container, 20);
            RedondearPanel(psw_container, 20);

            user_id = 0;
        }


        //para que al hacer click sobre la imagen también se pueda mover la ventana del formulario de login

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int HTCAPTION = 0x0002;

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTCAPTION;
                return;
            }

            base.WndProc(ref m);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //fin click para mover ventana

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Configuración del ícono
            Icon icon = Properties.Resources.Flautista;
            this.Icon = icon;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;

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

        private void HandleSubmit(object sender, EventArgs e)
        {
            general_message_error.Visible = false;

            string usuario = login_input_user.Text;
            if (!Regex.IsMatch(usuario, @"^[A-Za-z1-9]{5,15}$"))
            {
                user_message.Visible = true;
                return;
            }
            else user_message.Visible = false;


            string contrasena = login_input_psw.Text;
            if (!Regex.IsMatch(contrasena, @"^[a-zA-Z0-9!_]{5,15}$"))
            {
                psw_message.Visible = true;
                return;
            }
            else psw_message.Visible = false;


            int id = this.controller.SearchUser(usuario, contrasena);

            if (id != 0)
            {
                /*this.user_id = id;
                this.DialogResult = DialogResult.OK;
                this.Close();*/
                login_input_user.Text = id.ToString();
            }
            else
            {
                general_message_error.Visible = true;
                return;
            }

        }

        private void inputs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == login_input_user)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

            }

            if (sender == login_input_psw)
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '!' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

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

        private void login_new_Click(object sender, EventArgs e)
        {
            CuentaForm accountForm = new CuentaForm();
            //accountForm.Owner = this;
            this.Opacity = 0;

            accountForm.FormClosing += (sender, e) =>
            {
                this.Opacity = 1;
            };
            accountForm.ShowDialog();
        }

        private void form_close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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