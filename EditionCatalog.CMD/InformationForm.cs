using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            "Hi, my name is Oleh. I am really big books fan, hope you too. It's my first real  useful windows forms application. Contact me to cooperate \n";

        private const string HelpText = "To know more about application here";
        private readonly InformationType _informationType;
        public InformationForm(InformationType informationType)
        {
            InitializeComponent();
            switch (informationType)
            {
                case InformationType.AboutAuthor:
                    _informationType = InformationType.AboutAuthor;
                    break;
                case InformationType.ViewHelp:
                    _informationType = InformationType.ViewHelp;
                    break;
            }
            SetAs();
        }
        private void SetAs()
        {
            Label info = new Label();
            LinkLabel linkLabel = new LinkLabel();
            info.Font = new Font("Tobota", 12, System.Drawing.FontStyle.Bold);
            info.ForeColor = Color.White;
            linkLabel.Font = new Font("Tobota", 12, System.Drawing.FontStyle.Bold);
            linkLabel.ForeColor = Color.White;
            switch (_informationType)
            {
                case InformationType.AboutAuthor:
                    info.Size = new Size(450, 100);
                    info.Text = AboutAuthorText;
                    linkLabel.Text = "LinkedIn";
                    linkLabel.Size = new Size(250, 50);
                    linkLabel.Location = new Point(0, 100);
                    break;
                case InformationType.ViewHelp:
                    info.Size = new Size(400, 30);
                    info.Text = HelpText;
                    linkLabel.Text = "More info";
                    linkLabel.Size = new Size(100,50);
                    linkLabel.Location = new Point(0, 50);
                    break;
            }
            linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel_LinkClicked);
            Controls.Add(info);
            Controls.Add(linkLabel);
        }
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (_informationType)
            {
                case InformationType.AboutAuthor:
                    Process.Start("https://www.linkedin.com/in/oleh-voroniak-4b7ab9196/");
                    break;
                case InformationType.ViewHelp:
                    Process.Start("https://github.com/voroniak/Edition-Catalog");
                    break;
            }
        }
    }

    public enum InformationType
    {
        AboutAuthor,
        ViewHelp
    }
}
