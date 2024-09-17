namespace Paris.RMS.Contracts.Utilities;

public static class ReflectionUtilities
{
    public static bool Implements<TInterface>(this PropertyInfo property)
    {
        return property
            .PropertyType
            .Implements<TInterface>();
    }

    public static bool Implements<TInterface>(this Type baseType)
    {
        return baseType
            .GetInterface(typeof(TInterface).Name) is not null;
    }

    public static IEnumerable<Type> GetTypesWithAnyMatchingInterface(this Assembly assembly, Func<Type, bool> typeInterfaceMatch)
    {
        return assembly
            .GetTypes()
            .Where(type => type.GetInterfaces().Any(typeInterfaceMatch));
    }
}
