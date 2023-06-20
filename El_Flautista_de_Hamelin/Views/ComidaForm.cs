using El_Flautista_de_Hamelin.Controllers;

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


        public delegate void MiEventoHandler(object datos_tarjeta); // Delegado personalizado para el evento
        public event MiEventoHandler MiEvento;


        private void HandleClickTarjetita(object sender, EventArgs e)
        {
            TarjetaForm Tarjetita = (TarjetaForm)sender;

            var datos_tarjeta = new
            {
                Name = Tarjetita.getName(),
                Precio = Tarjetita.getPrecio(),
            };

            MiEvento?.Invoke(datos_tarjeta);
        }

        private void Comida_Load(object sender, EventArgs e)
        {

            var comidas = comidaController.BuscarComidas();

            int contadorV = 0;
            int contadorH = 0;
            double xWidth;
            double yHeight;
            double horizontal;
            double vertical;

            foreach (var comid in comidas)
            {
                TarjetaForm Tarjetita = new TarjetaForm();

                xWidth = Tarjetita.Width * contadorH;
                yHeight = Tarjetita.Height * contadorV;


                horizontal = xWidth + (60 * (contadorH + 1)); // Cantidad de desplazamiento horizontal
                vertical = yHeight + (30 * (contadorV + 1)); // Cantidad de desplazamiento vertical


                Tarjetita.TopLevel = false;
                Tarjetita.Dock = DockStyle.None;

                Contenedor.Controls.Add(Tarjetita);

                Point location = new Point((int)(horizontal), (int)(vertical));
                Tarjetita.Location = location;
                Tarjetita.setNombre(comid.nombre);
                Tarjetita.setPrecio(comid.precio.ToString("0.00"));
                Tarjetita.setFoto(comid.foto);

                Tarjetita.Click += HandleClickTarjetita;

                Tarjetita.Show();

                contadorH++;
                if (contadorH == 2)
                {
                    contadorH = 0;
                    contadorV++;
                }
            }


        }



    }

}

