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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СountOfPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfPublishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSort = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMaxYearValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMinYearValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonYearOfPublishing = new System.Windows.Forms.Button();
            this.panelPriceSelection = new System.Windows.Forms.Panel();
            this.textBoxMaxPriceValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMinPriceValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.buttonAuthorName = new System.Windows.Forms.Button();
            this.checkedListBoxSelectType = new System.Windows.Forms.CheckedListBox();
            this.buttonType = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonAddMagazine = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.buttonDiscount = new System.Windows.Forms.Button();
            this.buttonGraphEachAuthorBookCount = new System.Windows.Forms.Button();
            this.buttonGraphPrice = new System.Windows.Forms.Button();
            this.buttonGraphEditionCount = new System.Windows.Forms.Button();
            this.buttonGraphYearOfPublishing = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelSort.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPriceSelection.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1482, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
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
            this.addNewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
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
            this.bookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bookToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // magazineToolStripMenuItem
            // 
            this.magazineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.magazineToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.magazineToolStripMenuItem.Name = "magazineToolStripMenuItem";
            this.magazineToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.magazineToolStripMenuItem.Text = "Magazine";
            this.magazineToolStripMenuItem.Click += new System.EventHandler(this.magazineToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
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
            this.viewHelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.viewHelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.viewHelpToolStripMenuItem.Text = "View help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.aboutAuthorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.aboutAuthorToolStripMenuItem.Text = "About author";
            this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.BookName,
            this.СountOfPages,
            this.YearOfPublishing,
            this.Price});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1800, 1000);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(600, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(759, 323);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // Author
            // 
            this.Author.FillWeight = 200F;
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // СountOfPages
            // 
            this.СountOfPages.HeaderText = "Сount of pages";
            this.СountOfPages.MinimumWidth = 6;
            this.СountOfPages.Name = "СountOfPages";
            this.СountOfPages.ReadOnly = true;
            // 
            // YearOfPublishing
            // 
            this.YearOfPublishing.HeaderText = "Year  of publishing";
            this.YearOfPublishing.MinimumWidth = 6;
            this.YearOfPublishing.Name = "YearOfPublishing";
            this.YearOfPublishing.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.panelMenu.Controls.Add(this.panelSort);
            this.panelMenu.Controls.Add(this.buttonSort);
            this.panelMenu.Controls.Add(this.buttonDelete);
            this.panelMenu.Controls.Add(this.panelUpdate);
            this.panelMenu.Controls.Add(this.buttonUpdate);
            this.panelMenu.Controls.Add(this.panelAdd);
            this.panelMenu.Controls.Add(this.buttonAdd);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 723);
            this.panelMenu.TabIndex = 10;
            // 
            // panelSort
            // 
            this.panelSort.AutoScroll = true;
            this.panelSort.Controls.Add(this.buttonApply);
            this.panelSort.Controls.Add(this.panel1);
            this.panelSort.Controls.Add(this.buttonYearOfPublishing);
            this.panelSort.Controls.Add(this.panelPriceSelection);
            this.panelSort.Controls.Add(this.buttonPrice);
            this.panelSort.Controls.Add(this.textBoxAuthorName);
            this.panelSort.Controls.Add(this.buttonAuthorName);
            this.panelSort.Controls.Add(this.checkedListBoxSelectType);
            this.panelSort.Controls.Add(this.buttonType);
            this.panelSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSort.Location = new System.Drawing.Point(0, 300);
            this.panelSort.Name = "panelSort";
            this.panelSort.Size = new System.Drawing.Size(300, 413);
            this.panelSort.TabIndex = 8;
            this.panelSort.Visible = false;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Bell MT", 12F);
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(12, 352);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(95, 44);
            this.buttonApply.TabIndex = 15;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMaxYearValue);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBoxMinYearValue);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.TabIndex = 13;
            // 
            // textBoxMaxYearValue
            // 
            this.textBoxMaxYearValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaxYearValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaxYearValue.Location = new System.Drawing.Point(200, 16);
            this.textBoxMaxYearValue.Name = "textBoxMaxYearValue";
            this.textBoxMaxYearValue.Size = new System.Drawing.Size(69, 22);
            this.textBoxMaxYearValue.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Bell MT", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(151, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "to";
            // 
            // textBoxMinYearValue
            // 
            this.textBoxMinYearValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinYearValue.Location = new System.Drawing.Point(76, 18);
            this.textBoxMinYearValue.Name = "textBoxMinYearValue";
            this.textBoxMinYearValue.Size = new System.Drawing.Size(69, 22);
            this.textBoxMinYearValue.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Bell MT", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "from";
            // 
            // buttonYearOfPublishing
            // 
            this.buttonYearOfPublishing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonYearOfPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonYearOfPublishing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYearOfPublishing.ForeColor = System.Drawing.Color.White;
            this.buttonYearOfPublishing.Location = new System.Drawing.Point(0, 230);
            this.buttonYearOfPublishing.Name = "buttonYearOfPublishing";
            this.buttonYearOfPublishing.Size = new System.Drawing.Size(300, 40);
            this.buttonYearOfPublishing.TabIndex = 12;
            this.buttonYearOfPublishing.Text = "Year of publishing";
            this.buttonYearOfPublishing.UseVisualStyleBackColor = false;
            // 
            // panelPriceSelection
            // 
            this.panelPriceSelection.Controls.Add(this.textBoxMaxPriceValue);
            this.panelPriceSelection.Controls.Add(this.label9);
            this.panelPriceSelection.Controls.Add(this.textBoxMinPriceValue);
            this.panelPriceSelection.Controls.Add(this.label7);
            this.panelPriceSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPriceSelection.Location = new System.Drawing.Point(0, 180);
            this.panelPriceSelection.Name = "panelPriceSelection";
            this.panelPriceSelection.Size = new System.Drawing.Size(300, 50);
            this.panelPriceSelection.TabIndex = 11;
            // 
            // textBoxMaxPriceValue
            // 
            this.textBoxMaxPriceValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaxPriceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaxPriceValue.Location = new System.Drawing.Point(200, 16);
            this.textBoxMaxPriceValue.Name = "textBoxMaxPriceValue";
            this.textBoxMaxPriceValue.Size = new System.Drawing.Size(69, 22);
            this.textBoxMaxPriceValue.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Bell MT", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(151, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "to";
            // 
            // textBoxMinPriceValue
            // 
            this.textBoxMinPriceValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinPriceValue.Location = new System.Drawing.Point(76, 18);
            this.textBoxMinPriceValue.Name = "textBoxMinPriceValue";
            this.textBoxMinPriceValue.Size = new System.Drawing.Size(69, 22);
            this.textBoxMinPriceValue.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Bell MT", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "from";
            // 
            // buttonPrice
            // 
            this.buttonPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrice.ForeColor = System.Drawing.Color.White;
            this.buttonPrice.Location = new System.Drawing.Point(0, 140);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(300, 40);
            this.buttonPrice.TabIndex = 7;
            this.buttonPrice.Text = "Price";
            this.buttonPrice.UseVisualStyleBackColor = false;
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.AutoCompleteCustomSource.AddRange(new string[] {
            "Book",
            "Magazine"});
            this.textBoxAuthorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxAuthorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAuthorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAuthorName.Location = new System.Drawing.Point(0, 118);
            this.textBoxAuthorName.MinimumSize = new System.Drawing.Size(100, 2);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(300, 22);
            this.textBoxAuthorName.TabIndex = 6;
            // 
            // buttonAuthorName
            // 
            this.buttonAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonAuthorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAuthorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuthorName.ForeColor = System.Drawing.Color.White;
            this.buttonAuthorName.Location = new System.Drawing.Point(0, 78);
            this.buttonAuthorName.Name = "buttonAuthorName";
            this.buttonAuthorName.Size = new System.Drawing.Size(300, 40);
            this.buttonAuthorName.TabIndex = 5;
            this.buttonAuthorName.Text = "Author Name";
            this.buttonAuthorName.UseVisualStyleBackColor = false;
            // 
            // checkedListBoxSelectType
            // 
            this.checkedListBoxSelectType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.checkedListBoxSelectType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxSelectType.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBoxSelectType.Font = new System.Drawing.Font("Bell MT", 9F);
            this.checkedListBoxSelectType.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxSelectType.FormattingEnabled = true;
            this.checkedListBoxSelectType.Items.AddRange(new object[] {
            "Magazines",
            "Books"});
            this.checkedListBoxSelectType.Location = new System.Drawing.Point(0, 40);
            this.checkedListBoxSelectType.MinimumSize = new System.Drawing.Size(250, 50);
            this.checkedListBoxSelectType.Name = "checkedListBoxSelectType";
            this.checkedListBoxSelectType.Size = new System.Drawing.Size(300, 38);
            this.checkedListBoxSelectType.TabIndex = 4;
            // 
            // buttonType
            // 
            this.buttonType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonType.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonType.ForeColor = System.Drawing.Color.White;
            this.buttonType.Location = new System.Drawing.Point(0, 0);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(300, 40);
            this.buttonType.TabIndex = 3;
            this.buttonType.Text = "Type";
            this.buttonType.UseVisualStyleBackColor = false;
            // 
            // buttonSort
            // 
            this.buttonSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.ForeColor = System.Drawing.Color.White;
            this.buttonSort.Location = new System.Drawing.Point(0, 250);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(300, 50);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(0, 200);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(300, 50);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdate.Location = new System.Drawing.Point(0, 190);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(300, 10);
            this.panelUpdate.TabIndex = 5;
            this.panelUpdate.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(0, 132);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(300, 58);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.buttonAddMagazine);
            this.panelAdd.Controls.Add(this.buttonAddBook);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdd.Location = new System.Drawing.Point(0, 50);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(300, 82);
            this.panelAdd.TabIndex = 3;
            this.panelAdd.Visible = false;
            // 
            // buttonAddMagazine
            // 
            this.buttonAddMagazine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonAddMagazine.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMagazine.ForeColor = System.Drawing.Color.White;
            this.buttonAddMagazine.Location = new System.Drawing.Point(0, 40);
            this.buttonAddMagazine.Name = "buttonAddMagazine";
            this.buttonAddMagazine.Size = new System.Drawing.Size(300, 40);
            this.buttonAddMagazine.TabIndex = 2;
            this.buttonAddMagazine.Text = "Add Magazine";
            this.buttonAddMagazine.UseVisualStyleBackColor = false;
            this.buttonAddMagazine.Click += new System.EventHandler(this.buttonAddMagazine_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBook.ForeColor = System.Drawing.Color.White;
            this.buttonAddBook.Location = new System.Drawing.Point(0, 0);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(300, 40);
            this.buttonAddBook.TabIndex = 1;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(300, 50);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(330, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 379);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.buttonDiscount);
            this.panel3.Controls.Add(this.panelGraph);
            this.panel3.Controls.Add(this.buttonGraph);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(300, 603);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 150);
            this.panel3.TabIndex = 12;
            // 
            // buttonGraph
            // 
            this.buttonGraph.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraph.ForeColor = System.Drawing.Color.White;
            this.buttonGraph.Location = new System.Drawing.Point(0, 0);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(250, 150);
            this.buttonGraph.TabIndex = 7;
            this.buttonGraph.Text = "Graph";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // panelGraph
            // 
            this.panelGraph.Controls.Add(this.buttonGraphYearOfPublishing);
            this.panelGraph.Controls.Add(this.buttonGraphEditionCount);
            this.panelGraph.Controls.Add(this.buttonGraphPrice);
            this.panelGraph.Controls.Add(this.buttonGraphEachAuthorBookCount);
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGraph.Location = new System.Drawing.Point(250, 0);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(400, 150);
            this.panelGraph.TabIndex = 8;
            this.panelGraph.Visible = false;
            // 
            // buttonDiscount
            // 
            this.buttonDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiscount.ForeColor = System.Drawing.Color.White;
            this.buttonDiscount.Location = new System.Drawing.Point(650, 0);
            this.buttonDiscount.Name = "buttonDiscount";
            this.buttonDiscount.Size = new System.Drawing.Size(532, 150);
            this.buttonDiscount.TabIndex = 9;
            this.buttonDiscount.Text = "Win the discount";
            this.buttonDiscount.UseVisualStyleBackColor = true;
            // 
            // buttonGraphEachAuthorBookCount
            // 
            this.buttonGraphEachAuthorBookCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonGraphEachAuthorBookCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGraphEachAuthorBookCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphEachAuthorBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphEachAuthorBookCount.ForeColor = System.Drawing.Color.White;
            this.buttonGraphEachAuthorBookCount.Location = new System.Drawing.Point(0, 0);
            this.buttonGraphEachAuthorBookCount.Name = "buttonGraphEachAuthorBookCount";
            this.buttonGraphEachAuthorBookCount.Size = new System.Drawing.Size(400, 40);
            this.buttonGraphEachAuthorBookCount.TabIndex = 4;
            this.buttonGraphEachAuthorBookCount.Text = "Number of books by each author";
            this.buttonGraphEachAuthorBookCount.UseVisualStyleBackColor = false;
            this.buttonGraphEachAuthorBookCount.Click += new System.EventHandler(this.buttonGraphEachAuthorBookCount_Click);
            // 
            // buttonGraphPrice
            // 
            this.buttonGraphPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonGraphPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGraphPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphPrice.ForeColor = System.Drawing.Color.White;
            this.buttonGraphPrice.Location = new System.Drawing.Point(0, 40);
            this.buttonGraphPrice.Name = "buttonGraphPrice";
            this.buttonGraphPrice.Size = new System.Drawing.Size(400, 40);
            this.buttonGraphPrice.TabIndex = 5;
            this.buttonGraphPrice.Text = "Books price";
            this.buttonGraphPrice.UseVisualStyleBackColor = false;
            // 
            // buttonGraphEditionCount
            // 
            this.buttonGraphEditionCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonGraphEditionCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGraphEditionCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphEditionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphEditionCount.ForeColor = System.Drawing.Color.White;
            this.buttonGraphEditionCount.Location = new System.Drawing.Point(0, 80);
            this.buttonGraphEditionCount.Name = "buttonGraphEditionCount";
            this.buttonGraphEditionCount.Size = new System.Drawing.Size(400, 40);
            this.buttonGraphEditionCount.TabIndex = 6;
            this.buttonGraphEditionCount.Text = "The number of books and magazines";
            this.buttonGraphEditionCount.UseVisualStyleBackColor = false;
            // 
            // buttonGraphYearOfPublishing
            // 
            this.buttonGraphYearOfPublishing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonGraphYearOfPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGraphYearOfPublishing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphYearOfPublishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphYearOfPublishing.ForeColor = System.Drawing.Color.White;
            this.buttonGraphYearOfPublishing.Location = new System.Drawing.Point(0, 120);
            this.buttonGraphYearOfPublishing.Name = "buttonGraphYearOfPublishing";
            this.buttonGraphYearOfPublishing.Size = new System.Drawing.Size(400, 40);
            this.buttonGraphYearOfPublishing.TabIndex = 7;
            this.buttonGraphYearOfPublishing.Text = "Year of publishing";
            this.buttonGraphYearOfPublishing.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::EditionCatalog.CMD.Properties.Resources.Librarian_300x2821;
            this.pictureBox2.Location = new System.Drawing.Point(1329, 470);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::EditionCatalog.CMD.Properties.Resources.MesOK;
            this.pictureBox3.Location = new System.Drawing.Point(1116, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::EditionCatalog.CMD.Properties.Resources.terry1;
            this.pictureBox1.Location = new System.Drawing.Point(1282, 50);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(500, 500);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(200, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.createNewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.createNewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.createNewToolStripMenuItem.Text = "Create new";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Image = global::EditionCatalog.CMD.Properties.Resources.delete;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1400, 650);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelSort.ResumeLayout(false);
            this.panelSort.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPriceSelection.ResumeLayout(false);
            this.panelPriceSelection.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn СountOfPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfPublishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonAddMagazine;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Panel panelSort;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Button buttonAuthorName;
        private System.Windows.Forms.CheckedListBox checkedListBoxSelectType;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMaxYearValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMinYearValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonYearOfPublishing;
        private System.Windows.Forms.Panel panelPriceSelection;
        private System.Windows.Forms.TextBox textBoxMaxPriceValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMinPriceValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDiscount;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Button buttonGraphYearOfPublishing;
        private System.Windows.Forms.Button buttonGraphEditionCount;
        private System.Windows.Forms.Button buttonGraphPrice;
        private System.Windows.Forms.Button buttonGraphEachAuthorBookCount;
        private System.Windows.Forms.Button buttonGraph;
    }
}

