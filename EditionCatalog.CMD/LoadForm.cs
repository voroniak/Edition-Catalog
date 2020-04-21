using System;
using System.Windows.Forms;

namespace EditionCatalog.CMD
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value +=10;
            if (progressBar1.Value == 100) { timer1.Stop(); }
        }

       
    }
}
