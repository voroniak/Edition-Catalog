using System;
using System.Windows.Forms;

namespace EditionCatalog.CMD
{
    public partial class DiscountForm : Form
    {
        private int discount;
        public DiscountForm()
        {
            InitializeComponent();
        }

        private void buttonClickToWin_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            discount = random.Next(0, 40);
            labelWinSum.Text = $"Сongratulations, you have won a {discount} percent discount";
            buttonApply.Visible = true;
            buttonClickToWin.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            MainForm.BookShelf.MakeDiscount(discount);
            Close();
        }
    }
}
