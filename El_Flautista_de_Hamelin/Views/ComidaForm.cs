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

        private void Comida_Load(object sender, EventArgs e)
        {
            
                var comidas = comidaController.BuscarComidas();
                double desplazamientoHorizontal = 250; // Cantidad de desplazamiento horizontal
                double desplazamientoVertical = 270;   // Cantidad de desplazamiento verticalint
                int contadorV = 0;
                int contadorH = 0;
                foreach (var comid in comidas)
                {
                    TarjetaForm Tarjetita = new TarjetaForm();
                    Tarjetita.Click += (sender,e) => { };
                    Tarjetita.TopLevel = false;
                    Tarjetita.Dock = DockStyle.None; Contenedor.Controls.Add(Tarjetita);
                    Point location = new Point((int)(desplazamientoHorizontal * contadorH), (int)(desplazamientoVertical * contadorV));
                    Tarjetita.Location = location;
                    Tarjetita.setNombre(comid.nombre);
                    Tarjetita.setPrecio(comid.precio.ToString("0.00"));
                    Tarjetita.Show();
                    contadorH++;
                    if (contadorH == 4)
                    {
                        contadorH = 0; 
                        contadorV++;
                    }
                }


            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
