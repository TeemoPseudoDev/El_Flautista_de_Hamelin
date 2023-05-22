using El_Flautista_de_Hamelin.Models;
using El_Flautista_de_Hamelin.Properties;
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

    }
}