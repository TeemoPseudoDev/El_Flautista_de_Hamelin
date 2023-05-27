using El_Flautista_de_Hamelin.Config;
using MySql.Data.MySqlClient;

namespace El_Flautista_de_Hamelin.Models
{
    internal class Login
    {
        // Importar la configuración de la base de datos
        private DatabaseConfig databaseConfig;

        public Login()
        {
            databaseConfig = new DatabaseConfig();
        }
        public int BuscarCuenta(string usuario, string contrasena)
        {
            using (MySqlConnection connection = databaseConfig.GetConnection())
            {
                // Query hacia la base de datos
                string query = "SELECT id_usuario FROM cuenta WHERE nombre = @user AND contraseña = @psw;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Parámetros utilizados en el Query. Se agrega seguridad al programa evitando inyeción SQL 
                    command.Parameters.AddWithValue("@user", usuario);
                    command.Parameters.AddWithValue("@psw", contrasena);

                    // Se ejecuta la consulta 
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Valida si trajo algún registro
                        if (reader.Read())
                        {
                            return reader.GetInt32("id_usuario");
                        }
                    }
                }
            }

            //0 si no encontró alguna cuenta.
            return 0;

        }
    }
}
