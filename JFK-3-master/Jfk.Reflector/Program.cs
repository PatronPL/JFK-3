namespace Jfk.Reflector
{
    using System;
    using System.Windows.Forms;

    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var mainForm = new MainForm())
            {
                Application.Run(mainForm);
            }
        }
    }
}
