using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.OzelKodlar;
public class OzelKodCodeParameterDto:IDurum,IEntityDto
{
    public OzelKodTuru KodTuru { get; set; }
    public KartTuru KartTuru { get; set; }
    public bool Durum { get; set; }
}