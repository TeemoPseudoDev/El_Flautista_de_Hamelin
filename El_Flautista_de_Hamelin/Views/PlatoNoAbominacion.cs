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
    public partial class PlatoNoAbominacion : Form
    {
        public PlatoNoAbominacion()
        {
            InitializeComponent();
        }

        public void setComidaTitle(string title)
        {
            comida_title.Text = title;
        }
        public void setComidaCantidad(string title)
        {
            comida_cantidad.Text = title;
        }

        public void setComidaPrecio(string title)
        {
            comida_precio.Text = title;
        }

        public string getComidaTitle()
        {
            return comida_title.Text;
        }

        public string getComidaPrecio()
        {
            return comida_precio.Text;
        }

        public string getComidaCantidad()
        {
            return comida_cantidad.Text;
        }


    }
}
