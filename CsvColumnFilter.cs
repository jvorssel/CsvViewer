using CsvViewer.Utility;

namespace CsvViewer {
    public class CsvColumnFilter
    {
        public int Index { get; set; } = -1;
        public string Keyword { get; set; }

        public CsvColumnFilter()
        {
            
        }

        public CsvColumnFilter(int index, string keyword)
        {
            Index = index;
            Keyword = keyword;
        }

        public bool IsValid() 
            => Index != -1 && Keyword.IsNotNullOrEmpty();
    }
}