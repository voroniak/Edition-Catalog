using System;
using System.Windows.Forms;

namespace EditionCatalog.CMD
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadForm loadForm = new LoadForm();
            DateTime timeLoad = DateTime.Now + TimeSpan.FromSeconds(4);
            loadForm.Show();
            //loadForm.Loading(40);
            // System.Threading.Thread.Sleep(5000);
            while (timeLoad > DateTime.Now)
            {
               Application.DoEvents();
            }
            loadForm.Close();
            loadForm.Dispose();
            Application.Run(new MainForm());
        }
    }
}
