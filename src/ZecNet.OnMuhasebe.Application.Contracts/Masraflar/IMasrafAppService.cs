using ZecNet.OnMuhasebe.CommonDtos;
using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Masraflar;
public interface IMasrafAppService:ICrudAppService<SelectMasrafDto,ListMasrafDto,
    MasrafListParameterDto,CreateMasrafDto,UpdateMasrafDto,CodeParameterDto>
{

}