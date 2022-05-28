﻿namespace ZecNet.OnMuhasebe.BankaSubeler;
public class BankaSube:FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    public ICollection<BankaHesap> BankaHesaplar { get; set; }
}
