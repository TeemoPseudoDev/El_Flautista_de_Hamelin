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
        private string nombre { get; set; }
        private double precio { get; set; }
        private string foto { get; set; }
        private bool destacado { get; set; }
        private bool oferta { get; set; }
        private int veces_pedido { get; set; }
        private string categoria { get; set; }

        public Comida(int id, string nombre, double precio, string foto, bool destacado, bool oferta, int veces_pedido, string categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.foto = foto;
            this.destacado = destacado;
            this.oferta = oferta;
            this.veces_pedido = veces_pedido;
            this.categoria = categoria;
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
