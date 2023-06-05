using El_Flautista_de_Hamelin.Config;

namespace El_Flautista_de_Hamelin.Models
{
    public class Login
    {
        // Importar la configuración de la base de datos
        private DatabaseConfig Database;

        public Login()
        {
            Database = new DatabaseConfig();
        }

        public int BuscarCuenta(string nombre, string contrasena)
        {
            string query = $"SELECT id_cuenta FROM cuenta WHERE nombre = '{nombre}' AND contraseña = '{contrasena}';";
            var respuesta = Database.Usar(query);
            var respuestaId = 0;
            if (respuesta.Read())
            {
                respuestaId = (int)respuesta["id_cuenta"];
            }

            respuesta.Close();
            return respuestaId;
        }
    }

}
