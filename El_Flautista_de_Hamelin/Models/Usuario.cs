using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Flautista_de_Hamelin.Models
{
    public abstract class Usuario
    {
        protected int id { get; set; }
        protected string nombre { get; set; }
        protected string apellido { get; set; }
        protected DateTime nacimiento { get; set; }
        protected string email { get; set; }
        protected string telefono { get; set; }
        protected string foto { get; set; }
        protected string direccion { get; set; }
        protected string tipo_usuario { get; set; }
        protected DateTime alta { get; set; }


        public Usuario(int id, string nombre, string apellido, DateTime nacimiento, string email, string telefono, string foto, string direccion, string tipo_usuario, DateTime alta) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.email = email;
            this.telefono = telefono;
            this.foto = foto;
            this.direccion = direccion;
            this.tipo_usuario = tipo_usuario;
            this.alta = alta;
        }
    }
    
}


