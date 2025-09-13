using ProyectoDesarrollo2025.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ProyectoDesarrollo2025.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProyectoDesarrollo2025EntityFrameworkCoreModule),
    typeof(ProyectoDesarrollo2025ApplicationContractsModule)
)]
public class ProyectoDesarrollo2025DbMigratorModule : AbpModule
{
}
