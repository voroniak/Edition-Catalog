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
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }
        public string[] EditionData { get; set; } = new string[] { };
        private void button1_Click(object sender, EventArgs e)
        {
          // Form1._editionController.AddBook(textBox1.Text)
            EditionData = new string[] {textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text};
            Close();
        }
    }
}
