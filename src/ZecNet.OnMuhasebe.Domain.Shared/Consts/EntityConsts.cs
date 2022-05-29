namespace ZecNet.OnMuhasebe.Consts;
public static class EntityConsts
{
    /// <summary>
    ///  Server ve frontend kısmında kullanılacak alanların karakter sınırı kod tekrar
    ///  kullanımını azaltmak amacıyla const olarak tanımlandı.
    ///  Başka şekilde kullanıcının belirleyeceği şekilde yazabilme durumunda bir takım
    ///  güvenlik açıklarıyla karşılaştığım için bu yolu tercih ettim.
    /// </summary>
    public const int MaxCodeLength = 20; 
    public const int MaxNameLength = 50; 
    public const int MaxDescriptionLength = 200; 
    public const int MaxPhoneLength = 15; 
    public const int MaxAdressLength = 150;
    public const int MaxBarcodeLength = 128;


}