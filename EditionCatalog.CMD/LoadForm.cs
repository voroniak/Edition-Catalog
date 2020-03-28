using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditionCatalog.CMD
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
        
            InitializeComponent();
        }

        public void Loading(int seconds)
        {
            int time = 100 / seconds;
            for (int i = 0; i < seconds; i++)
            {
                progressBar1.Value += time;
                System.Threading.Thread.Sleep(100);
            }
            Close();
        }
       
    }
}
