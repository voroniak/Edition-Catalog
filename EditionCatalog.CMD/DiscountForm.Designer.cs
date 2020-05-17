namespace EditionCatalog.CMD
{
    partial class DiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonClickToWin = new System.Windows.Forms.Button();
            this.labelWinSum = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(170, 263);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(139, 61);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Visible = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonClickToWin
            // 
            this.buttonClickToWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClickToWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClickToWin.ForeColor = System.Drawing.Color.White;
            this.buttonClickToWin.Location = new System.Drawing.Point(315, 263);
            this.buttonClickToWin.Name = "buttonClickToWin";
            this.buttonClickToWin.Size = new System.Drawing.Size(145, 61);
            this.buttonClickToWin.TabIndex = 3;
            this.buttonClickToWin.Text = "Click to win";
            this.buttonClickToWin.UseVisualStyleBackColor = true;
            this.buttonClickToWin.Click += new System.EventHandler(this.buttonClickToWin_Click);
            // 
            // labelWinSum
            // 
            this.labelWinSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelWinSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWinSum.Location = new System.Drawing.Point(170, 181);
            this.labelWinSum.Name = "labelWinSum";
            this.labelWinSum.Size = new System.Drawing.Size(435, 44);
            this.labelWinSum.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(466, 263);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(139, 61);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelWinSum);
            this.Controls.Add(this.buttonClickToWin);
            this.Controls.Add(this.buttonApply);
            this.Name = "DiscountForm";
            this.Text = "DiscountForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonClickToWin;
        public System.Windows.Forms.Label labelWinSum;
        private System.Windows.Forms.Button buttonClose;
    }
}