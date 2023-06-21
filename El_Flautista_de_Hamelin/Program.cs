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


           LoginForm loginForm = new LoginForm();
             if (loginForm.ShowDialog() == DialogResult.OK)
             {
                int cuenta_id = loginForm.cuenta_id;

                Menu elmenu = new Menu(cuenta_id);
                Application.Run(elmenu);
             }
        }
    }

}
