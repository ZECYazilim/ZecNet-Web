namespace ZecNet.OnMuhasebe.Kasalar;
public class Kasa:FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    public Sube Sube { get; set; }
    public OzelKod Ozelkod1 { get; set; }
    public OzelKod Ozelkod2 { get; set; }
    public ICollection<Makbuz> Makbuzlar { get; set; }
    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }
}