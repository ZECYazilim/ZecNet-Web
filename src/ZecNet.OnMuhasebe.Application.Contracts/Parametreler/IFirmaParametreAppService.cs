using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Parametreler;
public interface IFirmaParametreAppService:ICrudAppService<SelectFirmaParametreDto,
    SelectFirmaParametreDto,FirmaParametreListParameterDto,CreateFirmaParametreDto,
    UpdateFirmaParametreDto>
{
}