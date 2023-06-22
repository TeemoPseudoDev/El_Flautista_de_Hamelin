using El_Flautista_de_Hamelin.Models;
using El_Flautista_de_Hamelin.Views;
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
        private int posY;
        private int cuenta_id;

        public Menu(int cuenta_id)
        {
            this.cuenta_id = cuenta_id;
            InitializeComponent();
            posY = 5;
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
            Cliente usuario = new Cliente(this.cuenta_id);

            usuario.getClient();

            user_name_title.Text = $"{usuario.getNombre()} {usuario.getApellido()}";

            // Configuración del ícono
            Icon icon = Properties.Resources.Flautista;
            this.Icon = icon;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;

            ComidaForm comidas = new ComidaForm();

            comidas.TopLevel = false;

            menu_container.Controls.Add(comidas);

            comidas.MiEvento += FormHijo_MiEvento;

            comidas.Show();

        }

        private void FormHijo_MiEvento(object datos_tarjeta)
        {
            dynamic tarjeta = datos_tarjeta;
            bool agregado = false;
            foreach (Plato platoControl in container_platos.Controls)
            {
                if (platoControl.getNombre() == tarjeta.Name)
                {
                    agregado = true;

                    string precioString = platoControl.getPrecio();

                    float precio = float.Parse(precioString);
                    float tarjetaPrecio = float.Parse(tarjeta.Precio);

                    float suma = precio + tarjetaPrecio;

                    platoControl.setPrecio($"{Math.Round(suma, 2)}");


                    int cantidad = int.Parse(platoControl.getQuantity());
                    cantidad += 1;
                    platoControl.setQuantity(cantidad.ToString());

                    break;
                }
            }

            if (!agregado)
            {
                Plato plato = new Plato();

                plato.TopLevel = false;
                plato.Dock = DockStyle.None;
                plato.Location = new Point(0, posY - container_platos.VerticalScroll.Value);

                plato.setNombre(tarjeta.Name);
                plato.setPrecio(tarjeta.Precio);

                container_platos.Controls.Add(plato);
                posY += plato.Height + 10;

                plato.MiEvento += (sender) =>
                {
                    plato.Dispose();
                    plato.Close();
                    container_platos.Refresh();
                    posY = 5;
                    foreach (Plato platoControl in container_platos.Controls)
                    {
                        platoControl.Location = new Point(0, posY - container_platos.VerticalScroll.Value);
                        posY += plato.Height + 10;
                    }
                };

                plato.Show();
            }
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

        private void button_cancelar_pedido_Click(object sender, EventArgs e)
        {
            container_platos.Controls.Clear();
            posY = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleForm detalle = new DetalleForm();

            detalle.Load += (object sender, EventArgs e) =>
            {
                var container = detalle.devolverPanel();

                float acuTotal = 0;
                var pos = 35;

                foreach (Plato platoControl in container_platos.Controls)
                {
                    PlatoNoAbominacion miPlato = new PlatoNoAbominacion();
                    miPlato.TopLevel = false;
                    miPlato.setComidaTitle(platoControl.getNombre());
                    miPlato.setComidaCantidad(platoControl.getQuantity());
                    miPlato.setComidaPrecio(platoControl.getPrecio());

                    miPlato.Location = new Point(0, pos);

                    container.Controls.Add(miPlato);

                    miPlato.Show();
                    pos += 35;

                    acuTotal += float.Parse(platoControl.getPrecio());
                }


                var total = Math.Round(acuTotal, 2);

                detalle.setTotalPrecio(total.ToString());


            };

            detalle.FormClosed += (sender, e) => {
                container_platos.Controls.Clear();
                posY = 5;
            };
            detalle.ShowDialog();
        }
    }
}
