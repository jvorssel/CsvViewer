using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace CsvViewer.Utility {
    public static class StringExtensions
    {
        /// <summary>
        ///     Find the Delimiter symbol in the <see cref="IEnumerable{T}"/> <paramref name="rows"/>
        ///     by finding the frequency of a symbol that is equal for each row.
        /// </summary>
        /// <remarks>
        ///     The <paramref name="threshold"/> tells to return the most frequent symbol when only x amount of symbols remains.
        /// </remarks>
        public static char FindDelimiter(this IEnumerable<string> rows, IEnumerable<char> quotes, IEnumerable<char> delimiters = null, int threshold = 5)
        {
            var found = new Dictionary<KeyValuePair<char, int>, int>();
            var rowList = rows.ToList();
            var index = 0;

            char? quote = null;
            foreach (var row in rowList)
            {
                if (!quote.HasValue)
                {
                    foreach (var q in quotes)
                    {
                        if (row.Count(x => x == q) % 2 != 0)
                            continue;

                        quote = q;
                    }
                }

                index++;
                var candidates = Regex.Replace(row.RemoveBetween(quote.Value, quote.Value), @"([\w0-9])", string.Empty);

                if (delimiters != null)
                {
                    int count;
                    var @char = MostOccurring(candidates, delimiters, out count);
                    if (@char == null)
                        throw new InvalidOperationException("Unable to recognize csv format.");

                    var key = new KeyValuePair<char, int>(@char.Value, count);
                    if (found.HasKey(key))
                        found[key]++;
                    else
                        found.Add(key, 1);
                }
                else if (rowList.Count == 1)
                    throw new InvalidOperationException($@"Can't find a delimiter in one row without a list of {nameof(delimiters)} to look for. Even so, the result might be faulty.");
                else
                {
                    var charGroups = candidates.GroupBy(x => x).ToList();
                    foreach (var group in charGroups)
                    {
                        var occurrences = charGroups.Count;
                        var key = new KeyValuePair<char, int>(group.Key, group.Count());
                        if (found.HasKey(key))
                            found[key]++;
                        else
                            found.Add(key, 1);
                    }
                }

                // When the amount of symbols is less than the given precision.
                if (found.Count(x => x.Value == index) <= threshold && index > 1)
                {
                    var guessed = found.OrderByDescending(x => x.Value);

                    return guessed.First().Key.Key;
                }

            }

            var common = found.Where(x => x.Value == rowList.Count).ToList();
            if (common.Count > 1)
                throw new InvalidOperationException($@"Each row has multiple character(s) '{common.StringJoin(x => x.Key, ", ")}' with the same frequency. Maybe provide a list of {nameof(delimiters)}?");

            var result = found.OrderByDescending(x => x.Value).First();

            return result.Key.Key; // :D
        }


        /// <summary>
        ///     Concatenates all the elements in the <see cref="IEnumerable{T}"/>, 
        ///     using the specified <paramref name="separator"/> between each element.
        /// </summary>
        public static string StringJoin<T>(this IEnumerable<T> @this, string separator)
            => string.Join(separator, @this);

        /// <summary>
        ///     Find the <see cref="MostOccurring(string,IEnumerable{char},out int)"/> <paramref name="characters"/> 
        ///     in the <see cref="string"/> <paramref name="this"/>.
        /// </summary>
        public static char? MostOccurring(this string @this, IEnumerable<char> characters, out int amount)
        {
            amount = 0;
            char? @char = null;
            foreach (var character in characters)
            {
                var c = @this.Length - @this.Replace(character.ToString(), string.Empty).Length;
                if (c <= amount)
                    continue;

                amount = c;
                @char = character;
            }

            return @char;
        }

        /// <summary>
        ///     Remove values in a string between the <paramref name="begin"/> and <paramref name="end"/> character.
        /// </summary>
        public static string RemoveBetween(this string @this, char begin, char end)
        {
            // Source: https://stackoverflow.com/questions/1359412/remove-text-in-between-delimiters-in-a-string-using-a-regex
            var regex = new Regex($"\\{begin}.*?\\{end}");
            return regex.Replace(@this, string.Empty);
        }
        
        /// <summary>
        ///     Concatenates a property <paramref name="select"/> for all the elements 
        ///     in the <see cref="IEnumerable{T}"/>, 
        ///     using the specified <paramref name="separator"/> between each element.
        /// </summary>
        public static string StringJoin<T>(this IEnumerable<T> @this,
            Expression<Func<T, object>> select,
            string separator)
            => string.Join(separator, @this.Select(arg => select.Compile().Invoke(arg)));

        /// <summary>
        ///     Checks if string is null, empty or just whitespaces.
        /// </summary>
        public static bool IsNullOrEmpty(this string @this)
            => string.IsNullOrEmpty(@this) || string.IsNullOrWhiteSpace(@this);

        /// <summary>
        ///     Checks if string is not null, empty or just whitespaces.
        /// </summary>
        public static bool IsNotNullOrEmpty(this string @this)
            => !@this.IsNullOrEmpty();
    }
}