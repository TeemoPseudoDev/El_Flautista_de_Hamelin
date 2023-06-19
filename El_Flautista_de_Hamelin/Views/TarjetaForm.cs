using El_Flautista_de_Hamelin.Controllers;
using System.Net;

namespace El_Flautista_de_Hamelin.Views
{
    public partial class TarjetaForm : Form
    {
        public TarjetaForm()
        {
            InitializeComponent();
           
        }
        public string LabelText
        {
            get { return nombre.Text; }
        }
        public void setNombre (string value)
        {
            nombre.Text = value;
        }

        public void setPrecio (string value)
        {
            precio.Text = value;
        }

        public void setFoto(string value)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(value); // Descarga la imagen desde el enlace
                    using (var stream = new System.IO.MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(stream); // Crea una instancia de la imagen desde el flujo de memoria
                        foto.Image = image; // Asigna la imagen al PictureBox
                    }
                }
            }
            catch (Exception ex)
            {

            }
            //Image image = Image.FromStream(value);
            //foto.Image = value;
        }


    }
}
