using El_Flautista_de_Hamelin.Views;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using El_Flautista_de_Hamelin.Controllers;

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

        private void Form1_Load(object sender, EventArgs e)
        {

            Form1 formularioSecundario = new Form1();
            formularioSecundario.TopLevel = false;
            formularioSecundario.FormBorderStyle = FormBorderStyle.None;
            formularioSecundario.Dock = DockStyle.Fill;
            panel1.Controls.Add(formularioSecundario);
            formularioSecundario.Show();

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

            if (psw_message.Text != "" || user_message.Text != "")
            {
                general_message_error.Text = "Usuario y/o contraseña con errores";
                general_message_error.Visible = true;
                return;
            }
            string user = login_input_user.Text;
            string psw = login_input_psw.Text;

            int id = this.controller.SearchUser(user, psw);

            if (id != 0)
            {
                this.user_id = id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                general_message_error.Text = "Usuario y/o contraseña inexistentes";
                general_message_error.Visible = true;
            }

        }


        private void HandleChanged(object sender, EventArgs e)
        {

            general_message_error.Visible = false;

            if (sender == login_input_user)
            {
                string texto = login_input_user.Text;
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

            if (sender == login_input_psw)
            {
                string texto = login_input_psw.Text;
                string patron = @"^[a-zA-Z0-9!_]{5,15}$";

                if (!Regex.IsMatch(texto, patron))
                {
                    psw_message.Text = "Letras, números, '!' y '_'.\r\nMínimo 5 caracteres.";
                    psw_message.Visible = true;
                }
                else
                {
                    psw_message.Text = "";
                    psw_message.Visible = false;
                }

            }

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


        private void login_new_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            //accountForm.Owner = this;
            accountForm.ShowDialog();
            /*accountForm.FormClosed += (sender, e) => {
                this.Show();
            };*/
            //this.Hide();
        }

        private void form_close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}