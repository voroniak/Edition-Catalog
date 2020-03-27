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
    public partial class MainForm : Form
    {
      
        public static EditionController EditionController { get; }
        public static (List<string>, int) UpdatedEditionData;
        private string _fileName;
        public MainForm()
        {
            InitializeComponent();
            _fileName = "edition.txt";
        }
        static MainForm()
        {
            EditionController = new EditionController();
            UpdatedEditionData = (new List<string>(),0);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditionController.Clear(); dataGridView1.Rows.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return; 
            _fileName = openFileDialog1.FileName; 
            string fileText = System.IO.File.ReadAllText(_fileName);
            EditionController.Load(fileText);
            FillInDataGridView();
        }

        private void FillInDataGridView()
        {
            foreach (var edition in EditionController)
            {
                dataGridView1.Rows.Add(((Edition)edition).ToString().Split('\t'));
            }
        }
        public static void AddNewRow(string [] editionData, EditionType editionType)
        {
            switch (editionType)
            {
                case EditionType.Book:
                    EditionController.AddBook(editionData[0],
                        editionData[1],
                        int.Parse(editionData[2]),
                        int.Parse(editionData[3]),
                        double.Parse(editionData[4]),
                        editionData[5]); 
                    break;
                case EditionType.Magazine:
                    EditionController.AddMagazine(editionData[0],
                        editionData[1],
                        int.Parse(editionData[2]),
                        int.Parse(editionData[3]),
                        double.Parse(editionData[4]),
                        int.Parse(editionData[5]),
                        int.Parse(editionData[6]));
                    break;
            }
        }
       

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewEdition(EditionType.Book);
        }

        private void magazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewEdition(EditionType.Magazine);
        }
        private void AddNewEdition(EditionType editionType)
        {
            int countBefore = EditionController.Count;
            ItemForm itemForm = new ItemForm(editionType);
            itemForm.ShowDialog();
            if (countBefore != EditionController.Count)
            {
                dataGridView1.Rows.Add(EditionController.Last().ToString().Split('\t'));
            }
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string resultText = string.Empty;
            foreach(var edition in EditionController)
            {
                switch (edition)
                {
                    case Book _:
                        resultText += "1\t";
                        resultText += edition.ToString();
                        resultText = resultText.Substring(0, resultText.Length-1) + "\n";
                        break;
                    case Magazine _:
                        resultText += "0\t";
                        resultText += edition.ToString();
                        resultText =resultText.Substring(0, resultText.Length-1) +"\n";
                        break;
                }
            }
            System.IO.File.WriteAllText(_fileName, resultText);
            MessageBox.Show("Saved");
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(EditionController.Count == 0)return;
            var index = dataGridView1.CurrentCell.RowIndex;
            EditionType editionType = EditionType.Book;
            UpdatedEditionData = (EditionController[index].ToString().Split('\t').ToList(), index);
            switch (EditionController[index])
            {
                case Book _:
                    editionType = EditionType.Book;
                    break;
                case Magazine _:
                    editionType = EditionType.Magazine;
                    break;
            }

            ItemForm itemForm = new ItemForm(editionType, index);
            itemForm.ShowDialog();
            dataGridView1.Rows.Clear();
            EditionController.UpdateEdition(UpdatedEditionData.Item1.ToArray(), UpdatedEditionData.Item2);
            FillInDataGridView();
        }

       

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var index = dataGridView1.CurrentCell.RowIndex;
            if (EditionController.Count == 0) return;
            if(EditionController.Count <= index)return;
            if(MessageBox.Show("Are you sure ?","DELETE",MessageBoxButtons.YesNoCancel) == DialogResult.No)return; 
            EditionController.RemoveAtIndex(index);
            dataGridView1.Rows.Clear();
            FillInDataGridView();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            EditionController.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
