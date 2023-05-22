using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Flautista_de_Hamelin.Models
{
    public class Admin:Usuario
    {

        public Admin(int id, string nombre, string apellido, DateTime nacimiento, string email, string telefono, string foto, string direccion, string tipo_usuario, DateTime alta) : base(id, nombre, apellido, nacimiento, email, telefono, foto, direccion, tipo_usuario, alta)
        {

        }

        public void agregarProdcuto()
        {

        }

        public void editarProducto() 
        {

        }

        public void suspenderProducto()
        {

        }

        public void eliminarProducto()
        {

        }
    }
}
