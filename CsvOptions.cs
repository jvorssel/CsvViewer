using CsvViewer.Resources;
using CsvViewer.Utility;

namespace CsvViewer
{
    public class CsvOptions
    {
        public static CsvDelimiter[] Delimiters =
        {
            new CsvDelimiter(',' , Strings.COMMA),
            new CsvDelimiter('.' , Strings.DOT),
            new CsvDelimiter(' ' , Strings.WHITESPACE),
            new CsvDelimiter('\t', Strings.TAB),
            new CsvDelimiter('|' , Strings.PIPE),
            new CsvDelimiter(';' , Strings.SEMICOLON),
        };

        public static CsvQuote[] Quotes =
        {
            new CsvQuote('"', Strings.DOUBLE_QUOTE),
            new CsvQuote('\'', Strings.QUOTE),
            new CsvQuote('\\', Strings.BACKSLACK),
        };

        public string FilePath { get; set; }

        public string CommentSymbol { get; set; }

        public CsvDelimiter Delimiter { get; set; }

        public bool GetColumnNamesFromFirstRow = false;

        public bool IsValid()
        {
            return !FilePath.IsNullOrEmpty() && Delimiter != null;
        }
    }
}
