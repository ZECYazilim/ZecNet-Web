using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Faturalar;
public class FaturaNoParameterDto:IDurum,IEntityDto
{
    public FaturaTuru FaturaTuru { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}