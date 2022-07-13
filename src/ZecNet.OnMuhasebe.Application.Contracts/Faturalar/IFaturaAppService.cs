using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Faturalar;
public interface IFaturaAppService:ICrudAppService<SelectFaturaDto,ListFaturaDto,
    FaturaListParameterDto,CreateFaturaDto,UpdateFaturaDto,FaturaNoParameterDto>
{
}