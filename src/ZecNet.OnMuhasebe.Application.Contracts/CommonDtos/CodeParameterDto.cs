using Volo.Abp.Application.Dtos;

namespace ZecNet.OnMuhasebe.CommonDtos;
public class CodeParameterDto:IDurum,IEntityDto
{
    public bool Durum { get; set; }
}