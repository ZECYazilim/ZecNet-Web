using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Cariler;
public class CariListParameterDto: PagedResultRequestDto,IDurum,IEntityDto
{
    public bool Durum { get; set; }
}