using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Donemler;
public class DonemListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public bool Durum { get; set; }
}
