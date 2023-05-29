﻿using System.Data;
using MySql.Data.MySqlClient;

namespace El_Flautista_de_Hamelin.Config
{
    public class DatabaseConnect
    {
        private string connectionString;
        private MySqlConnection connection;


        public DatabaseConnect()
        {
            // Credenciales de la base de datos
            string server = "localhost";
            int port = 3306;
            string database = "comidarapida";
            string username = "root";
            string password = "esteesmiWORK";

            // Cadena de conexión
            this.connectionString = $"Server={server}; Port={port}; Database={database}; Uid={username}; Pwd={password}";

            this.connection = new MySqlConnection(connectionString);

            if (this.connection.State != ConnectionState.Open) // Validar si la conexión está cerrada
            {
                this.connection.Open();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public MySqlDataReader conectar(string query)
        {
            using (var command = new MySqlCommand(query, GetConnection()))
            {
                return command.ExecuteReader();
            }
        }
    }


}
