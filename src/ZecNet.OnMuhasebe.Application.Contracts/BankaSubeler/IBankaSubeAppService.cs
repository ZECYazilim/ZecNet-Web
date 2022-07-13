using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.BankaSubeler;
public interface IBankaSubeAppService:ICrudAppService<SelectBankaSubeDto,ListBankaSubeDto,
    BankaSubeListParameterDto,CreateBankaSubeDto,UpdateBankaSubeDto,BankaSubeCodeParameterDto>
{
}
