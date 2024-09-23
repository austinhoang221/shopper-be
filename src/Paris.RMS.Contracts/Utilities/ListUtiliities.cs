namespace Paris.RMS.Contracts.Utilities;

public static class ListUtiliities
{
    public static bool ContainsDuplicates<TValue, TType>(this IList<TValue> list, Func<TValue, TType> expression)
    {
        return list
            .GroupBy(expression)
            .Any(g => g.Count() > 1);
    }
}
