using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Paris.RMS.Persistences.Configurations;

public class UlidToStringConverter(ConverterMappingHints mappingHints) : ValueConverter<Ulid, string>(
            convertToProviderExpression: x => x.ToString(),
            convertFromProviderExpression: x => Ulid.Parse(x),
            mappingHints: defaultHints.With(mappingHints))
{
    private static readonly ConverterMappingHints defaultHints = new(size: 26);
}
