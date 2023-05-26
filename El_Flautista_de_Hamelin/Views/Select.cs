using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace El_Flautista_de_Hamelin.Views
{
    public partial class Select : Form
    {
        private readonly object command;
        public string connectionString;
        public MySqlConnection connection;


        public Select()
        {
            this.connectionString = "Server = localhost; Port = 3306; Database = comidarapida; Uid = root; Pwd = c0c@c0l@";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Select_Load(object sender, EventArgs e)
        {
            connection.Open();
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
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
