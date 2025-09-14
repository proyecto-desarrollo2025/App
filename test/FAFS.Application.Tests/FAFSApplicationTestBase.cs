using Volo.Abp.Modularity;

namespace FAFS;

public abstract class FAFSApplicationTestBase<TStartupModule> : FAFSTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
