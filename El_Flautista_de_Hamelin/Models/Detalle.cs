using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Flautista_de_Hamelin.Models
{
    public class Detalle
    {
        private int id { get; set; }
        private Comida comida { get; set; }
        private int cantidad { get; set; }
        private double sub_total { get; set; }
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
