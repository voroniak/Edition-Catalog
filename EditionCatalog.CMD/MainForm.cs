using EditionCatalog.BL.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace EditionCatalog.CMD
{
    public partial class MainForm : Form
    {
        public static BookShelf BookShelf { get; }
        public static (List<string>, int) UpdatedEditionData;
        private List<Edition> _sortedEditions;
        private string _fileName;
        private bool _isApplied;
        private bool _isCreateNew;
        public MainForm()
        {
            InitializeComponent();
            _fileName = "edition.txt";
            _isApplied = false;
            _sortedEditions = new List<Edition>();
            dataGridViewSetting();
            _isCreateNew = false;
        }
        private void dataGridViewSetting()
        {
            WindowState = FormWindowState.Maximized;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bell MT", 12);
            dataGridView1.DefaultCellStyle.Font = new Font("Bell MTf", 12);
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 36, 41);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 36, 41);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridView1.EnableHeadersVisualStyles = false;
        }
        static MainForm()
        {
            BookShelf = new BookShelf();
            UpdatedEditionData = (new List<string>(),0);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookShelf.Clear();
            dataGridView1.Rows.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return; 
            _fileName = openFileDialog1.FileName; 
            string fileText = System.IO.File.ReadAllText(_fileName);
            BookShelf.Load(fileText);
            FillInDataGridView();
            _isApplied = false;
        }
        private void FillInDataGridView()
        {
            foreach (var edition in BookShelf)
            {
                dataGridView1.Rows.Add(edition.ToString().Split('\t'));
            }
        }
        public static void AddNewRow(string [] editionData, EditionType editionType)
        {
            switch (editionType)
            {
                case EditionType.Book:
                    BookShelf.AddBook(editionData[0],
                        editionData[1],
                        int.Parse(editionData[2]),
                        int.Parse(editionData[3]),
                        double.Parse(editionData[4]),
                        editionData[5]); 
                    break;
                case EditionType.Magazine:
                    BookShelf.AddMagazine(editionData[0],
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
            int countBefore = BookShelf.Count;
            ItemForm itemForm = new ItemForm(editionType);
            itemForm.ShowDialog();
            if (countBefore != BookShelf.Count)
            {
                dataGridView1.Rows.Add(BookShelf.Last().ToString().Split('\t'));
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.IO.File.WriteAllText(_fileName, SaveToTxt());
                MessageBox.Show("Saved");
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = " *.txt";
            saveFileDialog1.Filter = "txt file(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveFileDialog1.OpenFile();
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    sw.Write(SaveToTxt());
                }
                MessageBox.Show("Saved");
            }
        }
        private string SaveToTxt()
        {
            string resultText = string.Empty;
            foreach (var edition in BookShelf)
            {
                switch (edition)
                {
                    case Book _:
                        resultText += "1\t";
                        resultText += edition.ToString();
                        resultText = resultText.Substring(0, resultText.Length) + "\n";
                        break;
                    case Magazine _:
                        resultText += "0\t";
                        resultText += edition.ToString();
                        resultText = resultText.Substring(0, resultText.Length) + "\n";
                        break;
                }
            }
            return resultText;
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOption();
        }
        private void UpdateOption()
        {
            if (BookShelf.Count == 0) return;
            var index = dataGridView1.CurrentCell.RowIndex;
            EditionType editionType = EditionType.Book;
           
            switch (BookShelf[index])
            {
                case Book _:
                    UpdatedEditionData = (((Book)BookShelf[index]).ToString().Split('\t').ToList(), index);
                    editionType = EditionType.Book;
                    break;
                case Magazine _:
                    UpdatedEditionData = (((Magazine)BookShelf[index]).ToString().Split('\t').ToList(), index);
                    editionType = EditionType.Magazine;
                    break;
                default:
                    return;
            }
            ItemForm itemForm = new ItemForm(editionType, index);
            itemForm.ShowDialog();
            dataGridView1.Rows.Clear();
            BookShelf.UpdateEdition(UpdatedEditionData.Item1.ToArray(), UpdatedEditionData.Item2);
            FillInDataGridView();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteOption();
        }
        private void DeleteOption()
        {
            if(dataGridView1.Rows.Count == 0)return;
            if (BookShelf.Count == 0) return;
            var index = dataGridView1.CurrentCell.RowIndex;
            if (BookShelf.Count <= index) return;
            if (MessageBox.Show("Are you sure ?", "DELETE", MessageBoxButtons.YesNo) == DialogResult.No) return;
            BookShelf.RemoveAtIndex(index);
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
            BookShelf.Clear();
            //_fileName = $"text_{DateTime.Now.ToString()}.txt";
            _isCreateNew = true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0,0);
            Size = new Size(w,h);
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row  in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(33, 36, 41);
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }
        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm(InformationType.AboutAuthor);
            informationForm.Show();
        }
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm(InformationType.ViewHelp);
            informationForm.Show();
        }
        private void hideMenu()
        {
            if (panelAdd.Visible)
            {
                panelAdd.Visible = false;
            }
            if (panelUpdate.Visible)
            {
                panelUpdate.Visible = false;
            }

            if (panelSort.Visible)
            {
                panelSort.Visible = false;
            }
        }

        private void showMenu(Panel panel)
        {
            if (!panel.Visible)
            {
                hideMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
           showMenu(panelAdd);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           UpdateOption();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            showMenu(panelSort);
        }
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddNewEdition(EditionType.Book);
        }
        private void buttonAddMagazine_Click(object sender, EventArgs e)
        {
            AddNewEdition(EditionType.Magazine);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteOption();
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)return;
            _isApplied = true;
            _sortedEditions = new List<Edition>();
            List<string> types = (from object s in checkedListBoxSelectType.CheckedItems select s.ToString()).ToList();
            var authorName = textBoxAuthorName.Text;
            double minPrice = 0;
            double maxPrice = BookShelf.MaxPrice;
            int minYear = 0;
            int maxYear = BookShelf.MaxYear;
            if (!string.IsNullOrEmpty(textBoxMinPriceValue.Text))
            {
                minPrice = double.Parse(textBoxMinPriceValue.Text);
            }
            if (!string.IsNullOrEmpty(textBoxMaxPriceValue.Text))
            {
                maxPrice = double.Parse(textBoxMinYearValue.Text);
            }
            if (!string.IsNullOrEmpty(textBoxMaxYearValue.Text))
            {
                maxYear = int.Parse(textBoxMaxYearValue.Text);
            }
            if (!string.IsNullOrEmpty(textBoxMinYearValue.Text))
            {
                minYear = int.Parse(textBoxMinYearValue.Text);
            }
            switch (types.Count)
            {
                case 1:
                    switch (types[0])
                    {
                        case "Magazines":
                            _sortedEditions.AddRange(BookShelf.OfType<Magazine>());
                            break;
                        case "Books":
                            _sortedEditions.AddRange(BookShelf.OfType<Book>());
                            break;
                    }
                    break;
                case 2:
                    _sortedEditions.AddRange(BookShelf.OfType<Edition>());
                    break;
                case 0:
                    _sortedEditions.AddRange(BookShelf.OfType<Edition>());
                    break;
            }
            if (!string.IsNullOrEmpty(authorName))
            {
                _sortedEditions = _sortedEditions.Where(edition => edition.Author.Name == authorName).ToList();
            }
            _sortedEditions = _sortedEditions.Where(edition => edition.Price >= minPrice && edition.Price <= maxPrice).ToList();
            _sortedEditions = _sortedEditions.Where(edition => edition.YearOfPublishing >= minYear && edition.YearOfPublishing <= maxYear).ToList();
            dataGridView1.Rows.Clear();
            switch (types.Count)
            {
                case 1:
                    switch (types[0])
                    {
                        case "Books":
                            RemoveNotBaseColumns();
                            dataGridView1.Columns.Add("Genre", "Genre");
                            break;
                        case "Magazines":
                            RemoveNotBaseColumns();
                            dataGridView1.Columns.Add("Periodical per month", "Periodical per month");
                            dataGridView1.Columns.Add("Number", "Number");
                            break;
                    }
                    break;
                case 2:
                case 0:
                    RemoveNotBaseColumns();
                    break;
            }
            foreach (var edition in _sortedEditions)
            { 
                dataGridView1.Rows.Add(edition.ToString().Split('\t'));
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_isApplied)
            {
                BookShelf.Clear();
                BookShelf.AddRange(_sortedEditions.ToArray());
                _sortedEditions = new List<Edition>();
            }
            _isApplied = false;

        }
        private void RemoveNotBaseColumns()
        {
            while (dataGridView1.Columns.Count != 5)
            {
                dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            }
        }
        private void buttonGraph_Click(object sender, EventArgs e)
        {
            if (!panelGraph.Visible)
            {
                panelGraph.Visible = true;
                return;
            }
            panelGraph.Visible = false;
        }
        private void buttonGraphEachAuthorBookCount_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new GraphForm(Graph.BooksCountToAuthor);
            graphForm.Show();
        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            DiscountForm discountForm = new DiscountForm();
            discountForm.ShowDialog();
            dataGridView1.Rows.Clear();
            FillInDataGridView();
            buttonDiscount.Visible = false;
        }
    }
}
