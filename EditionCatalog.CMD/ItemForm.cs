﻿using System;
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
            FillInTextBoxes(MainForm.EditionController[elementIndex].ToString());
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
