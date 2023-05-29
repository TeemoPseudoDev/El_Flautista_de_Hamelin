﻿using El_Flautista_de_Hamelin.Controllers;

namespace El_Flautista_de_Hamelin.Views
{
    public partial class ComidaForm : Form
    {
        private ComidaController comidaController;
        public ComidaForm()
        {
            InitializeComponent();
            comidaController = new ComidaController();
        }

        private void Comida_Load(object sender, EventArgs e)
        {
            var comidas = comidaController.BuscarComidas();
            TarjetaForm Tarjetita = new TarjetaForm();
            Tarjetita.TopLevel = false;
            Tarjetita.Dock = DockStyle.Fill;
            //Tarjetita.FormBorderStyle = FormBorderStyle.None;

            panel2.Controls.Add(Tarjetita);
            Tarjetita.Show();
            Tarjetita.LabelText = comidas[0].nombre;
        }
    }
}
