namespace Paris.RMS.Contracts.Utilities;

public static class CollectionUtilities
{
    public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
    {
        if (enumerable != null)
        {
            return !enumerable.Any();
        }

        return true;
    }
}
