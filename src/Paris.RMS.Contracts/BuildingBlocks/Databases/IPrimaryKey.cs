namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IPrimaryKey<TIdentity>
{
    TIdentity Id { get; }
}

public interface IPrimaryKey : IPrimaryKey<long>
{
}
