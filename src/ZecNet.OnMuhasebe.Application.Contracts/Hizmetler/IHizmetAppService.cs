using ZecNet.OnMuhasebe.CommonDtos;
using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Hizmetler;
public interface IHizmetAppService:ICrudAppService<SelectHizmetDto,ListHismetDto,
    HizmetListParameterDto,CreateHizmetDto,UpdateHizmetDto,CodeParameterDto>
{

}