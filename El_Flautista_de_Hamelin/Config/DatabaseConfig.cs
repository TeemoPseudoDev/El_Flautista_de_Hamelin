﻿using System.Data;
using MySql.Data.MySqlClient;

namespace El_Flautista_de_Hamelin.Config
{
    public class DatabaseConfig
    {
        private string connectionString;
        private MySqlConnection connection;

        public DatabaseConfig()
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
        }

        public MySqlConnection GetConnection()
        {
            // Antes de abrir conexión, verificar que está cerrada
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }
    }

}
