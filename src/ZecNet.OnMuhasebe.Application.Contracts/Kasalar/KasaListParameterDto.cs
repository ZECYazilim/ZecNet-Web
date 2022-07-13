using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Kasalar;
public class KasaListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}