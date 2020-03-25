using EditionCatalog.BL.Controller;
using EditionCatalog.BL.Model;
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
        public static EditionController _editionController { get; }
        public Form1()
        {
            InitializeComponent();
        }
         static Form1()
        {
            _editionController = new EditionController();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _editionController.Clear();
            dataGridView1.Rows.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
          _editionController.Load(fileText);
          foreach(var edition in _editionController)
          {
                dataGridView1.Rows.Add(((Edition)edition).ToString().Split('\t'));
          }
           
        }
        public static void AddNewRow(string [] editionData, bool isBook)
        {
            if (isBook)
            {
                _editionController.AddBook(editionData[0],
                                           editionData[1],
                                           Int32.Parse(editionData[2]),
                                           Int32.Parse(editionData[3]),
                                           Double.Parse(editionData[4]),
                                           "SomeGenre");
               
            }
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewEdition(true);
        }

        private void magazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewEdition(false);
        }
        private void AddNewEdition(bool type)
        {
            int countBefore = _editionController.Count;
            ItemForm itemForm = new ItemForm(type);
            itemForm.ShowDialog();
            if (countBefore != _editionController.Count)
            {
                dataGridView1.Rows.Add(_editionController.Last().ToString().Split('\t'));
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            string resultText = string.Empty;
            foreach(var edition in _editionController)
            {
                if(edition is Book)
                {
                    resultText += "1\t";
                    resultText += edition.ToString();
                    resultText = resultText.Substring(0, resultText.Length-1) + "\n";
                }
               else if (edition is Magazine)
                {
                    resultText += "0\t";
                    resultText += edition.ToString();
                    resultText =resultText.Substring(0, resultText.Length-1) +"\n";
                }
            }
            System.IO.File.WriteAllText(filename, resultText);
            MessageBox.Show("Файл сохранен");
        }

    }
}
