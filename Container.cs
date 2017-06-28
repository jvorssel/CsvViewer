using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvViewer.Resources;
using CsvViewer.Utility;

namespace CsvViewer
{
    public partial class Container : Form
    {
        public CsvOptions Options { get; set; } = new CsvOptions();
        public CsvColumnFilter Filter { get; set; }

        public int[] PageSizes = { 10, 50, 100, 250, 500, 1000 };

        public int PageSize = 100;
        public int Page = 1;

        private long _rowCount = 0;
        private long _columnCount = 0;

        public List<string> HeaderColumns { get; set; } = new List<string>();

        public Container()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Set the <see cref="SetEnabled"/> state throughout the form.
        /// </summary>
        private void SetEnabled(bool enabled)
        {
            RowCountStripLabel.Enabled = enabled;
            ColumnCountStripLabel.Enabled = enabled;
            viewToolStripMenuItem.Enabled = enabled;

            PageLabel.Text = $@"{Page}/{(_rowCount + PageSize - 1) / PageSize}";

            var lp = GetLastPage();
            LastPage.Enabled = enabled && lp != Page;
            NextPage.Enabled = enabled && lp > Page;
            PreviousPage.Enabled = enabled && Page > 1;
            FirstPage.Enabled = enabled && Page != 1;
            PageNumberTextBox.Enabled = enabled;
            DataView.Enabled = enabled;
        }

        /// <summary>
        ///     Simple math to get the last available page number.
        /// </summary>
        private int GetLastPage() => Convert.ToInt32((_rowCount + PageSize - 1) / PageSize);

        #region Worker

        /// <summary>
        ///     Load data form the <see cref="CsvOptions.FilePath"/> file.
        /// </summary>
        public async Task LoadCsvData()
        {
            SetEnabled(false);

            StatusStripLabel.Text = Strings.LOADING;
            if (!Options.IsValid())
            {
                Page = 0;
                _rowCount = 0;
                _columnCount = 0;
                StatusStripLabel.Text = Strings.NO_FILE_SELECTED;
                SetEnabled(false);
                return;
            }

            if (Page < 1)
                Page = 1;

            var rows = await Helper.UpdateGrid(Options, Page, PageSize);
            await OnLoadComplete();
            UpdateGrid(rows);
        }

        private void UpdateGrid(List<string> rows)
        {
            DataView.Rows.Clear();
            DataView.Columns.Clear();
            DataView.ReadOnly = true;
            DataView.ColumnHeadersVisible = true;

            if (IndicesMenuItem.Checked)
                DataView.Columns.Add("Index", "#");

            var headerRow = rows.First().Split(Options.Delimiter.Character);

            if (!Options.GetColumnNamesFromFirstRow)
                for (var index = 0; index < headerRow.Length; index++)
                    DataView.Columns.Add(index.ToString(), $"{Strings.COLUMN} {index}");
            else
            {
                var header = rows.First().Split(Options.Delimiter.Character);
                foreach (var value in header)
                    DataView.Columns.Add(value, value);

                rows = rows.Skip(1).ToList();
            }

            for (var index = 0; index < rows.Count; index++)
            {
                var row = rows[index];
                var split = row.Split(Options.Delimiter.Character).ToList();
                if (IndicesMenuItem.Checked)
                    split.Insert(0, ((Page - 1) * PageSize + index + 1).ToString());

                DataView.Rows.Add(split.ToArray());
            }
        }

        /// <summary>
        ///     The main process to view the loaded data.
        /// </summary>
        private async Task OnLoadComplete()
        {
            HeaderColumns.Clear();
            for (var i = 0; i < DataView.ColumnCount; i++)
            {
                var text = DataView.ColumnHeadersVisible ? DataView.Columns[i].HeaderText : i.ToString();

                HeaderColumns.Add(text);
            }

            StatusStripLabel.Text = Strings.LOAD_COMPLETE;
            _rowCount = Helper.CountRows(Options);
            _columnCount = await Helper.CountColumnsAsync(Options);

            RowCountStripLabel.Text = $@"{Strings.ROWS}: {_rowCount}";
            ColumnCountStripLabel.Text = $@"{Strings.COLUMNS}: {_columnCount}";

            SetEnabled(true);
        }

        #endregion Worker

        #region UI

        /// <summary>
        ///     The form has loaded.
        /// </summary>
        private async void Container_Load(object sender, EventArgs e)
        {
            foreach (var delimiter in CsvOptions.Delimiters)
            {
                DelimiterDropDown.Items.Add(delimiter);
            }

            IndicesMenuItem.Checked = true;

            for (var index = 0; index < PageSizes.Length; index++)
            {
                var pageSize = PageSizes[index];
                PageSizeDropDown.Items.Add(pageSize);
                if (pageSize == 100)
                    PageSizeDropDown.SelectedIndex = index;
            }

            await LoadCsvData();
        }

