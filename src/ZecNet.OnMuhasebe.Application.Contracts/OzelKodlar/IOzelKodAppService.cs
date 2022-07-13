using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.OzelKodlar;
public interface IOzelKodAppService:ICrudAppService<SelectOzelKodDto,ListOzelKodDto,
    OzelKodListParameterDto,CreateOzelKodDto,UpdateOzelKodDto,OzelKodCodeParameterDto>
{

}