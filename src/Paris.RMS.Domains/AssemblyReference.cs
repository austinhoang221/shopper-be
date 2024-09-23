using System.Reflection;

namespace Paris.RMS.Domains;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}
