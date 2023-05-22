using El_Flautista_de_Hamelin.Models;
using El_Flautista_de_Hamelin.Properties;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Flautista_de_Hamelin
{
    public partial class Login : Form
    {
        public int user_id;

        public Login()
        {
            InitializeComponent();

            user_id = 0;

            //string imagePath = Path.Combine(Application.StartupPath, "..", "..", "..", "Images", "moto_delivery.png");
            //this.BackgroundImage = Image.FromFile(imagePath);

            //pictureBox1.BackgroundImage = Image.FromFile(imagePath);
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

        private void Form1_Load(object sender, EventArgs e)
        {

            //Comida pizza = new Comida(1, "pizza", 58, 1);
            //Admin inti = new Admin(1, "inti", "taretto", new DateTime(1994, 09, 26), "jasda@alsd", "2131231", "Colonia990", "admin");
            //Detalle detalle = new Detalle(1, pizza, 15, 870);

            //textBox1.Text = pizza.nombre + inti.nombre + detalle.id;
        }

        private void Psw_container_Click(object sender, EventArgs e)
        {
            login_input_psw.Focus();
        }

        private void User_container_Click(object sender, EventArgs e)
        {
            login_input_user.Focus();
        }


        private void HandleSubmit(object sender, EventArgs e)
        {

            string user = login_input_user.Text;
            string psw = login_input_psw.Text;

            if (psw_message.Text != "" || user_message.Text != "")
            {
                general_message_error.Text = "Usuario y/o contraseña con errores";
                general_message_error.Visible = true;
                return;
            }

            if (user == "admin" && psw == "admin")
            {
                //manipular el controlador y el modelo
                this.user_id = 1;
                this.Close();

            }
            else
            {
                general_message_error.Text = "Usuario y/o contraseña inexistentes";
                general_message_error.Visible = true;
            }

        }

        private void HandleClose(object sender, EventArgs e)
        {
            this.user_id = -1;
            this.Close();
        }


        private void HandleChanged(object sender, EventArgs e)
        {
            general_message_error.Visible = false;

            if (sender == login_input_user)
            {
                string texto = login_input_user.Text;
                string patron = @"^[A-Za-z1-9]{1,15}$";
                if (!Regex.IsMatch(texto, patron))
                {
                    user_message.Text = "Sólo se admiten letras y números";
                    user_message.Visible = true;
                }
                else
                {
                    user_message.Text = "";
                    user_message.Visible = false;
                }

            }

            if (sender == login_input_psw)
            {
                string texto = login_input_psw.Text;
                string patron = @"^(?=.*[a-zA-Z0-9!_])[a-zA-Z0-9!_]{0,15}$";

                if (!Regex.IsMatch(texto, patron))
                {
                    psw_message.Text = "Letras, números, '!' y '_'";
                    psw_message.Visible = true;
                }
                else
                {
                    psw_message.Text = "";
                    psw_message.Visible = false;
                }

            }

        }

        private void general_message_error_Click(object sender, EventArgs e)
        {

        }

        private void psw_message_Click(object sender, EventArgs e)
        {

        }

        private void login_input_user_Enter(object sender, EventArgs e)
        {
            user_container.BackColor = SystemColors.Control;
            user_container.BorderStyle = BorderStyle.FixedSingle;
            login_input_user.BackColor = SystemColors.Control;
        }

        private void login_input_user_Leave(object sender, EventArgs e)
        {
            user_container.BackColor = Color.FromArgb(224, 224, 224);
            user_container.BorderStyle = BorderStyle.None;
            login_input_user.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void login_input_psw_Enter(object sender, EventArgs e)
        {
            psw_container.BackColor = SystemColors.Control;
            psw_container.BorderStyle = BorderStyle.FixedSingle;
            login_input_psw.BackColor = SystemColors.Control;
        }

        private void login_input_psw_Leave(object sender, EventArgs e)
        {
            psw_container.BackColor = Color.FromArgb(224, 224, 224);
            psw_container.BorderStyle = BorderStyle.None;
            login_input_psw.BackColor = Color.FromArgb(224, 224, 224);
        }


    }
}