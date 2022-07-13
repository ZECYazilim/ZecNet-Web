using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Birimler;
public class BirimListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public bool Durum { get; set; }
}