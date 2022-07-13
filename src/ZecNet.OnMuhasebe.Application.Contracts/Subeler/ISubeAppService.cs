using ZecNet.OnMuhasebe.CommonDtos;
using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Subeler;
public interface ISubeAppService:ICrudAppService<SelectSubeDto,ListSubeDto,
    SubeListParameterDto,CreateSubeDto,UpdateSubeDto,CodeParameterDto>
{
}