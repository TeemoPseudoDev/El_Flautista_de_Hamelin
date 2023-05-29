namespace El_Flautista_de_Hamelin.Models
{
    public  class Cliente : Usuario
    {
        public Cliente(int id, string nombre, string apellido, DateTime nacimiento, string email, string telefono, string foto, string direccion, string tipo_usuario, DateTime alta):base( id,  nombre,  apellido,  nacimiento,  email,  telefono, foto,  direccion,  tipo_usuario, alta ) 
        {
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
