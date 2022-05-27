using ZecNet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ZecNet.OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeEntityFrameworkCoreTestModule)
    )]
public class OnMuhasebeDomainTestModule : AbpModule
{

}
