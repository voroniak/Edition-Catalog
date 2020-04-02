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
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridView1.EnableHeadersVisualStyles = false;
        }
        static MainForm()
        {
            EditionController = new EditionController();
            UpdatedEditionData = (new List<string>(),0);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditionController.Clear();
            dataGridView1.Rows.Clear();
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
                dataGridView1.Rows.Add(edition.ToString().Split('\t'));
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
            UpdateOption();
        }

        private void UpdateOption()
        {
            if (EditionController.Count == 0) return;
            var index = dataGridView1.CurrentCell.RowIndex;
            EditionType editionType = EditionType.Book;
           
            switch (EditionController[index])
            {
                case Book _:
                    UpdatedEditionData = (((Book)EditionController[index]).ToString().Split('\t').ToList(), index);
                    editionType = EditionType.Book;
                    break;
                case Magazine _:
                    UpdatedEditionData = (((Magazine)EditionController[index]).ToString().Split('\t').ToList(), index);
                    editionType = EditionType.Magazine;
                    break;
                default:
                    return;
            }
            
            ItemForm itemForm = new ItemForm(editionType, index);
            itemForm.ShowDialog();
            dataGridView1.Rows.Clear();
            EditionController.UpdateEdition(UpdatedEditionData.Item1.ToArray(), UpdatedEditionData.Item2);
            FillInDataGridView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteOption();
        }

        private void DeleteOption()
        {
            if(dataGridView1.Rows.Count == 0)return;
            if (EditionController.Count == 0) return;
            var index = dataGridView1.CurrentCell.RowIndex;
            if (EditionController.Count <= index) return;
            if (MessageBox.Show("Are you sure ?", "DELETE", MessageBoxButtons.YesNoCancel) == DialogResult.No) return;
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

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddNewEdition(EditionType.Book);
        }

        private void AddMagazineButton_Click(object sender, EventArgs e)
        {
            AddNewEdition(EditionType.Magazine);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteOption();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateOption();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0,0);
            Size = new Size(w,h);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            List<string> types = (from object s in TypesListBox.CheckedItems select s.ToString()).ToList();
            var authorName = AuothorNameTextBox.Text;
            double minPrice = 0;
            double maxPrice = EditionController.MaxPrice();
            int minYear = 0;
            int maxYear = EditionController.MaxYear();
            if (!string.IsNullOrEmpty(MinPriceTextBox.Text))
            {
                minPrice = Double.Parse(MinPriceTextBox.Text);
            }
            if (!string.IsNullOrEmpty(MaxPriceTextBox.Text))
            {
                maxPrice = Double.Parse(MaxPriceTextBox.Text);
            }
            if (!string.IsNullOrEmpty(MaxYearTextBox.Text))
            {
                maxYear = Int32.Parse(MaxYearTextBox.Text);
            }
            if (!string.IsNullOrEmpty(MinYearTextBox.Text))
            {
                minYear = Int32.Parse(MinYearTextBox.Text);
            }
            List<Edition> editions = new List<Edition>();
            switch (types.Count)
            {
                case 1:
                    switch (types[0])
                    {
                        case "Magazines":
                            editions.AddRange(EditionController.OfType<Magazine>());
                            break;
                        case "Books":
                            editions.AddRange(EditionController.OfType<Book>());
                            break;
                    }
                    break;
                case 2:
                    editions.AddRange(EditionController.OfType<Edition>());
                    break;
                case 0:
                    editions.AddRange(EditionController.OfType<Edition>());
                    break;
            }

            if (!string.IsNullOrEmpty(authorName))
            {
                editions = editions.Where(edition => edition.Author.Name == authorName).ToList();
            }
            editions = editions.Where(edition => edition.Price >= minPrice && edition.Price <= maxPrice).ToList();
            editions = editions.Where(edition => edition.YearOfPublishing>= minYear && edition.YearOfPublishing <= maxYear).ToList();
            dataGridView1.Rows.Clear();
            foreach (var edition in editions)
            {
                dataGridView1.Rows.Add(edition.ToString().Split('\t'));
            }

        }

        private void ChangeVisibleOfBSortMenuButton_Click(object sender, EventArgs e)
        {
            if (SelectPanel.Visible)
            {
                SelectPanel.Visible = false;
                ChangeVisibleOfBSortMenuButton.Text = "Open sorting menu";
                return;
            }
            SelectPanel.Visible = true;
            ChangeVisibleOfBSortMenuButton.Text = "Close sorting menu";
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row  in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.DimGray;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }
    }
}
