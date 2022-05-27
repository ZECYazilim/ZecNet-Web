using Volo.Abp.Modularity;

namespace ZecNet.OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeApplicationModule),
    typeof(OnMuhasebeDomainTestModule)
    )]
public class OnMuhasebeApplicationTestModule : AbpModule
{

}
