using FAFS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FAFS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FAFSEntityFrameworkCoreModule),
    typeof(FAFSApplicationContractsModule)
)]
public class FAFSDbMigratorModule : AbpModule
{
}
