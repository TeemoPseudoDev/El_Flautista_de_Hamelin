namespace El_Flautista_de_Hamelin.Models
{
    public abstract class Usuario
    {
        public int id { get; private set; }
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public DateTime nacimiento { get; private set; }
        public string email { get; private set; }
        public string telefono { get; private set; }
        public string foto { get; private set; }
        public string direccion { get; private set; }
        public string tipo_usuario { get; private set; }
        public DateTime alta { get; private set; }


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


