using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Masraflar;
public class MasrafListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public bool Durum { get; set; }
}