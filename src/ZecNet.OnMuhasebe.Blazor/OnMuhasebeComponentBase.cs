using ZecNet.OnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ZecNet.OnMuhasebe.Blazor;

public abstract class OnMuhasebeComponentBase : AbpComponentBase
{
    protected OnMuhasebeComponentBase()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }
}
