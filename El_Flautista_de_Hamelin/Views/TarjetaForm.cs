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
            set { nombre.Text = value; }
        }
    }
}
