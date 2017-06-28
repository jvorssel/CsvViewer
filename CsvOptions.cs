using System.Text;
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

        public static Encoding[] TextEncoding =
        {
            Encoding.ASCII,
            Encoding.BigEndianUnicode,
            Encoding.UTF32,
            Encoding.UTF7,
            Encoding.UTF8,
            Encoding.Unicode,
        };

        public string FilePath { get; set; }

        public string CommentSymbol { get; set; }

        public CsvQuote Quote { get; set; } = Quotes[0];

        public CsvDelimiter Delimiter { get; set; } = Delimiters[3];

        public Encoding Encoding { get; set; } = TextEncoding[4];

        public bool GetColumnNamesFromFirstRow = false;

        public CsvOptions()
        {

        }

        public bool IsValid()
        {
            return !FilePath.IsNullOrEmpty() && Delimiter != null;
        }
    }
}
