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

    /// <summary>
    /// Generate a forest based on the input list
    /// </summary>
    /// <typeparam name="TOutput">Kiểu dữ liệu cho danh sách đầu ra</typeparam>
    /// <typeparam name="TInput">Kiểu dữ liệu cho danh sách đầu vào</typeparam>
    /// <typeparam name="TOrderKey">Kiểu dữ liệu dành cho order</typeparam>
    /// <typeparam name="TMapping">Kiểu giữ liệu xác định mapping</typeparam>
    /// <param name="collection">Danh sách dữ liệu đầu vào</param>
    /// <param name="parentSelector">Lựa chọn cha</param>
    /// <param name="orderSelector">Hàm sắp sếp các item</param>
    /// <param name="createInstance">Hàm khởi tạo cho 1 item dữ liệu đầu ra</param>
    /// <param name="mappingSelector">Hàm mapping cha con</param>
    /// <param name="rootValue">Giá của cha gốc</param>
    /// <returns>IEnumerable RT</returns>
    public static IEnumerable<TOutput> GenerateForest<TOutput, TInput, TOrderKey, TMapping>(this IEnumerable<TInput> collection,
        Func<TInput, TMapping> parentSelector,
        Func<TInput, TOrderKey> orderSelector,
        Func<TInput, TOutput> createInstance,
        Func<TInput, TMapping> mappingSelector,
        TMapping? rootValue = default)
        where TOutput : class, INode<TOutput> where TInput : class
    {
        foreach (var c in collection.Where(c => rootValue?.Equals(parentSelector(c)) ?? false).OrderBy(q => orderSelector(q)))
        {
            var instance = createInstance(c);
            instance.Children = collection.GenerateForest(parentSelector, orderSelector, createInstance, mappingSelector, mappingSelector(c));
            yield return instance;
        }
    }
}

public interface INode<T>
{
    /// <summary>
    /// danh sách các con của đối tượng
    /// </summary>
    public IEnumerable<T> Children { get; set; }
}
