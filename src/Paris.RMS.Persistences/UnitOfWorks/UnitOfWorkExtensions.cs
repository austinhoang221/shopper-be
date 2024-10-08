﻿namespace Paris.RMS.Persistences.UnitOfWorks;

public static class UnitOfWorkExtensions
{
    public static IServiceCollection RegisterUnitOfWorks(this IServiceCollection services)
    {
        return services.AddScoped<IUnitOfWork, UnitOfWork>(); ;
    }
}
