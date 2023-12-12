using Clinic.Forms;

namespace Clinic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using var loginForm = new LoginForm()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var mainForm = new MainForm();
                mainForm.user = loginForm.user;

                Application.Run(mainForm);
            }
        }
    }
}