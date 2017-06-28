namespace CsvViewer
{
    partial class About
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Button();
            this.CreatorLabel = new System.Windows.Forms.Label();
            this.MadeByLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GithubPicture = new System.Windows.Forms.PictureBox();
            this.LinkedinPicture = new System.Windows.Forms.PictureBox();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.AboutInfoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GithubPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkedinPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(253, 126);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = global::CsvViewer.Resources.Strings.THANKS;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreatorLabel.AutoSize = true;
            this.CreatorLabel.Location = new System.Drawing.Point(70, 3);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(96, 13);
            this.CreatorLabel.TabIndex = 2;
            this.CreatorLabel.Text = "Jeroen Vorsselman";
            // 
            // MadeByLabel
            // 
            this.MadeByLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MadeByLabel.AutoSize = true;
            this.MadeByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadeByLabel.Location = new System.Drawing.Point(3, 3);
            this.MadeByLabel.Name = "MadeByLabel";
            this.MadeByLabel.Size = new System.Drawing.Size(55, 13);
            this.MadeByLabel.TabIndex = 6;
            this.MadeByLabel.Text = "Made by";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.20253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.79747F));
            this.tableLayoutPanel1.Controls.Add(this.MadeByLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CreatorLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GithubPicture, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LinkedinPicture, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AboutLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AboutInfoLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 108);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // GithubPicture
            // 
            this.GithubPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GithubPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GithubPicture.InitialImage = global::CsvViewer.Properties.Resources.GitHub;
            this.GithubPicture.Location = new System.Drawing.Point(3, 57);
            this.GithubPicture.Name = "GithubPicture";
            this.GithubPicture.Size = new System.Drawing.Size(50, 48);
            this.GithubPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GithubPicture.TabIndex = 7;
            this.GithubPicture.TabStop = false;
            this.GithubPicture.Click += new System.EventHandler(this.GithubPicture_Click);
            // 
            // LinkedinPicture
            // 
            this.LinkedinPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LinkedinPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkedinPicture.InitialImage = global::CsvViewer.Properties.Resources.LinkedIn;
            this.LinkedinPicture.Location = new System.Drawing.Point(70, 57);
            this.LinkedinPicture.Name = "LinkedinPicture";
            this.LinkedinPicture.Size = new System.Drawing.Size(50, 48);
            this.LinkedinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LinkedinPicture.TabIndex = 8;
            this.LinkedinPicture.TabStop = false;
            this.LinkedinPicture.Click += new System.EventHandler(this.LinkedinPicture_Click);
            // 
            // AboutLabel
            // 
            this.AboutLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.Location = new System.Drawing.Point(3, 30);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(40, 13);
            this.AboutLabel.TabIndex = 9;
            this.AboutLabel.Text = "About";
            // 
            // AboutInfoLabel
            // 
            this.AboutInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AboutInfoLabel.AutoSize = true;
            this.AboutInfoLabel.Location = new System.Drawing.Point(70, 24);
            this.AboutInfoLabel.Name = "AboutInfoLabel";
            this.AboutInfoLabel.Size = new System.Drawing.Size(222, 26);
            this.AboutInfoLabel.TabIndex = 10;
            this.AboutInfoLabel.Text = "Should originate from the Github repo, please inform me if you got this from anot" +
    "her website.";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GithubPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkedinPicture)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label CreatorLabel;
        private System.Windows.Forms.Label MadeByLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox GithubPicture;
        private System.Windows.Forms.PictureBox LinkedinPicture;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label AboutInfoLabel;
    }
}