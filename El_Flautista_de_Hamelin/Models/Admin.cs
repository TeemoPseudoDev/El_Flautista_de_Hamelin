using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Flautista_de_Hamelin.Models
{
    public class Admin:Usuario
    {

        public Admin(int id, string nombre, string apellido, DateTime? nacimiento, string? email, string? telefono, string? foto, int id_direccion, int tipo_usuario, DateTime alta, int id_cuenta) : base(id, nombre, apellido, nacimiento, email, telefono, foto, id_direccion, tipo_usuario, alta, id_cuenta)
        {

        }

        public Admin(string nombre, string apellido, DateTime? nacimiento, string? email, string? telefono, string? foto, int id_direccion, int tipo_usuario, DateTime alta, int id_cuenta) : base(nombre, apellido, nacimiento, email, telefono, foto, id_direccion, tipo_usuario, alta, id_cuenta)
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
