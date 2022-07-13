using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;
using ZecNet.OnMuhasebe.Faturalar;

namespace ZecNet.OnMuhasebe.Stoklar;
public class StokHareketListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public FaturaHareketTuru? HareketTuru { get; set; }
    public Guid EntityId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}