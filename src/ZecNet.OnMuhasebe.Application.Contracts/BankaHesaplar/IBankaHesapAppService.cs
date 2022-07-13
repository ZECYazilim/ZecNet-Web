using System;
using System.Collections.Generic;
using System.Text;
using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.BankaHesaplar;
public interface IBankaHesapAppService:
    ICrudAppService<SelectBankaHesapDto,
        ListBankaHesapDto,BankaHesapListParameterDto,CreateBankaHesapDto,UpdateBankaHesapDto,
        BankaHesapCodeParameterDto>
{
}
