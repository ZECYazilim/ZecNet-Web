using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Makbuzlar;
public class MakbuzListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public MakbuzTuru MakbuzTuru { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}