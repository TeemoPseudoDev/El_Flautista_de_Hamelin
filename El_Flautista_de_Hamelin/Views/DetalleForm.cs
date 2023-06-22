using El_Flautista_de_Hamelin.Config;
using El_Flautista_de_Hamelin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Flautista_de_Hamelin.Views
{
    public partial class DetalleForm : Form
    {

        private DatabaseConfig database;

        public DetalleForm()
        {
            database = new DatabaseConfig();
            InitializeComponent();
        }

        public void setTotalPrecio(string totalPrecio)
        {
            total_precio.Text = totalPrecio;
        }

        private void detalle_pedido_Load(object sender, EventArgs e)
        {
            string query = "select * from detalle;";
            var detalle_compra = database.Usar(query);

            List<Detalle> detalles = new List<Detalle>();

            double total = 0;

            while (detalle_compra.Read())
            {
                detalles.Add(
                    new Detalle(
                        (int)detalle_compra["id_detalle"],
                        (int)detalle_compra["cantidad"],
                        Convert.ToDouble(detalle_compra["sub_total"])
                    )
                );

                total = +Convert.ToDouble(detalle_compra["sub_total"]);
            }

            Cliente pepe = new Cliente("nombre", "apellido,", DateTime.Now, "asdasd@asdasd", "3156", "asdasd", 26, 27, DateTime.Now, 5);

            Pedido pedido1 = new Pedido(DateTime.Now, DateTime.Now, DateTime.Now, pepe, detalles, 5, total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarjeta_btn_efectivo.BackColor = SystemColors.ActiveCaption;
            tarjeta_btn_tarjeta.BackColor = Color.Gray;
        }

        private void capturarPantallaTicket()
        {
            Rectangle bounds = panel_pago.Bounds;

            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(panel_pago.PointToScreen(Point.Empty), Point.Empty, bounds.Size);
                }

                bitmap.Save("C:\\Users\\brian\\Desktop\\ticket_pago.png");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tarjeta_btn_tarjeta.BackColor = SystemColors.ActiveCaption;
            tarjeta_btn_efectivo.BackColor = Color.Gray;

            TarjetaCredito tarjetaCredito = new TarjetaCredito();
            tarjetaCredito.ShowDialog();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Panel devolverPanel()
        {
            return container_pago;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            capturarPantallaTicket();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo de tiempo en milisegundos (en este caso, 1 segundo)

            timer.Tick += (sender, e) =>
            {
                this.Close();
            };

            timer.Start(); // Inicia el temporizador
        }
    }
}
