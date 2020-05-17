using System;
using System.Windows.Forms;
using EditionCatalog.BL.Model;
namespace EditionCatalog.CMD
{
    public partial class GraphForm : Form
    {
        private readonly Graph _graph;
        public GraphForm(Graph graph)
        {
            _graph = graph;
            InitializeComponent();
            SelectType();
        }

        private void SelectType()
        {
            switch (_graph)
            {
                case Graph.BooksCountToAuthor:
                    BuildBooksCountToAuthor();
                    break;
            }
        }

        private void BuildBooksCountToAuthor()
        {

            foreach (var kv in MainForm.BookShelf.GroupBy())
            {
                chart1.Series[0].Points.AddXY(kv.Key, kv.Value);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           //chart1.Series[0].Points.AddXY();
        }
    }

}
