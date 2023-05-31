using El_Flautista_de_Hamelin.Models;

namespace El_Flautista_de_Hamelin.Controllers
{
    public class LoginController
    {
        private Login model;
        public LoginController() {
            model = new Login();
        }

        public int SearchUser(string user, string psw)
        {
            int id = this.model.BuscarCuenta(user, psw);

            return id;
        }

    }
}
