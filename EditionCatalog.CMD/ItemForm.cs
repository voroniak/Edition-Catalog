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
        /// int periodicalPerMonth,
        //                int number)
        private List<string> _labelNames = new List<string> { "Author", "Name", "Count of pages", "Year of publishing", "Price" };
        private List<string> _bookLabelNames = new List<string> { "Genre" };
        private List<string> _magazineLabelNames = new List<string> { "Periodical per month", "Number" };
        private bool _type;
        private List<TextBox> _textBoxes = new List<TextBox>();
        private List<Label> _labels = new List<Label>();
        public ItemForm()
        {
            InitializeComponent();
            TextBox textBox = new TextBox();
            textBox.SetBounds(10, 10, 10, 10);
        }
        public ItemForm(bool type)
        {
            _type = type;
            InitializeComponent();
            
            
            if (_type)
            {
                AddTextBoxes(6);
                AddLabel(_type);
            }
            else
            {
                AddTextBoxes(7);
                AddLabel(_type);
            }
            
           
            //this.Controls.Add(textBox);
            
        }
        public void AddTextBoxes(int count)
        {
            int w = 250;
            int h = 50;
            for (int i = 0; i < count; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(w, h);
                textBox.Size = new Size(200, 22);
                _textBoxes.Add(textBox);
                Controls.Add(_textBoxes[i]);
                h += 50;


            }
        }
        private void SetLabel(List<string> labels, ref int h)
        {
            for (int i = 0; i < labels.Count; i++)
            {

                Label label = new Label();
                label.Text = labels[i];
                label.Location = new Point(100, h);
                h += 50;
                Controls.Add(label);
            }
        }
        private void AddLabel(bool type)
        {
            int h = 50;
            SetLabel(_labelNames, ref h);
            if (type)
            {
                SetLabel(_bookLabelNames, ref h);
            }
            else
            {
                SetLabel(_magazineLabelNames, ref h);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> editionData = new List<string>();
            foreach(var textBox in _textBoxes)
            {
              editionData.Add(textBox.Text);
            }
            if (_type)
            {
               Form1.AddNewRow(editionData.ToArray(), true);
            }
            else
            {
                Form1.AddNewRow(editionData.ToArray(), false);
            }
           
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
