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
        public void setNombre(string value)
        {
            nombre.Text = value;
        }

        public string getName()
        {
            return nombre.Text;
        }

        public void setPrecio(string value)
        {
            precio.Text = value;
        }

        public string getPrecio()
        {
            return precio.Text;
        }

        public void setFoto(string value)
        {
            try
            {
                //foto.ImageLocation = value;

                using (WebClient webClient = new WebClient())
                {
                    //string url = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/62/NCI_Visuals_Food_Hamburger.jpg/640px-NCI_Visuals_Food_Hamburger.jpg";
                    byte[] imageBytes = webClient.DownloadData(value);
                    using (var stream = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(stream);
                        foto.Image = image;
                    }
                }

            }
            catch (WebException webEx)
            {
                //MessageBox.Show("Error al descargar la imagen: " + webEx.Message);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
