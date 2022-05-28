using System.Collections.Generic;
using ZecNet.OnMuhasebe.BankaHesaplar;

namespace ZecNet.OnMuhasebe.Subeler;
public class Sube:FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    public ICollection<BankaHesap> BankaHesaplar { get; set; }
}