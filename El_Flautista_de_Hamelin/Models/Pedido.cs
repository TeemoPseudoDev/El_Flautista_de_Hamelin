namespace El_Flautista_de_Hamelin.Models
{
    public class Pedido
    {
        public int id { get; private set; }
        public DateTime fecha { get; private set; }
        public DateTime hora_pedido { get; private set; }
        public DateTime hora_entrega { get; private set; }
        public Cliente cliente { get; private set; }
        public List <Detalle> detalles { get; private set; }
        public double envio { get; private set; }
        public double total { get; private set; }

        public Pedido(int id, DateTime fecha, DateTime hora_pedido, DateTime hora_entrega, Cliente cliente,List <Detalle> detalles, double envio, double total)
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

        public Pedido(DateTime fecha, DateTime hora_pedido, DateTime hora_entrega, Cliente cliente, List<Detalle> detalles, double envio, double total)
        {
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
