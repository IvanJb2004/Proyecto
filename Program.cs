namespace Proyecto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Inicio frmLogin = new Inicio();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                Inicio menu = new Inicio();
                Application.Run(new Inicio());
            }

        }
    }
}