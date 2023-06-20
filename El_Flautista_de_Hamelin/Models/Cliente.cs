using El_Flautista_de_Hamelin.Config;

namespace El_Flautista_de_Hamelin.Models
{
    public  class Cliente : Usuario
    {
        private DatabaseConfig Database;

        public Cliente(int id_cuenta):base(id_cuenta)
        {
            Database = new DatabaseConfig();
        }

        public Cliente(int id, string nombre, string apellido, DateTime? nacimiento, string? email, string? telefono, string? foto, int id_direccion, int tipo_usuario, DateTime alta, int id_cuenta):base( id,  nombre,  apellido,  nacimiento,  email,  telefono, foto, id_direccion, tipo_usuario, alta, id_cuenta ) 
        {
            Database = new DatabaseConfig();
        }

        public Cliente(string nombre, string apellido, DateTime? nacimiento, string? email, string? telefono, string? foto, int id_direccion, int tipo_usuario, DateTime alta, int id_cuenta) : base(nombre, apellido, nacimiento, email, telefono, foto, id_direccion, tipo_usuario, alta, id_cuenta)
        {
            Database = new DatabaseConfig();
        }

        public void getClient()
        {
            string query = $"SELECT * FROM usuario where id_cuenta = {this.id_cuenta}"; // Query SQL
            var respuesta = Database.Usar(query); // Respuesta de la base de datos



            if (respuesta.Read()) // Abrimos la respuesta, si son muchos registros se hace en un while
            {
                this.setNombre((string)respuesta["nombre"]);
                this.setApellido(respuesta["apellido"].ToString());

            } else
            {
                this.setNombre("no se encontro");
            }

            respuesta.Close(); // Cerramos la respuesta
        }

        public void CrearCliente()
        {
            string queryCliente = $"INSERT INTO usuario (nombre, apellido, nacimiento, email, telefono, id_direccion, id_tipo, foto, alta, id_cuenta) " +
                      $"VALUES('{nombre}', '{apellido}', {(nacimiento != null ? "'" + nacimiento.Value.ToString("yyyy-MM-dd") + "'" : "NULL")}, '{email}', '{telefono}', {id_direccion}, {2}, '{foto}', '{alta.ToString("yyyy-MM-dd")}', {id_cuenta})";

            var respuestaCliente = Database.Usar(queryCliente);

            respuestaCliente.Close();
        }
        public void realizarPedido()
        {

        }
        public void cancelarPedido()
        {

        }
        public void estadoPedido()
        {

        }
        public void verMisMovimientos()
        {

        }
        public void cancelarCueta()
        {

        }

    }
}
