using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private readonly List<TextBox> _textBoxes = new List<TextBox>();
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
        }

        public ItemForm(EditionType editionType, int elementIndex):this(editionType)
        {
            _saveButtonType = SaveButtonType.Update;
            _elementIndex = elementIndex;
            FillInTextBoxes(Form1.EditionController[elementIndex].ToString());
        }

        private void FillInTextBoxes(string editionData)
        {
            var data = editionData.Split('\t');
            for (int i = 0; i < _textBoxes.Count; i++)
            {
                _textBoxes[i].Text = data[i];
            }
        }

        public void AddTextBoxes(int count)
        {
            int x = 250;
            int y = 50;
            for (int i = 0; i < count; i++)
            {
                TextBox textBox = new TextBox {Location = new Point(x, y), Size = new Size(200, 22)};
                _textBoxes.Add(textBox);
                Controls.Add(_textBoxes[i]);
                y += 50;
            }
        }
        private void SetLabel(List<string> labels, ref int h)
        {
            for (int i = 0; i < labels.Count; i++)
            {

                Label label = new Label
                {
                    Text = labels[i], Location = new Point(100, h), Size = new Size(100, 30), ForeColor = Color.Red
                };
                h += 50;
                _labels.Add(label);
                Controls.Add(label);
            }
        }
        private void AddLabel()
        {
            int h = 50;
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
                    Form1.AddNewRow(_textBoxes.Select(textBox => textBox.Text).ToArray(), _editionType);
                    break;
                case SaveButtonType.Update:
                    
                    string[] editionData = GetDataFromTextBoxes();
                    Form1.UpdateRow(editionData,_editionType,_elementIndex);
                    break;
                case SaveButtonType.Delete:
                    break;
            }

            Close();
        }

        private string[] GetDataFromTextBoxes()
        {
            return _textBoxes.Select(textBox => textBox.Text).ToArray();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        enum SaveButtonType
        {
            Add,
            Update,
            Delete
        }
    }

}
