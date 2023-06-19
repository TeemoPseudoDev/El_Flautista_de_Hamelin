using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Flautista_de_Hamelin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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

        private void form_close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_btn_Click(object sender, EventArgs e)
        {
            Panel[] paneles = new Panel[4];
            paneles[0] = panel_btn_productos;
            paneles[1] = panel_btn_inicio;
            paneles[2] = panel_btn_llevar;
            paneles[3] = panel_btn_entregar;

            foreach (Panel element in paneles)
            {
                element.BackColor = Color.FromArgb(41, 39, 40);

                Label element_btn = null;
                foreach (Control control in element.Controls)
                {
                    if (control is Label)
                    {
                        element_btn = (Label)control;
                        break;
                    }
                }
                element_btn.ForeColor = SystemColors.ButtonHighlight;
            }

            Panel panel = null;
            if (sender is Panel)
            {
                panel = (Panel)sender;
            }
            else
            {
                panel = ((Control)sender).Parent as Panel;
            }


            panel.BackColor = SystemColors.Window;
            Label btn = null;
            foreach (Control control in panel.Controls)
            {
                if (control is Label)
                {
                    btn = (Label)control;
                    break;
                }
            }
            btn.ForeColor = SystemColors.ActiveCaptionText;
        }

    }
}
