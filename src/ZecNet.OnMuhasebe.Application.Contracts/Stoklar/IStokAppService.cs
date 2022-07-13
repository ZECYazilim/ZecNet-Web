using ZecNet.OnMuhasebe.CommonDtos;
using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Stoklar;
public interface IStokAppService:ICrudAppService<SelectStokDto,ListStokDto,
    StokListParameterDto,CreateStokDto,UpdateStokDto,CodeParameterDto>
{
}