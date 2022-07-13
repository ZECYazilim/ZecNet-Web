using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Kasalar;
public interface IKasaAppService:ICrudAppService<SelectKasaDto,ListKasaDto,KasaListParameterDto,
    CreateKasaDto,UpdateKasaDto,KasaCodeParameterDto>
{
}