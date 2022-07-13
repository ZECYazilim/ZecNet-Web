using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.Faturalar;
using ZecNet.OnMuhasebe.Makbuzlar;

namespace ZecNet.OnMuhasebe.Cariler;
public class ListCariHareketDto:EntityDto<Guid>
{
    public Guid CariId { get; set; }
    public Guid? FaturaId { get; set; }
    public Guid? MakbuzId { get; set; }
    public DateTime Tarih { get; set; }
    public string BelgeNo { get; set; }
    public string BelgeTuru { get; set; }
    public FaturaTuru FaturaTuru { get; set; }
    public MakbuzTuru MakbuzTuru { get; set; }
    public string HareketTuru { get; set; }
    public string Aciklama { get; set; }
    public decimal Tutar { get; set; }
}