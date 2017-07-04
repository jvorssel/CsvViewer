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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndicesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.PageSizeLabel = new System.Windows.Forms.Label();
            this.PageSizeDropDown = new System.Windows.Forms.ComboBox();
            this.PageNumberTextBox = new System.Windows.Forms.TextBox();
            this.LastPage = new System.Windows.Forms.Button();
            this.FirstPage = new System.Windows.Forms.Button();
            this.PageNameValue = new System.Windows.Forms.Label();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.CommentSymbolTextBox = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.HasColumnRowCheckBox = new System.Windows.Forms.CheckBox();
            this.DelimiterDropDown = new System.Windows.Forms.ComboBox();
            this.DelimiterLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PlaceholderStripLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SelectionStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.PlaceholderStatusStrip2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColumnCountStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RowCountStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EncodingLabel = new System.Windows.Forms.Label();
            this.EncodingDropDown = new System.Windows.Forms.ComboBox();
            this.FileUpdatedPanel = new System.Windows.Forms.Panel();
            this.ReloadLink = new System.Windows.Forms.LinkLabel();
            this.FileUpdatedLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.KeywordLabel = new System.Windows.Forms.Label();
            this.KeywordTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ColumnDropDown = new System.Windows.Forms.ComboBox();
            this.SearchConditionDropDown = new System.Windows.Forms.ComboBox();
            this.SearchValidLabel = new System.Windows.Forms.Label();
            this.ResetFilterButton = new System.Windows.Forms.Button();
            this.DataView = new CsvViewer.CsvDataView();
            this.SaveFileToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip.SuspendLayout();
            this.ActionPanel.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.FileUpdatedPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.SaveToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = global::CsvViewer.Resources.Strings.FILE;
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenMenuItem.Text = global::CsvViewer.Resources.Strings.OPEN_FILE;
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = global::CsvViewer.Resources.Strings.SAVE;
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = global::CsvViewer.Resources.Strings.ABOUT;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.ActionPanel.Controls.Add(this.PageNumberTextBox);
            this.ActionPanel.Controls.Add(this.LastPage);
            this.ActionPanel.Controls.Add(this.FirstPage);
            this.ActionPanel.Controls.Add(this.PageNameValue);
            this.ActionPanel.Controls.Add(this.PreviousPage);
            this.ActionPanel.Controls.Add(this.NextPage);
            this.ActionPanel.Controls.Add(this.PageLabel);
            this.ActionPanel.Location = new System.Drawing.Point(12, 139);
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
            // CommentSymbolTextBox
            // 
            this.CommentSymbolTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommentSymbolTextBox.Location = new System.Drawing.Point(187, 29);
            this.CommentSymbolTextBox.Name = "CommentSymbolTextBox";
            this.CommentSymbolTextBox.Size = new System.Drawing.Size(178, 20);
            this.CommentSymbolTextBox.TabIndex = 14;
            this.CommentSymbolTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CommentSymbolTextBox_KeyUp);
            // 
            // CommentLabel
            // 
            this.CommentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(3, 32);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(88, 13);
            this.CommentLabel.TabIndex = 15;
            this.CommentLabel.Text = "Comment Symbol";
            this.CommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HasColumnRowCheckBox
            // 
            this.HasColumnRowCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HasColumnRowCheckBox.AutoSize = true;
            this.HasColumnRowCheckBox.Location = new System.Drawing.Point(3, 83);
            this.HasColumnRowCheckBox.Name = "HasColumnRowCheckBox";
            this.HasColumnRowCheckBox.Size = new System.Drawing.Size(101, 17);
            this.HasColumnRowCheckBox.TabIndex = 16;
            this.HasColumnRowCheckBox.Text = global::CsvViewer.Resources.Strings.HAS_HEADER;
            this.HasColumnRowCheckBox.UseVisualStyleBackColor = true;
            this.HasColumnRowCheckBox.CheckedChanged += new System.EventHandler(this.HasColumnRowCheckBox_CheckedChanged);
            // 
            // DelimiterDropDown
            // 
            this.DelimiterDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelimiterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DelimiterDropDown.FormattingEnabled = true;
            this.DelimiterDropDown.Location = new System.Drawing.Point(187, 3);
            this.DelimiterDropDown.Name = "DelimiterDropDown";
            this.DelimiterDropDown.Size = new System.Drawing.Size(178, 21);
            this.DelimiterDropDown.TabIndex = 14;
            this.DelimiterDropDown.SelectedIndexChanged += new System.EventHandler(this.DelimiterDropDown_SelectedIndexChanged);
            // 
            // DelimiterLabel
            // 
            this.DelimiterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DelimiterLabel.AutoSize = true;
            this.DelimiterLabel.Location = new System.Drawing.Point(3, 6);
            this.DelimiterLabel.Name = "DelimiterLabel";
            this.DelimiterLabel.Size = new System.Drawing.Size(47, 13);
            this.DelimiterLabel.TabIndex = 10;
            this.DelimiterLabel.Text = "Delimiter";
            this.DelimiterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel,
            this.PlaceholderStripLabel1,
            this.SelectionStatusStrip,
            this.PlaceholderStatusStrip2,
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
            // PlaceholderStripLabel1
            // 
            this.PlaceholderStripLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.PlaceholderStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PlaceholderStripLabel1.Name = "PlaceholderStripLabel1";
            this.PlaceholderStripLabel1.Size = new System.Drawing.Size(567, 19);
            this.PlaceholderStripLabel1.Spring = true;
            this.PlaceholderStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectionStatusStrip
            // 
            this.SelectionStatusStrip.Name = "SelectionStatusStrip";
            this.SelectionStatusStrip.Size = new System.Drawing.Size(73, 19);
            this.SelectionStatusStrip.Text = global::CsvViewer.Resources.Strings.NO_SELECTION;
            // 
            // PlaceholderStatusStrip2
            // 
            this.PlaceholderStatusStrip2.Name = "PlaceholderStatusStrip2";
            this.PlaceholderStatusStrip2.Size = new System.Drawing.Size(567, 19);
            this.PlaceholderStatusStrip2.Spring = true;
            // 
            // ColumnCountStripLabel
            // 
            this.ColumnCountStripLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.ColumnCountStripLabel.Name = "ColumnCountStripLabel";
            this.ColumnCountStripLabel.Size = new System.Drawing.Size(59, 19);
            this.ColumnCountStripLabel.Text = global::CsvViewer.Resources.Strings.COLUMNS;
            // 
            // RowCountStripLabel
            // 
            this.RowCountStripLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.RowCountStripLabel.Name = "RowCountStripLabel";
            this.RowCountStripLabel.Size = new System.Drawing.Size(39, 19);
            this.RowCountStripLabel.Text = global::CsvViewer.Resources.Strings.ROWS;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DelimiterLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CommentSymbolTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DelimiterDropDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CommentLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HasColumnRowCheckBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EncodingLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.EncodingDropDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FileUpdatedPanel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 106);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // EncodingLabel
            // 
            this.EncodingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EncodingLabel.AutoSize = true;
            this.EncodingLabel.Location = new System.Drawing.Point(3, 58);
            this.EncodingLabel.Name = "EncodingLabel";
            this.EncodingLabel.Size = new System.Drawing.Size(52, 13);
            this.EncodingLabel.TabIndex = 17;
            this.EncodingLabel.Text = "Encoding";
            this.EncodingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EncodingDropDown
            // 
            this.EncodingDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncodingDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingDropDown.FormattingEnabled = true;
            this.EncodingDropDown.Location = new System.Drawing.Point(187, 55);
            this.EncodingDropDown.Name = "EncodingDropDown";
            this.EncodingDropDown.Size = new System.Drawing.Size(178, 21);
            this.EncodingDropDown.TabIndex = 18;
            this.EncodingDropDown.SelectedIndexChanged += new System.EventHandler(this.EncodingDropDown_SelectedIndexChanged);
            // 
            // FileUpdatedPanel
            // 
            this.FileUpdatedPanel.Controls.Add(this.ReloadLink);
            this.FileUpdatedPanel.Controls.Add(this.FileUpdatedLabel);
            this.FileUpdatedPanel.Location = new System.Drawing.Point(187, 81);
            this.FileUpdatedPanel.Name = "FileUpdatedPanel";
            this.FileUpdatedPanel.Size = new System.Drawing.Size(178, 22);
            this.FileUpdatedPanel.TabIndex = 19;
            this.FileUpdatedPanel.Visible = false;
            // 
            // ReloadLink
            // 
            this.ReloadLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReloadLink.AutoSize = true;
            this.ReloadLink.Location = new System.Drawing.Point(140, 3);
            this.ReloadLink.Name = "ReloadLink";
            this.ReloadLink.Size = new System.Drawing.Size(41, 13);
            this.ReloadLink.TabIndex = 1;
            this.ReloadLink.TabStop = true;
            this.ReloadLink.Text = "Reload";
            this.ReloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReloadLink_LinkClicked);
            // 
            // FileUpdatedLabel
            // 
            this.FileUpdatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FileUpdatedLabel.AutoSize = true;
            this.FileUpdatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileUpdatedLabel.Location = new System.Drawing.Point(-3, 3);
            this.FileUpdatedLabel.Name = "FileUpdatedLabel";
            this.FileUpdatedLabel.Size = new System.Drawing.Size(130, 13);
            this.FileUpdatedLabel.TabIndex = 0;
            this.FileUpdatedLabel.Text = "The file was updated.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.ColumnLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.KeywordLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.KeywordTextBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.SearchButton, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.ColumnDropDown, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SearchConditionDropDown, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.SearchValidLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ResetFilterButton, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(389, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 106);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(3, 6);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(42, 13);
            this.ColumnLabel.TabIndex = 12;
            this.ColumnLabel.Text = "Column";
            this.ColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeywordLabel
            // 
            this.KeywordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.KeywordLabel.AutoSize = true;
            this.KeywordLabel.Location = new System.Drawing.Point(3, 32);
            this.KeywordLabel.Name = "KeywordLabel";
            this.KeywordLabel.Size = new System.Drawing.Size(48, 13);
            this.KeywordLabel.TabIndex = 11;
            this.KeywordLabel.Text = "Keyword";
            this.KeywordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeywordTextBox
            // 
            this.KeywordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeywordTextBox.Location = new System.Drawing.Point(211, 29);
            this.KeywordTextBox.Name = "KeywordTextBox";
            this.KeywordTextBox.Size = new System.Drawing.Size(100, 20);
            this.KeywordTextBox.TabIndex = 14;
            this.KeywordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeywordTextBox_KeyUp);
            // 
            // SearchButton
            // 
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchButton.Location = new System.Drawing.Point(107, 81);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 22);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = global::CsvViewer.Resources.Strings.SEARCH;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.FindKeywordButton_Click);
            // 
            // ColumnDropDown
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.ColumnDropDown, 2);
            this.ColumnDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnDropDown.FormattingEnabled = true;
            this.ColumnDropDown.Location = new System.Drawing.Point(107, 3);
            this.ColumnDropDown.Name = "ColumnDropDown";
            this.ColumnDropDown.Size = new System.Drawing.Size(204, 21);
            this.ColumnDropDown.TabIndex = 13;
            this.ColumnDropDown.SelectedIndexChanged += new System.EventHandler(this.ColumnDropDown_SelectedIndexChanged);
            // 
            // SearchConditionDropDown
            // 
            this.SearchConditionDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchConditionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchConditionDropDown.FormattingEnabled = true;
            this.SearchConditionDropDown.Location = new System.Drawing.Point(107, 29);
            this.SearchConditionDropDown.Name = "SearchConditionDropDown";
            this.SearchConditionDropDown.Size = new System.Drawing.Size(98, 21);
            this.SearchConditionDropDown.TabIndex = 16;
            this.SearchConditionDropDown.SelectedIndexChanged += new System.EventHandler(this.SearchConditionDropDown_SelectedIndexChanged);
            // 
            // SearchValidLabel
            // 
            this.SearchValidLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchValidLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.SearchValidLabel, 3);
            this.SearchValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchValidLabel.Location = new System.Drawing.Point(3, 58);
            this.SearchValidLabel.Name = "SearchValidLabel";
            this.SearchValidLabel.Size = new System.Drawing.Size(11, 13);
            this.SearchValidLabel.TabIndex = 17;
            this.SearchValidLabel.Text = "-";
            // 
            // ResetFilterButton
            // 
            this.ResetFilterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetFilterButton.Location = new System.Drawing.Point(3, 81);
            this.ResetFilterButton.Name = "ResetFilterButton";
            this.ResetFilterButton.Size = new System.Drawing.Size(98, 22);
            this.ResetFilterButton.TabIndex = 18;
            this.ResetFilterButton.Text = global::CsvViewer.Resources.Strings.RESET;
            this.ResetFilterButton.UseVisualStyleBackColor = true;
            this.ResetFilterButton.Click += new System.EventHandler(this.ResetFilterButton_Click);
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(12, 176);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(1385, 472);
            this.DataView.TabIndex = 1;
            this.DataView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.DataViewOnCellStateChanged);
            this.DataView.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.DataView_SortCompare);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 684);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.FileUpdatedPanel.ResumeLayout(false);
            this.FileUpdatedPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private ToolStripStatusLabel PlaceholderStripLabel1;
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label EncodingLabel;
        private ComboBox EncodingDropDown;
        private TableLayoutPanel tableLayoutPanel2;
        private Label ColumnLabel;
        private Label KeywordLabel;
        private ComboBox ColumnDropDown;
        private TextBox KeywordTextBox;
        private Button SearchButton;
        private Panel FileUpdatedPanel;
        private Label FileUpdatedLabel;
        private LinkLabel ReloadLink;
        private ComboBox SearchConditionDropDown;
        private Label SearchValidLabel;
        private ToolStripStatusLabel SelectionStatusStrip;
        private ToolStripStatusLabel PlaceholderStatusStrip2;
        private Button ResetFilterButton;
        private ToolTip SaveFileToolTip;
        private ToolStripMenuItem SaveToolStripMenuItem;
    }
}

