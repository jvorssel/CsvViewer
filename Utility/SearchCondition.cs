namespace CsvViewer.Utility
{
    public enum SearchCondition
    {
        Undefined = 0,
        Contains = 1,
        NotContains = 2,
        MoreThan = 3,
        LessThan = 4,
        EqualTo = 5,
        NotEqualTo = 6,
        LongerThan = 7,
        ShorterOrEqual = 8,
        HasValue = 9,
        IsEmpty = 10,
        StartsWith = 11,
        DoesNotStartWith = 12,
        EndsWith = 13,
        DoesNotEndWith = 14,
    }
}
