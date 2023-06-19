using El_Flautista_de_Hamelin.Views;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Flautista_de_Hamelin
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();


            ComidaForm homeForm = new ComidaForm();
            Application.Run(homeForm);

            /*DetalleForm detalle = new DetalleForm();
            Application.Run(detalle);*/


            /*Menu elmenu = new Menu();
            Application.Run(elmenu);*/

            /*LoginForm loginForm = new LoginForm();
             if (loginForm.ShowDialog() == DialogResult.OK)
             {
                int userId = loginForm.user_id;

                Menu elmenu = new Menu();
                Application.Run(elmenu);
             }*/
        }
    }

}