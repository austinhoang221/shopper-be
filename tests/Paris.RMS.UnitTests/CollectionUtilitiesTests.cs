using Paris.RMS.Contracts.Utilities;

namespace Paris.RMS.UnitTests;

public class CollectionUtilitiesTests
{
    [Fact]
    public void GenerateTreeTest()
    {
        List<InputTreeClass> datas =
            [
                new("01", "Item 01", null, 1),
                new("02", "Item 02", null, 0),
                new("03", "Item 03",  "01", 0),
                new("04", "Item 04",  "01", 1),
                new("05", "Item 05",  "02", 1),
                new("06", "Item 06",  "02", 0),
            ];

        var forest = datas
            .GenerateForest(q => q.ParentId ?? "",
                q => q.Order,
                q => new OutputTreeClass(q.Id, q.Name, q.ParentId),
                q => q.Id,
                "")
            .ToList();

        Assert.Equal(2, forest.Count);
    }
}

public class InputTreeClass(string id, string name, string? parentId, int order)
{
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string? ParentId { get; set; } = parentId;
    public int Order { get; set; } = order;
}

public class OutputTreeClass(string value, string label, string? parentValue)
    : INode<OutputTreeClass>
{
    public string Value { get; set; } = value;
    public string Label { get; set; } = label;
    public string? ParentValue { get; set; } = parentValue;
    public IEnumerable<OutputTreeClass> Children { get; set; } = [];
}
