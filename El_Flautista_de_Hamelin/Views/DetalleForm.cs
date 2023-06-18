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

            label6.Text = pedido1.total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            button2.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightBlue;
            button1.BackColor = Color.Gray;
        }


    }
}
