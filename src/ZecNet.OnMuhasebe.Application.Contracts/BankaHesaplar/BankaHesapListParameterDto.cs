using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.BankaHesaplar;
public class BankaHesapListParameterDto:PagedResultRequestDto,IEntityDto,IDurum
{
    public BankaHesapTuru? HesapTuru { get; set; }
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}