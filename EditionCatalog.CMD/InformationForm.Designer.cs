namespace EditionCatalog.CMD
{
    partial class InformationForm
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
            this.InformationLabel = new System.Windows.Forms.Label();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // InformationLabel
            // 
            this.InformationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationLabel.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationLabel.ForeColor = System.Drawing.Color.White;
            this.InformationLabel.Location = new System.Drawing.Point(0, 0);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(582, 300);
            this.InformationLabel.TabIndex = 0;
            this.InformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InformationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Location = new System.Drawing.Point(350, 300);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(181, 17);
            this.EmailLinkLabel.TabIndex = 1;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "oleg.voronyakk@gmail.com";
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.InformationLabel);
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
    }
}