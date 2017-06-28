using System;
using System.Collections.Generic;
using System.Linq;
using CsvViewer.Utility.Comparators;

namespace CsvViewer.Utility {
    public static class SearchConditionExtensions
    {
        public static bool WithCondition(this string @this,
            string keyword,
            SearchCondition condition)
        {
            var comparator = new AlphaNumericComparator();
            switch (condition)
            {
                case SearchCondition.Contains:
                    return @this.ContainsQuick(keyword);
                case SearchCondition.NotContains:
                    return !@this.ContainsQuick(keyword);
                case SearchCondition.MoreThan:
                    return comparator.Compare(@this, keyword) == 1;
                case SearchCondition.LessThan:
                    return comparator.Compare(@this, keyword) == -1;
                case SearchCondition.EqualTo:
                    return comparator.Compare(@this, keyword) == 0;
                case SearchCondition.NotEqualTo:
                    return comparator.Compare(@this, keyword) != 0;
                case SearchCondition.LongerThan:
                    if (int.TryParse(keyword, out var longer))
                        return @this.Length > longer;

                    throw new ArgumentException($@"Unable to parse {nameof(keyword)} to number.", nameof(keyword));
                case SearchCondition.ShorterOrEqual:
                    if (int.TryParse(keyword, out var shorter))
                        return @this.Length <= shorter;

                    throw new ArgumentException($@"Unable to parse {nameof(keyword)} to number.", nameof(keyword));
                case SearchCondition.Undefined:
                default:
                    throw new ArgumentOutOfRangeException(nameof(condition), condition, null);
            }
        }


        public static IEnumerable<string> WithCondition(this IEnumerable<string> @this,
            string keyword,
            SearchCondition condition)
        {
            var comparator = new AlphaNumericComparator();
            switch (condition)
            {
                case SearchCondition.Contains:
                    return @this.Where(x => x.ContainsQuick(keyword));
                case SearchCondition.NotContains:
                    return @this.Where(x => !x.ContainsQuick(keyword));
                case SearchCondition.MoreThan:
                    return @this.Where(x => comparator.Compare(x, keyword) == 1);
                case SearchCondition.LessThan:
                    return @this.Where(x => comparator.Compare(x, keyword) == -1);
                case SearchCondition.EqualTo:
                    return @this.Where(x => comparator.Compare(x, keyword) == 0);
                case SearchCondition.NotEqualTo:
                    return @this.Where(x => comparator.Compare(x, keyword) != 0);
                case SearchCondition.LongerThan:
                    if (int.TryParse(keyword, out var longer))
                        return @this.Where(x => x.Length > longer);

                    return @this;
                case SearchCondition.ShorterOrEqual:
                    if (int.TryParse(keyword, out var shorter))
                        return @this.Where(x => x.Length <= shorter);

                    return @this;
                default:
                    throw new ArgumentOutOfRangeException(nameof(condition), condition, null);
            }
        }
    }
}