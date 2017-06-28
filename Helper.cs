using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvViewer.Resources;
using CsvViewer.Utility;

namespace CsvViewer
{
    public static class Helper
    {
        public static async Task<List<string>> GetCsvRows(CsvOptions options, int page, int pageSize)
        {
            if (options.FilePath.IsNullOrEmpty())
                throw new ArgumentException(@"File path is empty.");

            var rowEnumerable = FileEnumerable.ReadOnly(options.FilePath, Encoding.UTF8)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Where(x => x.IsNotNullOrEmpty());

            if (!options.CommentSymbol.IsNullOrEmpty())
                rowEnumerable = rowEnumerable.Where(x => !x.StartsWith(options.CommentSymbol));

            if (!rowEnumerable.Any())
                return new List<string>();

            List<string> rows;
            if (options.GetColumnNamesFromFirstRow && await rowEnumerable.HasMoreRowsThanAsync(1))
            {
                var header = rowEnumerable.First();
                rows = await rowEnumerable.Skip(rowEnumerable.SkipAmount + 1).ToListAsync();
                rows.Insert(0, header);
                return rows;
            }

            rows = await rowEnumerable.ToListAsync();
            return rows;
        }

        public static long CountRows(CsvOptions options)
        {
            if (!options.IsValid())
                return 0;

            var rowCount = FileEnumerable.ReadOnly(options.FilePath, Encoding.UTF8).Count();
            return rowCount;
        }

        public static async Task<long> CountRowsAsync(CsvOptions options)
        {
            if (!options.IsValid())
                return 0;

            var rowCount = await FileEnumerable.ReadOnly(options.FilePath, Encoding.UTF8).CountAsync();
            return rowCount;
        }

        public static async Task<int> CountColumnsAsync(CsvOptions options)
        {
            if (!options.IsValid())
                return 0;

            var row = await FileEnumerable.ReadOnly(options.FilePath, Encoding.UTF8).FirstAsync();
            return row.Split(options.Delimiter.Character).Length;
        }
    }
}