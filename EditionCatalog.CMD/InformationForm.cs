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
    public partial class InformationForm : Form
    {
        private const string AboutAuthorText =
            "Hi, my name is Oleh. I am really big books fan, hope you too. It's my first real  useful windows forms application. Contact me to cooperate \n oleg.voronyakk@gmail.com";
        public InformationForm(InformationType informationType)
        {
            InitializeComponent();
            switch (informationType)
            {
                case InformationType.AboutAuthor:
                    InformationLabel.Text = AboutAuthorText;
                    break;
                case InformationType.ViewHelp:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public enum InformationType
    {
        AboutAuthor,
        ViewHelp
    }
}
