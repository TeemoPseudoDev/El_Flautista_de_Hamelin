using El_Flautista_de_Hamelin.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DatabaseConnect database { get; private set; }

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
            database = new DatabaseConnect();
        }

        public Comida()
        {
            database = new DatabaseConnect();
        }

        public List<Comida> traerComidas()
        {
            List<Comida> listaComidas = new List<Comida>();
            string query = "SELECT * FROM comida;";
            using (MySqlDataReader reader = database.conectar(query))
            {
                while (reader.Read())
                {
                    listaComidas.Add(
                        new Comida(
                            (int)reader["id_comida"],
                            reader["nombre"].ToString(),
                            Convert.ToDouble(reader["precio"]),
                            reader["foto"].ToString(),
                            (bool)reader["destacado"],
                            (bool)reader["oferta"],
                            Convert.ToInt32(reader["veces_pedido"]),
                            (int)reader["id_categoria"]
                        )
                    );
                }
            }

            return listaComidas;
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
