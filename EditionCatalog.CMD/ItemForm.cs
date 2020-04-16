using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EditionCatalog.BL.Controller;

namespace EditionCatalog.CMD
{
    public partial class ItemForm : Form
    {
        private readonly List<string> _labelNames = new List<string> { "Author", "Name", "Count of pages", "Year of publishing", "Price" };
        private readonly List<string> _bookLabelNames = new List<string> { "Genre" };
        private readonly List<string> _magazineLabelNames = new List<string> { "Periodical per month", "Number" };
        private static readonly List<TextBox> _textBoxes = new List<TextBox>();
        private readonly List<Label> _labels = new List<Label>();
        private readonly EditionType _editionType;
        private readonly SaveButtonType _saveButtonType;
        private readonly int _elementIndex;
        public ItemForm(EditionType editionType)
        {
            _editionType = editionType;
            _saveButtonType = SaveButtonType.Add;
            InitializeComponent();
            switch (_editionType)
            {
                case EditionType.Book:
                    AddTextBoxes(6);
                    AddLabel();
                    break;
                case EditionType.Magazine:
                    AddTextBoxes(7);
                    AddLabel();
                    break;
            }
            OnChange();
        }

        public ItemForm(EditionType editionType, int elementIndex):this(editionType)
        {
            _saveButtonType = SaveButtonType.Update;
            _elementIndex = elementIndex;
            FillInTextBoxes(MainForm.EditionController[elementIndex].ToString());
        }

        private  void FillInTextBoxes(string editionData)
        {
            var data = editionData.Split('\t');
            for (int i = 0; i < (_editionType == EditionType.Book ? 6 : 7); i++)
            {
                _textBoxes[i].Text = data[i];
            }
            
        }

        public void AddTextBoxes(int count)
        {
            int x = 600;
            int y = 110;
            for (int i = 0; i < count; i++)
            {
                TextBox textBox = new TextBox {Location = new Point(x, y), Size = new Size(200, 30), BackColor = Color.Wheat };
                _textBoxes.Add(textBox);
                Controls.Add(_textBoxes[i]);
                y += 50;
            }
        }
        private void SetLabel(List<string> labels, ref int h)
        {
            foreach (var lb in labels)
            {
                Label label = new Label
                {
                    Text = lb, Location = new Point(440, h), Size = new Size(160, 30), ForeColor = Color.Black,
                    Font = new Font("Tobota", 12, System.Drawing.FontStyle.Bold), BackColor = Color.Transparent,
                    //BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                    TextAlign = ContentAlignment.BottomCenter
                };
                h += 50;
                _labels.Add(label);
                Controls.Add(label);
            }
        }
        private void AddLabel()
        {
            int h = 100;
            SetLabel(_labelNames, ref h);
            switch (_editionType)
            {
                case EditionType.Book:
                    SetLabel(_bookLabelNames, ref h);
                    break;
                case EditionType.Magazine:
                    SetLabel(_magazineLabelNames, ref h);
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (_saveButtonType)
            {
                case SaveButtonType.Add:
                    switch (MessageBox.Show("Are you sure?", "ADD", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.No:
                            Close();
                            break;
                        case DialogResult.Cancel:
                            return;
                        case DialogResult.Yes:
                            MainForm.AddNewRow(_textBoxes.Select(textBox => textBox.Text).ToArray(), _editionType);
                            _textBoxes.Clear();
                            Close();
                            break;

                    }
                    break;
                case SaveButtonType.Update:
                    switch (MessageBox.Show("Are you sure?", "UPDATE", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.No:
                            Close();
                            break;
                        case DialogResult.Cancel:
                            return;
                        case DialogResult.Yes:
                            MainForm.UpdatedEditionData = (GetDataFromTextBoxes().ToList(), _elementIndex);
                            _textBoxes.Clear();
                            Close();
                            break;

                    }
                    break;
                case SaveButtonType.Delete:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static string[] GetDataFromTextBoxes()
        {
            return _textBoxes.Select(textBox => textBox.Text).ToArray();
        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
             Validation(_textBoxes[0], "[^A-Z-a-z-А-Я-а-я- ]");
        }
        private void textBoxEditionName_TextChanged(object sender, EventArgs e)
        {
            Validation(_textBoxes[1], "[^A-Z-a-z-А-Я-а-я- ]");

        }
        private void textBoxCountIfPages_TextChanged(object sender, EventArgs e)
        {
            Validation(_textBoxes[2], "[^0-9]");
        }
        private void textBoxYearOfPublishing_TextChanged(object sender, EventArgs e)
        {
            Validation(_textBoxes[3], "[^0-9]");
        }
        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(_textBoxes[4].Text, "[^0-9-,]"))
            {
                if (_textBoxes[4].Text[_textBoxes[4].TextLength - 1] != '.')
                {
                    _textBoxes[4].Text = _textBoxes[4].Text.Remove(_textBoxes[4].Text.Length - 1);
                    _textBoxes[4].SelectionStart = _textBoxes[4].TextLength;
                }
            }
            if (_textBoxes[4].Text.Length == 0) return;
            if (_textBoxes[4].Text[_textBoxes[4].TextLength - 1] == '.')
            {
                _textBoxes[4].Text = _textBoxes[4].Text.Replace('.', ',');
                _textBoxes[4].SelectionStart = _textBoxes[4].TextLength;
            }
            if (_textBoxes[4].Text[_textBoxes[4].TextLength - 1] != ',') return;
            if (_textBoxes[4].Text.Count(letter => letter == ',') <= 1) return;
            _textBoxes[4].Text = _textBoxes[4].Text.Remove(_textBoxes[4].Text.Length - 1);
            _textBoxes[4].SelectionStart = _textBoxes[4].TextLength;

        }
        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
           Validation(_textBoxes[5], "[^A-Z-a-z-А-Я-а-я- ]");
        }
        private void textBoxPeriodical_TextChanged(object sender, EventArgs e)
        {
            Validation(_textBoxes[5], "[^0-9]");
        }
        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            Validation(_textBoxes[6], "[^0-9]");
        }
        private  void Validation(TextBox textBox, string pattern)
        {
            if (Regex.IsMatch(textBox.Text, pattern))
            {
                if (textBox.Text != "i")
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.TextLength;
                }
            }
        }
        private  void OnChange()
        {
         _textBoxes[0].TextChanged += new EventHandler(textBoxAuthor_TextChanged);
         _textBoxes[1].TextChanged += new EventHandler(textBoxEditionName_TextChanged);
         _textBoxes[2].TextChanged += new EventHandler(textBoxCountIfPages_TextChanged);
         _textBoxes[3].TextChanged += new EventHandler(textBoxYearOfPublishing_TextChanged);
         _textBoxes[4].TextChanged += new EventHandler(textBoxPrice_TextChanged);
         switch (_editionType)
         {
             case EditionType.Book:
                 _textBoxes[5].TextChanged += new EventHandler(textBoxGenre_TextChanged);
                    break;
             case EditionType.Magazine:
                 _textBoxes[5].TextChanged += new EventHandler(textBoxPeriodical_TextChanged);
                 _textBoxes[6].TextChanged += new EventHandler(textBoxNumber_TextChanged);
                 break;
         }
        }
        private enum SaveButtonType
        {
            Add,
            Update,
            Delete
        }

    }

}