        /// <summary>
        ///     Open a <see cref="FileDialog"/> from the tool strip menu item.
        /// </summary>
        private async void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusStripLabel.Text = Strings.SELECTING_FILE;
            var dialog = new OpenFileDialog
            {
                Filter = $@"{Strings.CSV_FILE}|*.csv|{Strings.TXT_FILE}|*.txt"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Page = 1;
                StatusStripLabel.Text = string.Empty;


                var delimiters = CsvOptions.Delimiters.Select(x => x.Character).ToList();
                var fileName = dialog.FileName;
                var rows = FileEnumerable
                    .ReadOnly(fileName)
                    .Where(x => !x.StartsWith("//") && !x.StartsWith("#") && !x.IsNullOrEmpty())
                    .Take(10);

                try
                {
                    var delimiter = rows.FindDelimiter(CsvOptions.Quotes.Select(x => x.Character),
                        CsvOptions.Delimiters.Select(x => x.Character));

                    var index = delimiters.IndexOf(delimiter);
                    DelimiterDropDown.SelectedIndex = index;
                }
                catch
                {
                    StatusStripLabel.Text = Strings.UNABLE_TO_READ_DELIMITER;
                    DelimiterDropDown.SelectedIndex = 0;
                }

                Options.FilePath = fileName;
                Text = $@"CsvViewer - {Options.FilePath}";
            }

            await LoadCsvData();
        }

        /// <summary>
        ///     Toggle view for indices in the <see cref="DataGridView"/>.
        /// </summary>
        private async void IndicesMenuItem_Click(object sender, EventArgs e)
        {
            IndicesMenuItem.Checked = !IndicesMenuItem.Checked;
            await LoadCsvData();
        }

        /// <summary>
        ///     The Delimiter to use has changed.
        /// </summary>
        private async void DelimiterDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Options.Delimiter = CsvOptions.Delimiters[DelimiterDropDown.SelectedIndex];

            await LoadCsvData();
        }

        /// <summary>
        ///     The comment text box has changed.
        /// </summary>
        private async void CommentSymbolTextBox_KeyUp(object sender, EventArgs e)
        {
            Options.CommentSymbol = CommentSymbolTextBox.Text;

            await LoadCsvData();
        }

        /// <summary>
        ///     To use the first row as a header or not.
        /// </summary>
        private async void HasColumnRowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Options.GetColumnNamesFromFirstRow = HasColumnRowCheckBox.Checked;

            await LoadCsvData();
        }

        /// <summary>
        ///     User wants to close the app.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Pages

        /// <summary>
        ///     Navigate to the last available page.
        /// </summary>
        private async void LastPage_Click(object sender, EventArgs e)
        {
            Page = GetLastPage();

            await LoadCsvData();
        }

        /// <summary>
        ///     Navigate to the next page.
        /// </summary>
        private async void NextPage_Click(object sender, EventArgs e)
        {
            PreviousPage.Enabled = true;
            var maxPage = GetLastPage();
            if (Page >= maxPage)
            {
                NextPage.Enabled = false;
                Page = Convert.ToInt32(GetLastPage());
            }
            else if (Page < maxPage)
                Page++;

            await LoadCsvData();
        }

        /// <summary>
        ///     Navigate to the previous page.
        /// </summary>
        private async void PreviousPage_Click(object sender, EventArgs e)
        {
            NextPage.Enabled = true;
            if (Page <= 1)
            {
                PreviousPage.Enabled = false;
                Page = 1;
            }
            else if (Page > 1)
                Page--;

            await LoadCsvData();
        }

        /// <summary>
        ///     Navigate to the first available page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void FirstPage_Click(object sender, EventArgs e)
        {
            Page = 1;


            await LoadCsvData();
        }

        /// <summary>
        ///     The User changed the contents of the page text box.
        ///     Navigates to the selection when 'Enter' is pressed.
        /// </summary>
        private async void PageNumberTextBox_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await LoadCsvData();
                PageNumberTextBox.Text = "";
                return;
            }

            var oldValue = PageNumberTextBox.Text;
            var lastPage = GetLastPage();
            try
            {
                var number = Convert.ToInt32(PageNumberTextBox.Text);
                if (number < 1)
                {
                    PageNumberTextBox.Text = @"1";
                }
                else if (number > GetLastPage())
                {
                    PageNumberTextBox.Text = lastPage.ToString();
                }
                else
                {
                    PageNumberTextBox.Text = number.ToString();
                }
            }
            catch
            {
                PageNumberTextBox.Text = oldValue;
            }

            if (PageNumberTextBox.Text.IsNotNullOrEmpty())
                Page = Convert.ToInt32(PageNumberTextBox.Text);
        }

        /// <summary>
        ///     The user changed the size of the page to view.
        /// </summary>
        private async void PageSizeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newPageSize = PageSizes[PageSizeDropDown.SelectedIndex];
            Page = 1;
            PageSize = newPageSize;

            await LoadCsvData();
        }

        #endregion

        #endregion UI
    }
}
