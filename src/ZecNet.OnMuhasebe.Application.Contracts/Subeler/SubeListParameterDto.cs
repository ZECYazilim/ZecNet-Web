using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Subeler;
public class SubeListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public bool Durum { get; set; }
}