namespace EditionCatalog.CMD
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfPublishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СountOfPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuButton,
            this.ItemMenuButton,
            this.HelpMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // FileMenuButton
            // 
            this.FileMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.FileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileMenuButton.ForeColor = System.Drawing.Color.White;
            this.FileMenuButton.Image = global::EditionCatalog.CMD.Properties.Resources.Terry;
            this.FileMenuButton.Name = "FileMenuButton";
            this.FileMenuButton.Size = new System.Drawing.Size(66, 24);
            this.FileMenuButton.Text = "File";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.createNewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.createNewToolStripMenuItem.Text = "Create new";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Image = global::EditionCatalog.CMD.Properties.Resources.delete;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ItemMenuButton
            // 
            this.ItemMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ItemMenuButton.ForeColor = System.Drawing.Color.White;
            this.ItemMenuButton.Name = "ItemMenuButton";
            this.ItemMenuButton.Size = new System.Drawing.Size(53, 24);
            this.ItemMenuButton.Text = "Item";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.magazineToolStripMenuItem});
            this.addNewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.addNewToolStripMenuItem.Text = "Add new";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.bookToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // magazineToolStripMenuItem
            // 
            this.magazineToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.magazineToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.magazineToolStripMenuItem.Name = "magazineToolStripMenuItem";
            this.magazineToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.magazineToolStripMenuItem.Text = "Magazine";
            this.magazineToolStripMenuItem.Click += new System.EventHandler(this.magazineToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // HelpMenuButton
            // 
            this.HelpMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutAuthorToolStripMenuItem});
            this.HelpMenuButton.ForeColor = System.Drawing.Color.White;
            this.HelpMenuButton.Name = "HelpMenuButton";
            this.HelpMenuButton.Size = new System.Drawing.Size(55, 24);
            this.HelpMenuButton.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.viewHelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.viewHelpToolStripMenuItem.Text = "View help";
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.aboutAuthorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.aboutAuthorToolStripMenuItem.Text = "About author";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.BookName,
            this.YearOfPublishing,
            this.СountOfPages,
            this.Price});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(20, 50);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(800, 300);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(600, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::EditionCatalog.CMD.Properties.Resources.MesOK;
            this.pictureBox3.Location = new System.Drawing.Point(826, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::EditionCatalog.CMD.Properties.Resources.terry1;
            this.pictureBox1.Location = new System.Drawing.Point(1070, 50);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(500, 500);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(300, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Author
            // 
            this.Author.FillWeight = 200F;
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 120;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // YearOfPublishing
            // 
            this.YearOfPublishing.HeaderText = "Year  of publishing";
            this.YearOfPublishing.MinimumWidth = 6;
            this.YearOfPublishing.Name = "YearOfPublishing";
            this.YearOfPublishing.ReadOnly = true;
            // 
            // СountOfPages
            // 
            this.СountOfPages.HeaderText = "Сount of pages";
            this.СountOfPages.MinimumWidth = 6;
            this.СountOfPages.Name = "СountOfPages";
            this.СountOfPages.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1382, 603);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1400, 650);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuButton;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuButton;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazineToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfPublishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn СountOfPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

