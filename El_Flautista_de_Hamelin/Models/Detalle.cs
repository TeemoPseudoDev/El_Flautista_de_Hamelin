namespace El_Flautista_de_Hamelin.Models
{
    public class Detalle
    {
        public int id { get; private set; }
        public Comida comida { get; private set; }
        public int cantidad { get; private set; }
        public double sub_total { get; private set; }
        public Detalle(int id, Comida comida, int cantidad, double sub_total) 
        { 
            this.id = id;
            this.comida = comida;
            this.cantidad = cantidad;
            this.sub_total = sub_total;
        }

        public void modificarCantidad(int cantidad) 
        {
            this.cantidad = cantidad;
        }
    }
}
