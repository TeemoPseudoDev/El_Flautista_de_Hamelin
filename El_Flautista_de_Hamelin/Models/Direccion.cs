using El_Flautista_de_Hamelin.Config;

namespace El_Flautista_de_Hamelin.Models
{
    public class Direccion
    {
        public string? altura { get; set; }
        public string? calle { get; set; }
        public DatabaseConfig Database { get; private set; }
        public Direccion(string? calle, string? altura)
        {
            this.calle = calle;
            this.altura = altura;
            this.Database = new DatabaseConfig();
        }

        public int CrearDireccion()
        {

            string query = $"INSERT INTO direccion (calle, altura) VALUES('{this.calle}','{this.altura}');";
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
