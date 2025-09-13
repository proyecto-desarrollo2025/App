using System.Threading.Tasks;

namespace ProyectoDesarrollo2025.Data;

public interface IProyectoDesarrollo2025DbSchemaMigrator
{
    Task MigrateAsync();
}
