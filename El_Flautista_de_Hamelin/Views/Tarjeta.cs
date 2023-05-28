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
    public partial class Tarjeta : Form
    {
        public Tarjeta()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get { return nombre.Text; }
            set { nombre.Text = value; }
        }
    }
}
