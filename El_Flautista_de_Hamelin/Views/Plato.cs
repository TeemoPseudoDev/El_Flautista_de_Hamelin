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
    public partial class Plato : Form
    {
        public Plato()
        {
            InitializeComponent();
        }

        public delegate void MiEventoHandler(object sender); // Delegado personalizado para el evento
        public event MiEventoHandler MiEvento;


        private void HandleClickPlatoClose(object sender, EventArgs e)
        {

            MiEvento?.Invoke(sender);
        }


        public void setNombre(string nombre)
        {
            this.plato_name.Text = nombre;
        }

        public string getNombre()
        {
            return this.plato_name.Text;
        }

        public void setPrecio(string precio)
        {
            this.plato_gold.Text = precio;
        }

        public string getPrecio()
        {
            return this.plato_gold.Text;
        }

        public void setQuantity(string quantity)
        {
            this.plato_quantity.Text = quantity;
        }

        public string getQuantity()
        {
            return this.plato_quantity.Text;
        }

    }
}
