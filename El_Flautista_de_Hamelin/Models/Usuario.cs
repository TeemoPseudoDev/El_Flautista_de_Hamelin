namespace El_Flautista_de_Hamelin.Models
{
    public abstract class Usuario
    {
        public int id { get; private set; }
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public DateTime? nacimiento { get; private set; }
        public string? email { get; private set; }
        public string? telefono { get; private set; }
        public string? foto { get; private set; }
        public int id_direccion { get; private set; }
        public int tipo_usuario { get; private set; }
        public DateTime alta { get; private set; }
        public int id_cuenta { get; private set; }

        public Usuario(int id, string nombre, string apellido, DateTime? nacimiento, string? email, string? telefono, string? foto, int id_direccion, int tipo_usuario, DateTime alta, int id_cuenta)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.email = email;
            this.telefono = telefono;
            this.foto = foto;
            this.id_direccion = id_direccion;
            this.tipo_usuario = tipo_usuario;
            this.alta = alta;
            this.id_cuenta = id_cuenta;
        }

        public Usuario(string nombre, string apellido, DateTime? nacimiento, string? email, string? telefono, string? foto, int id_direccion, int tipo_usuario, DateTime alta, int id_cuenta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.email = email;
            this.telefono = telefono;
            this.foto = foto;
            this.id_direccion = id_direccion;
            this.tipo_usuario = tipo_usuario;
            this.alta = alta;
            this.id_cuenta = id_cuenta;
        }
    }
    
}


