using MySql.Data.MySqlClient;


namespace El_Flautista_de_Hamelin.Views
{
    public partial class Select : Form
    {
        public string connectionString;
        public MySqlConnection connection;
        public int id;

        public Select(int id)
        {
            this.id = id;
            this.connectionString = "Server = localhost; Port = 3306; Database = comidarapida; Uid = root; Pwd = esteesmiWORK";
            this.connection = new MySqlConnection(connectionString);

            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            string queryVistas = "Select * from " + selectedItem + ";";

            using (MySqlCommand command = new MySqlCommand(queryVistas, connection))
            {
                // Ejecutar el comando y obtener el lector de datos
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Leer los datos del lector
                    while (reader.Read())
                    {
                        string valorCampo = reader["nombre"].ToString();

                        label2.Text = valorCampo;
                    }
                }
            }
        }

        private void Select_Load(object sender, EventArgs e)
        {
            connection.Open();


            /*
            string query = "select descripcion from categoria;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Ejecutar el comando y obtener el lector de datos
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Leer los datos del lector
                    while (reader.Read())
                    {
                        string viewName = reader.GetString(0);
                        comboBox1.Items.Add(viewName);
                    }
                }
            }*/
        }
    }
}
