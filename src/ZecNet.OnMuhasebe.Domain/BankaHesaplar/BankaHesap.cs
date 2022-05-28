namespace ZecNet.OnMuhasebe.BankaHesaplar; // C#10 versiyonu ile birlikte süslü parantezler kalktı.Editor.config ile ototmatik hale getirilebilir.

public class BankaHesap:FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public BankaHesapTuru BankaHesapTuru { get; set; }
    public string HesapNo { get; set; }
    public string IbanNo { get; set; }
    public string Aciklama { get; set; }
    public Guid BankaSubeId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
    public BankaSube BankaSube { get; set; }
    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }
    public Sube Sube { get; set; }
}