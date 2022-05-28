namespace ZecNet.OnMuhasebe.Faturalar;
public class FaturaHareket:FullAuditedEntity<Guid>   //rows-->00,2
{
    public Guid FaturaId { get; set; }
    public FaturaHareketTuru HareketTuru { get; set; }
    public Guid? StokId { get; set; } //atLEAST 1
    public Guid? HizmetId { get; set; } //atLEAST 1
    public Guid? MasrafId { get; set; } //atLEAST 1
    public Guid? DepoId { get; set; }
    public decimal Miktar { get; set; }
    public decimal BirimFiyat { get; set; }
    public decimal BrutTutar { get; set; }
    public decimal IndirimTutar { get; set; }
    public int KdvOrani { get; set; }
    public decimal KdvHaricTutar { get; set; }
    public decimal KdvTutar { get; set; }
    public decimal NetTutar { get; set; }
    public string Aciklama { get; set; }
}