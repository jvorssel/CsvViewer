using System;
using System.ComponentModel;
using System.Windows.Forms;
using CsvViewer.Resources;

namespace CsvViewer
{
    partial class Container
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndicesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.PageSizeLabel = new System.Windows.Forms.Label();
            this.PageSizeDropDown = new System.Windows.Forms.ComboBox();
            this.HasColumnRowCheckBox = new System.Windows.Forms.CheckBox();
            this.CommentSymbolTextBox = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.DelimiterDropDown = new System.Windows.Forms.ComboBox();
            this.DelimiterLabel = new System.Windows.Forms.Label();
            this.PageNumberTextBox = new System.Windows.Forms.TextBox();
            this.LastPage = new System.Windows.Forms.Button();
            this.FirstPage = new System.Windows.Forms.Button();
            this.PageNameValue = new System.Windows.Forms.Label();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PlaceholderStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColumnCountStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RowCountStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataView = new CsvViewer.CsvDataView();
            this.MenuStrip.SuspendLayout();
            this.ActionPanel.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.viewToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1409, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.aboutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = global::CsvViewer.Resources.Strings.FILE;
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(122, 22);
            this.OpenMenuItem.Text = global::CsvViewer.Resources.Strings.OPEN_FILE;
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = global::CsvViewer.Resources.Strings.ABOUT;
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.closeToolStripMenuItem.Text = global::CsvViewer.Resources.Strings.CLOSE;
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IndicesMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = global::CsvViewer.Resources.Strings.VIEW;
            // 
            // IndicesMenuItem
            // 
            this.IndicesMenuItem.Name = "IndicesMenuItem";
            this.IndicesMenuItem.Size = new System.Drawing.Size(111, 22);
            this.IndicesMenuItem.Text = global::CsvViewer.Resources.Strings.INDICES;
            this.IndicesMenuItem.Click += new System.EventHandler(this.IndicesMenuItem_Click);
            // 
            // ActionPanel
            // 
            this.ActionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionPanel.Controls.Add(this.PageSizeLabel);
            this.ActionPanel.Controls.Add(this.PageSizeDropDown);
            this.ActionPanel.Controls.Add(this.HasColumnRowCheckBox);
            this.ActionPanel.Controls.Add(this.CommentSymbolTextBox);
            this.ActionPanel.Controls.Add(this.CommentLabel);
            this.ActionPanel.Controls.Add(this.DelimiterDropDown);
            this.ActionPanel.Controls.Add(this.DelimiterLabel);
            this.ActionPanel.Controls.Add(this.PageNumberTextBox);
            this.ActionPanel.Controls.Add(this.LastPage);
            this.ActionPanel.Controls.Add(this.FirstPage);
            this.ActionPanel.Controls.Add(this.PageNameValue);
            this.ActionPanel.Controls.Add(this.PreviousPage);
            this.ActionPanel.Controls.Add(this.NextPage);
            this.ActionPanel.Controls.Add(this.PageLabel);
            this.ActionPanel.Location = new System.Drawing.Point(12, 27);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(1385, 31);
            this.ActionPanel.TabIndex = 2;
            // 
            // PageSizeLabel
            // 
            this.PageSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PageSizeLabel.AutoSize = true;
            this.PageSizeLabel.Location = new System.Drawing.Point(3, 9);
            this.PageSizeLabel.Name = "PageSizeLabel";
            this.PageSizeLabel.Size = new System.Drawing.Size(55, 13);
            this.PageSizeLabel.TabIndex = 18;
            this.PageSizeLabel.Text = "View rows";
            this.PageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PageSizeDropDown
            // 
            this.PageSizeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PageSizeDropDown.FormattingEnabled = true;
            this.PageSizeDropDown.Location = new System.Drawing.Point(64, 6);
            this.PageSizeDropDown.Name = "PageSizeDropDown";
            this.PageSizeDropDown.Size = new System.Drawing.Size(66, 21);
            this.PageSizeDropDown.TabIndex = 17;
            this.PageSizeDropDown.SelectedIndexChanged += new System.EventHandler(this.PageSizeDropDown_SelectedIndexChanged);
            // 
            // HasColumnRowCheckBox
            // 
            this.HasColumnRowCheckBox.AutoSize = true;
            this.HasColumnRowCheckBox.Location = new System.Drawing.Point(821, 8);
            this.HasColumnRowCheckBox.Name = "HasColumnRowCheckBox";
            this.HasColumnRowCheckBox.Size = new System.Drawing.Size(200, 17);
            this.HasColumnRowCheckBox.TabIndex = 16;
            this.HasColumnRowCheckBox.Text = global::CsvViewer.Resources.Strings.HAS_COLUMN_LINE;
            this.HasColumnRowCheckBox.UseVisualStyleBackColor = true;
            this.HasColumnRowCheckBox.CheckedChanged += new System.EventHandler(this.HasColumnRowCheckBox_CheckedChanged);
            // 
            // CommentSymbolTextBox
            // 
            this.CommentSymbolTextBox.Location = new System.Drawing.Point(1281, 6);
            this.CommentSymbolTextBox.Name = "CommentSymbolTextBox";
            this.CommentSymbolTextBox.Size = new System.Drawing.Size(101, 20);
            this.CommentSymbolTextBox.TabIndex = 14;
            this.CommentSymbolTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CommentSymbolTextBox_KeyUp);
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(1187, 9);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(88, 13);
            this.CommentLabel.TabIndex = 15;
            this.CommentLabel.Text = "Comment Symbol";
            // 
            // DelimiterDropDown
            // 
            this.DelimiterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DelimiterDropDown.FormattingEnabled = true;
            this.DelimiterDropDown.Location = new System.Drawing.Point(1080, 6);
            this.DelimiterDropDown.Name = "DelimiterDropDown";
            this.DelimiterDropDown.Size = new System.Drawing.Size(101, 21);
            this.DelimiterDropDown.TabIndex = 14;
            this.DelimiterDropDown.SelectedIndexChanged += new System.EventHandler(this.DelimiterDropDown_SelectedIndexChanged);
            // 
            // DelimiterLabel
            // 
            this.DelimiterLabel.AutoSize = true;
            this.DelimiterLabel.Location = new System.Drawing.Point(1027, 9);
            this.DelimiterLabel.Name = "DelimiterLabel";
            this.DelimiterLabel.Size = new System.Drawing.Size(47, 13);
            this.DelimiterLabel.TabIndex = 10;
            this.DelimiterLabel.Text = "Delimiter";
            // 
            // PageNumberTextBox
            // 
            this.PageNumberTextBox.Location = new System.Drawing.Point(249, 6);
            this.PageNumberTextBox.Name = "PageNumberTextBox";
            this.PageNumberTextBox.Size = new System.Drawing.Size(44, 20);
            this.PageNumberTextBox.TabIndex = 9;
            this.PageNumberTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PageNumberTextBox_TextChanged);
            // 
            // LastPage
            // 
            this.LastPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastPage.Location = new System.Drawing.Point(328, 4);
            this.LastPage.Name = "LastPage";
            this.LastPage.Size = new System.Drawing.Size(40, 23);
            this.LastPage.TabIndex = 8;
            this.LastPage.Text = ">>";
            this.LastPage.UseVisualStyleBackColor = true;
            this.LastPage.Click += new System.EventHandler(this.LastPage_Click);
            // 
            // FirstPage
            // 
            this.FirstPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FirstPage.Location = new System.Drawing.Point(174, 4);
            this.FirstPage.Name = "FirstPage";
            this.FirstPage.Size = new System.Drawing.Size(40, 23);
            this.FirstPage.TabIndex = 7;
            this.FirstPage.Text = "<<";
            this.FirstPage.UseVisualStyleBackColor = true;
            this.FirstPage.Click += new System.EventHandler(this.FirstPage_Click);
            // 
            // PageNameValue
            // 
            this.PageNameValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PageNameValue.AutoSize = true;
            this.PageNameValue.Location = new System.Drawing.Point(136, 9);
            this.PageNameValue.Name = "PageNameValue";
            this.PageNameValue.Size = new System.Drawing.Size(32, 13);
            this.PageNameValue.TabIndex = 5;
            this.PageNameValue.Text = "Page";
            this.PageNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PreviousPage
            // 
            this.PreviousPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PreviousPage.Location = new System.Drawing.Point(220, 4);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(23, 23);
            this.PreviousPage.TabIndex = 2;
            this.PreviousPage.Text = "<";
            this.PreviousPage.UseVisualStyleBackColor = true;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // NextPage
            // 
            this.NextPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NextPage.Location = new System.Drawing.Point(299, 4);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(23, 23);
            this.NextPage.TabIndex = 1;
            this.NextPage.Text = ">";
            this.NextPage.UseVisualStyleBackColor = true;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(374, 9);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(24, 13);
            this.PageLabel.TabIndex = 0;
            this.PageLabel.Text = "0/0";
            this.PageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel,
            this.PlaceholderStripLabel,
            this.ColumnCountStripLabel,
            this.RowCountStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 660);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1409, 24);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(88, 19);
            this.StatusStripLabel.Text = global::CsvViewer.Resources.Strings.NO_FILE_SELECTED;
            // 
            // PlaceholderStripLabel
            // 
            this.PlaceholderStripLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.PlaceholderStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PlaceholderStripLabel.Name = "PlaceholderStripLabel";
            this.PlaceholderStripLabel.Size = new System.Drawing.Size(1222, 19);
            this.PlaceholderStripLabel.Spring = true;
            this.PlaceholderStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ColumnCountStripLabel
            // 
            this.ColumnCountStripLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.ColumnCountStripLabel.Name = "ColumnCountStripLabel";
            this.ColumnCountStripLabel.Size = new System.Drawing.Size(40, 19);
            this.ColumnCountStripLabel.Text = global::CsvViewer.Resources.Strings.COLUMNS;
            // 
            // RowCountStripLabel
            // 
            this.RowCountStripLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.RowCountStripLabel.Name = "RowCountStripLabel";
            this.RowCountStripLabel.Size = new System.Drawing.Size(44, 19);
            this.RowCountStripLabel.Text = global::CsvViewer.Resources.Strings.ROWS;
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(12, 64);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            DataView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            DataView.EnableHeadersVisualStyles = true;
            this.DataView.Size = new System.Drawing.Size(1385, 584);
            this.DataView.TabIndex = 1;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 684);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Container";
            this.Text = "CsvViewer";
            this.Load += new System.EventHandler(this.Container_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ActionPanel.ResumeLayout(false);
            this.ActionPanel.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private CsvDataView DataView;
        private Panel ActionPanel;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel StatusStripLabel;
        private ToolStripStatusLabel PlaceholderStripLabel;
        private ToolStripStatusLabel ColumnCountStripLabel;
        private ToolStripStatusLabel RowCountStripLabel;
        private Label PageLabel;
        private Button FirstPage;
        private Button NextPage;
        private Button PreviousPage;
        private Button LastPage;
        private Label PageNameValue;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem IndicesMenuItem;
        private TextBox PageNumberTextBox;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Label DelimiterLabel;
        private ComboBox DelimiterDropDown;
        private Label CommentLabel;
        private TextBox CommentSymbolTextBox;
        private CheckBox HasColumnRowCheckBox;
        private Label PageSizeLabel;
        private ComboBox PageSizeDropDown;
    }
}

