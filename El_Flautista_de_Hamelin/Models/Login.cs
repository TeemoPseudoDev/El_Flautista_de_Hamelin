using El_Flautista_de_Hamelin.Config;
using MySql.Data.MySqlClient;

namespace El_Flautista_de_Hamelin.Models
{
    internal class Login
    {
        // Importar la configuración de la base de datos
        private DatabaseConnect database;

        public Login()
        {
            database = new DatabaseConnect();
        }

        public int BuscarCuenta(string nombre, string contrasena)
        {
            string query = $"SELECT id_usuario FROM cuenta WHERE nombre = '{nombre}' AND contraseña = '{contrasena}';";
            using (MySqlDataReader reader = database.conectar(query))
            {
                if (reader.Read())
                {
                    return reader.GetInt32("id_usuario");
                }
            }
            return 0;
        }
    }

}
