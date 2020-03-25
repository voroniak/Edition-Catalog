using EditionCatalog.BL.Controller;
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
    public partial class Form1 : Form
    {
        public static EditionController _editionController { get; } = new EditionController();
        public Form1()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
           var res = _editionController.Load(fileText);
            for(int i =0; i< res.Count; i++)
            {
                dataGridView1.Rows.Add(res[i].Split('\t'));
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.ShowDialog();
           if( itemForm.DialogResult == DialogResult.OK)
            {
                var res = itemForm.EditionData;
                dataGridView1.Rows.Add(res);
                //itemForm.Close();
            }
                
           
        }
    }
}
