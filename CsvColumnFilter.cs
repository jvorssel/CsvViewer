namespace CsvViewer {
    public class CsvColumnFilter
    {
        public int Index { get; }
        public string Keyword { get; }

        public CsvColumnFilter(int index, string keyword)
        {
            Index = index;
            Keyword = keyword;
        }
    }
}