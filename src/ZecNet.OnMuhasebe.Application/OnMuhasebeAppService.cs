using System;
using System.Collections.Generic;
using System.Text;
using ZecNet.OnMuhasebe.Localization;
using Volo.Abp.Application.Services;

namespace ZecNet.OnMuhasebe;

/* Inherit your application services from this class.
 */
public abstract class OnMuhasebeAppService : ApplicationService
{
    protected OnMuhasebeAppService()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }
}
