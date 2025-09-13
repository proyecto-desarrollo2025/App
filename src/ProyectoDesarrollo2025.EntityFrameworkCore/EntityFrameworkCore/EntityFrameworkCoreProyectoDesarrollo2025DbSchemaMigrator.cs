using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProyectoDesarrollo2025.Data;
using Volo.Abp.DependencyInjection;

namespace ProyectoDesarrollo2025.EntityFrameworkCore;

public class EntityFrameworkCoreProyectoDesarrollo2025DbSchemaMigrator
    : IProyectoDesarrollo2025DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProyectoDesarrollo2025DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ProyectoDesarrollo2025DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProyectoDesarrollo2025DbContext>()
            .Database
            .MigrateAsync();
    }
}
