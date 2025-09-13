using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProyectoDesarrollo2025.Data;

/* This is used if database provider does't define
 * IProyectoDesarrollo2025DbSchemaMigrator implementation.
 */
public class NullProyectoDesarrollo2025DbSchemaMigrator : IProyectoDesarrollo2025DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
