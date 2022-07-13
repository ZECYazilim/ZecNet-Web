using ZecNet.OnMuhasebe.CommonDtos;
using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Bankalar;
public interface IBankaAppService:ICrudAppService<SelectBankaDto,ListBankaDto,
    BankaListParameterDto,CreateBankaDto,UpdateBankaDto,CodeParameterDto>
{
}