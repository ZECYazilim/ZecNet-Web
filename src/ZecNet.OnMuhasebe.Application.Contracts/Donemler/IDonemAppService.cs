using ZecNet.OnMuhasebe.CommonDtos;
using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Donemler;
public interface IDonemAppService:ICrudAppService<SelectDonemDto,ListDonemDto,DonemListParameterDto,
    CreateDonemDto,UpdateDonemDto,CodeParameterDto>
{
}