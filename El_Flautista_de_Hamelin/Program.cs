using El_Flautista_de_Hamelin.Views;

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
                int userId = loginForm.user_id;
                Select homeForm = new Select(userId);
                Application.Run(homeForm);
            }

        }
    }

}