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
        public static FileEnumerable FileReader = new FileEnumerable();

        public static async Task<List<string>> GetCsvRows(CsvOptions options, CsvColumnFilter filter, int page, int pageSize)
        {
            if (options.FilePath.IsNullOrEmpty())
                throw new ArgumentException(@"File path is empty.");

            if (FileReader?.Path != options.FilePath)
                FileReader = FileEnumerable.ReadOnly(options.FilePath, options.Encoding).EnableBuffer();


            var rowEnumerable = FileReader
                .Reset()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            if (!options.CommentSymbol.IsNullOrEmpty())
                rowEnumerable = rowEnumerable.Where(x => !x.StartsWith(options.CommentSymbol));

            if (!rowEnumerable.Any())
                return new List<string>();

            List<string> rows;
            if (options.GetColumnNamesFromFirstRow && await rowEnumerable.HasMoreLinesThanAsync(1))
            {
                var header = rowEnumerable.First();

                if (filter?.IsValid(out var msg) ?? false)
                {
                    rowEnumerable = rowEnumerable
                        .Where(x => x.Split(options.Delimiter.Character)[filter.Index].WithCondition(filter.Keyword, filter.Condition));
                }

                rows = await rowEnumerable.Skip(rowEnumerable.SkipAmount + 1).ToListAsync();
                rows.Insert(0, header);
                return rows;
            }

            if (filter?.IsValid(out var msg2) ?? false)
            {
                rowEnumerable = rowEnumerable
                    .Where(x => x.Split(options.Delimiter.Character)[filter.Index].WithCondition(filter.Keyword, filter.Condition));
            }

            rows = await rowEnumerable.ToListAsync();
            return rows;
        }

        public static long CountRows(CsvOptions options, CsvColumnFilter filter)
        {
            if (!options.IsValid())
                return 0;

            if (FileReader?.Path != options.FilePath)
                FileReader = FileEnumerable.ReadOnly(options.FilePath, options.Encoding).EnableBuffer();

            long rowCount;
            if (filter.IsValid(out string msg))
                rowCount = FileReader.Count(x => x.Split(options.Delimiter.Character)[filter.Index]
                    .WithCondition(filter.Keyword, filter.Condition));
            else
                rowCount = FileReader.Count();

            return rowCount;
        }

        public static async Task<long> CountRowsAsync(CsvOptions options, CsvColumnFilter filter)
        {
            if (!options.IsValid())
                return 0;

            if (FileReader?.Path != options.FilePath)
                FileReader = FileEnumerable.ReadOnly(options.FilePath, options.Encoding).EnableBuffer();

            long rowCount;
            if (filter.IsValid(out string msg))
                rowCount = await FileReader.CountAsync(x => x.Split(options.Delimiter.Character)[filter.Index]
                    .WithCondition(filter.Keyword, filter.Condition));
            else
                rowCount = await FileReader.CountAsync();

            return rowCount;
        }

        public static async Task<int> CountColumnsAsync(CsvOptions options)
        {
            if (!options.IsValid())
                return 0;

            if (FileReader?.Path != options.FilePath)
                FileReader = FileEnumerable.ReadOnly(options.FilePath, options.Encoding).EnableBuffer();

            var row = await FileReader.FirstAsync();
            return row.Split(options.Delimiter.Character).Length;
        }
    }
}