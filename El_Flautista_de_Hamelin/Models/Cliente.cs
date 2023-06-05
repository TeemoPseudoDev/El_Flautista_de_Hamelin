using El_Flautista_de_Hamelin.Config;

namespace El_Flautista_de_Hamelin.Models
{
    public  class Cliente : Usuario
    {
        private DatabaseConfig Database;
        public Cliente(int id, string nombre, string apellido, DateTime? nacimiento, string? email, string? telefono, string? foto, int id_direccion, int tipo_usuario, DateTime alta, int id_cuenta):base( id,  nombre,  apellido,  nacimiento,  email,  telefono, foto, id_direccion, tipo_usuario, alta, id_cuenta ) 
        {
            Database = new DatabaseConfig();
        }

        public Cliente(string nombre, string apellido, DateTime? nacimiento, string? email, string? telefono, string? foto, int id_direccion, int tipo_usuario, DateTime alta, int id_cuenta) : base(nombre, apellido, nacimiento, email, telefono, foto, id_direccion, tipo_usuario, alta, id_cuenta)
        {
            Database = new DatabaseConfig();
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
