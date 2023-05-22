using El_Flautista_de_Hamelin.Models;

namespace El_Flautista_de_Hamelin
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();

            Login loginForm = new Login();
            Application.Run(loginForm);

            loginForm.FormClosing += (sender, e) => {
                if (loginForm.user_id < 0)
                {
                    Application.Exit();
                }else {
                    //Menu menuForm = new Menu();
                    //menuForm.Show();
                }
            };
        }
    }

}