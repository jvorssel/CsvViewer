using System;
using System.Collections.Generic;
using CsvViewer.Resources;
using CsvViewer.Utility;

namespace CsvViewer
{
    public class CsvColumnFilter
    {
        public int Index { get; set; } = -1;
        public string Keyword { get; set; }
        public SearchCondition Condition { get; set; } = SearchCondition.Undefined;

        public CsvColumnFilter()
        {

        }

        public CsvColumnFilter(int index, string keyword)
        {
            Index = index;
            Keyword = keyword;
        }

        public CsvColumnFilter SetCondition(SearchCondition condition)
        {
            Condition = condition;
            return this;
        }

        public bool IsValid(out string message)
        {
            if (Index < 0)
            {
                message = Strings.NO_COLUMN_SELECTED;
                return false;
            }

            if (Condition == 0)
            {
                message = Strings.NO_SEARCH_CONDITION;
                return false;
            }

            if (Keyword.IsNullOrEmpty())
            {
                message = Strings.NO_KEYWORD;
                return false;
            }

            if ((Condition == SearchCondition.LongerThan || Condition == SearchCondition.ShorterOrEqual) && !int.TryParse(Keyword, out int number))
            {
                message = Strings.SEARCH_CONDITION_REQUIRES_NUMBER;
                return false;
            }

            message = string.Empty;
            return true;
        }

        public static List<SearchCondition> Conditions = new List<SearchCondition>
        {
            SearchCondition.Contains,
            SearchCondition.NotContains,
            SearchCondition.MoreThan,
            SearchCondition.LessThan,
            SearchCondition.EqualTo,
            SearchCondition.NotEqualTo,
            SearchCondition.LongerThan,
            SearchCondition.ShorterOrEqual
        };
    }
}