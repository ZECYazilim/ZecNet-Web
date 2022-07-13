using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Depolar;
public interface IDepoAppService:ICrudAppService<SelectDepoDto,ListDepoDto,
    DepoListParameterDto,CreateDepoDto,UpdateDepoDto,DepoCodeParameterDto>
{
}