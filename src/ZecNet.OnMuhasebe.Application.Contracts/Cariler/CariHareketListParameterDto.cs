using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Cariler;
public class CariHareketListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public Guid CariId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}