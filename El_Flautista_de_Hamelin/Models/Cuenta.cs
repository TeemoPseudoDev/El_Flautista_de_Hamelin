using El_Flautista_de_Hamelin.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Flautista_de_Hamelin.Models
{
    public class Cuenta
    {
        private DatabaseConfig Database;
        private string nombre;
        private string contrasena;
        public Cuenta() { 
            Database = new DatabaseConfig();
        }

        public Cuenta(string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
            Database = new DatabaseConfig();
        }

        public bool YaExiste(string nombre)
        {
            string query = $"SELECT * FROM cuenta WHERE nombre = '{nombre}';";
            var respuesta = Database.Usar(query);

            if (respuesta.Read())
            {
                respuesta.Close();
                return true;
            }
            else
            {
                respuesta.Close();
                return false;

            }
        }

        public int CrearCuenta()
        {
            string query = $"INSERT INTO cuenta (nombre, contraseña) VALUES('{this.nombre}','{this.contrasena}');";
            var respuesta = Database.Usar(query);
            respuesta.Close();

            string queryId = "SELECT LAST_INSERT_ID();";
            var respuestaId = Database.Usar(queryId);
            int idNuevoRegistro = 0;
            if (respuestaId.Read())
            {
                idNuevoRegistro = Convert.ToInt32(respuestaId[0]);
            }
            respuestaId.Close();

            return idNuevoRegistro;
        }
    }
}
