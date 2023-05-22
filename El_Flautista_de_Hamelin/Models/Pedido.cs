using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Flautista_de_Hamelin.Models
{
    public class Pedido
    {
        private int id { get; set; }
        private DateTime fecha { get; set; }
        private DateTime hora_pedido { get; set; }
        private DateTime hora_entrega { get; set; }
        private Cliente cliente { get; set; }
        private Detalle[] detalles { get; set; }
        private double envio { get; set; }
        private double total { get; set; }

        public Pedido(int id, DateTime fecha, DateTime hora_pedido, DateTime hora_entrega, Cliente cliente, Detalle[] detalles, double envio, double total)
        {
            this.id = id;
            this.fecha = fecha;
            this.hora_pedido = hora_pedido;
            this.hora_entrega = hora_entrega;
            this.cliente = cliente;
            this.detalles = detalles;
            this.envio = envio;
            this.total = total;

        }

        public double CalcularPrecio(Detalle[] detalles)
        {
            return 0;
        }
    }
}
