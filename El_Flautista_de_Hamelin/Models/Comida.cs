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
        private int id { get; set; }
        public string nombre {  get; set; }
        private double precio { get; set; }
        private string foto { get; set; }
        private int destacado { get; set; }
        private int oferta { get; set; }
        private int veces_pedido { get; set; }
        private int categoria { get; set; }
        private DatabaseConnect database { get; set; }

        public Comida(int id, string nombre, double precio, string foto, int destacado, int oferta, int veces_pedido, int categoria)
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

        }

        public List<Comida> traerComidad()
        {
            List<Comida> listaComidas = new List<Comida>();
            string query = $"SELECT * FROM comida;";
            using (MySqlDataReader reader = database.conectar(query))
            {
                while (reader.Read())
                {
                    // Agregar elementos a la lista
                    listaComidas.Add(

                        new Comida(
                            (int)reader["id_comida"],
                            reader["nombre"].ToString(),
                            (double)reader["precio"],
                            reader["foto"].ToString(),
                            (int)reader["destacado"],
                            (int)reader["oferta"],
                            (int)reader["veces_pedido"],
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
