using El_Flautista_de_Hamelin.Views;
using System.Security.Cryptography.X509Certificates;

namespace El_Flautista_de_Hamelin
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();


            /*detalle_pedido detalle = new detalle_pedido();
            Application.Run(detalle);*/


            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                int userId = loginForm.user_id;
                //Select homeForm = new Select(userId);
                //Application.Run(homeForm);
            }
            /*
            ComidaForm comidaForm = new ComidaForm();
            Application.Run(comidaForm);*/
        }
    }

}