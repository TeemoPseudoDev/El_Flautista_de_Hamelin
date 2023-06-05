using El_Flautista_de_Hamelin.Config;

namespace El_Flautista_de_Hamelin.Models
{
    public class Comida
    {
        public int id { get; private set; }
        public string nombre {  get; private set; }
        public double precio { get; private set; }
        public string foto { get; private set; }
        public bool destacado { get; private set; }
        public bool oferta { get; private set; }
        public int veces_pedido { get; private set; }
        public int categoria { get; private set; }
        public DatabaseConfig Database { get; private set; }

        public Comida(int id, string nombre, double precio, string foto, bool destacado, bool oferta, int veces_pedido, int categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.foto = foto;
            this.destacado = destacado;
            this.oferta = oferta;
            this.veces_pedido = veces_pedido;
            this.categoria = categoria;
            Database = new DatabaseConfig();
        }
        public Comida()
        {
            Database = new DatabaseConfig();
        }

        public Comida(string nombre, double precio, string foto, bool destacado, bool oferta, int veces_pedido, int categoria)
        {
            Database = new DatabaseConfig();
            this.nombre = nombre;
            this.precio = precio;
            this.foto = foto;
            this.destacado = destacado;
            this.oferta = oferta;
            this.veces_pedido = veces_pedido;
            this.categoria = categoria;
        }

        public List<Comida> BuscarComidasDB()
        {
            List<Comida> listaComidas = new List<Comida>(); // Lista de comidas
            string query = "SELECT * FROM comida;"; // Query SQL
            var respuesta = Database.Usar(query); // Respuesta de la base de datos

            while (respuesta.Read()) // Abrimos la respuesta, si son muchos registros se hace en un while
            {
                listaComidas.Add( // Por cada respuesta agregamos una nueva comida a la lista
                    new Comida(
                        (int)respuesta["id_comida"],
                        respuesta["nombre"].ToString(),
                        Convert.ToDouble(respuesta["precio"]),   // Constructor de la clase Comida
                        respuesta["foto"].ToString(),
                        (bool)respuesta["destacado"],
                        (bool)respuesta["oferta"],
                        Convert.ToInt32(respuesta["veces_pedido"]),
                        (int)respuesta["id_categoria"]
                    )
                );
            }

            respuesta.Close(); // Cerramos la respuesta


            return listaComidas; // Retornamos la lista de comidas
        }



        public void modificarPrecio(double precio)
        {
            this.precio = precio;
        }

        public void aumentarVecesPedido(int veces_pedido)
        {
            this.veces_pedido += veces_pedido;
        }

    }



}
