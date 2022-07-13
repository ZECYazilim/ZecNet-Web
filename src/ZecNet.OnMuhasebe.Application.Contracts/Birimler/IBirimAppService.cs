using ZecNet.OnMuhasebe.CommonDtos;
using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Birimler;
public interface IBirimAppService:ICrudAppService<SelectBirimDto,ListBirimDto,BirimListParameterDto,
    CreateBirimDto,UpdateBirimDto,CodeParameterDto>
{
}