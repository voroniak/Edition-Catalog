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
    public partial class GraphForm : Form
    {
        private Graph _graph;
        public GraphForm(Graph graph)
        {
            _graph = graph;
            InitializeComponent();
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
          
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           //chart1.Series[0].Points.AddXY();
        }
    }

  public enum Graph
  {
        BooksCountToAuthor,
        EditionsPrice,
        BooksToMagazine,
        YearOfPublishing
  }
}
