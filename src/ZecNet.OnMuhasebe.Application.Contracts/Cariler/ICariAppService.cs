using ZecNet.OnMuhasebe.CommonDtos;
using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Cariler;
public interface ICariAppService:ICrudAppService<SelectCariDto,ListCariDto,CariListParameterDto,
    CreateCariDto,UpdateCariDto,CodeParameterDto>
{
}