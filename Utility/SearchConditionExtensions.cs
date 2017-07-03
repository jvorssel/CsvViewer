using System;
using System.Collections.Generic;
using System.Linq;
using CsvViewer.Utility.Comparators;

namespace CsvViewer.Utility
{
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
                    return @this.Contains(keyword);
                case SearchCondition.NotContains:
                    return !@this.Contains(keyword);
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
                case SearchCondition.HasValue:
                    return @this.IsNotNullOrEmpty();
                case SearchCondition.IsEmpty:
                    return @this.IsNullOrEmpty();
                case SearchCondition.StartsWith:
                    return @this.StartsWith(keyword);
                case SearchCondition.DoesNotStartWith:
                    return !@this.StartsWith(keyword);
                case SearchCondition.EndsWith:
                    return @this.EndsWith(keyword);
                case SearchCondition.DoesNotEndWith:
                    return !@this.EndsWith(keyword);
                case SearchCondition.Undefined:
                default:
                    throw new ArgumentOutOfRangeException(nameof(condition), condition, null);
            }
        }

        public static bool RequiresKeyword(this SearchCondition condition)
        {
            switch (condition)
            {
                case SearchCondition.Contains:
                case SearchCondition.NotContains:
                case SearchCondition.EqualTo:
                case SearchCondition.NotEqualTo:
                case SearchCondition.StartsWith:
                case SearchCondition.DoesNotStartWith:
                case SearchCondition.EndsWith:
                case SearchCondition.DoesNotEndWith:
                    return true;
                case SearchCondition.MoreThan:
                case SearchCondition.LessThan:
                case SearchCondition.LongerThan:
                case SearchCondition.ShorterOrEqual:
                case SearchCondition.HasValue:
                case SearchCondition.IsEmpty:
                    return false;
                case SearchCondition.Undefined:
                default:
                    throw new ArgumentOutOfRangeException(nameof(condition), condition, null);
            }
        }

        public static bool RequiresNumber(this SearchCondition condition)
        {
            switch (condition)
            {
                case SearchCondition.Contains:
                case SearchCondition.NotContains:
                case SearchCondition.EqualTo:
                case SearchCondition.NotEqualTo:
                case SearchCondition.StartsWith:
                case SearchCondition.DoesNotStartWith:
                case SearchCondition.EndsWith:
                case SearchCondition.DoesNotEndWith:
                case SearchCondition.HasValue:
                case SearchCondition.IsEmpty:
                    return false;
                case SearchCondition.MoreThan:
                case SearchCondition.LessThan:
                case SearchCondition.LongerThan:
                case SearchCondition.ShorterOrEqual:
                    return true;
                default:
                    throw new ArgumentOutOfRangeException(nameof(condition), condition, null);
            }
        }


        public static IEnumerable<string> WithCondition(this IEnumerable<string> @this,
            string keyword,
            SearchCondition condition) => @this.Where(x => x.WithCondition(keyword, condition));
    }
}