using El_Flautista_de_Hamelin.Controllers;

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

        
    }
}
