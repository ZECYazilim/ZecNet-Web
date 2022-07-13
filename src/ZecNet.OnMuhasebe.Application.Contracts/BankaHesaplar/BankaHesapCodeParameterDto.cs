using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.BankaHesaplar;
public class BankaHesapCodeParameterDto:IEntityDto,IDurum
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}
