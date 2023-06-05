using El_Flautista_de_Hamelin.Models;

namespace El_Flautista_de_Hamelin.Controllers
{
    public class CuentaController
    {
        private Cuenta cuenta { get; set; }
        public CuentaController() { 
            cuenta = new Cuenta();
        }

        public int VerificarCuenta(string nombre, string contrasena)
        {

            if(cuenta.YaExiste(nombre))
            {
                return 0;
            } else
            {
                Cuenta NuevaCuenta = new Cuenta(nombre, contrasena);
                return NuevaCuenta.CrearCuenta();
            }
        }

        public void CrearUsuario(string nombre, string apellido, DateTime? nacimiento, string? email, string? telefono, string? foto, string? calle, string? altura, int id_cuenta)
        {
            Direccion NuevaDireccion = new Direccion(calle, altura);

            int id_direccion = NuevaDireccion.CrearDireccion();

            Cliente NuevoCliente = new Cliente(nombre, apellido, nacimiento, email, telefono, foto, id_direccion, 2, DateTime.Now,id_cuenta);
            NuevoCliente.CrearCliente();

        }

    }
}
