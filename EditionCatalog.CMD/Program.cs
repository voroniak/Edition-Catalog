using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            loadForm.Show();
            loadForm.Loading(40);
            Application.Run(new MainForm());
        }
    }
}
