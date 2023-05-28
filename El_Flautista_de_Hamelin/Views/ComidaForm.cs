using El_Flautista_de_Hamelin.Controllers;
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
    public partial class ComidaForm : Form
    {
        private comidaController comidaController;
        public ComidaForm()
        {
            InitializeComponent();
            comidaController = new comidaController();
        }

        private void Comida_Load(object sender, EventArgs e)
        {
            var comidas = comidaController.obtenerComidas();
            Tarjeta Tarjetita = new Tarjeta();
            Tarjetita.TopLevel = false;
            Tarjetita.Dock = DockStyle.Fill;
            Tarjetita.FormBorderStyle= FormBorderStyle.None;
            panel2.Controls.Add(Tarjetita);
            Tarjetita.Show();
            //Tarjetita.LabelText = comidas[0].nombre;
        }
    }
}
