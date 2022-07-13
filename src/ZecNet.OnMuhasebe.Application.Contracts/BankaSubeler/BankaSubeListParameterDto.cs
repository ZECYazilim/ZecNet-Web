using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.BankaSubeler;
public class BankaSubeListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public Guid BankaId { get; set; }
    public bool Durum { get; set; }
}