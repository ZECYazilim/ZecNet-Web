namespace ZecNet.OnMuhasebe.OzelKodlar;
public class OzelKod:FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public OzelKodTuru KodTuru { get; set; } //reflexive cs<<tt
    public KartTuru KartTuru { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    public ICollection<BankaHesap> OzelKod1BankaHesaplar { get; set; }
    public ICollection<BankaHesap> OzelKod2BankaHesaplar { get; set; }
}