using Volo.Abp.EntityFrameworkCore;
using ZecNet.OnMuhasebe.Commons;
using ZecNet.OnMuhasebe.EntityFrameworkCore;
using ZecNet.OnMuhasebe.Faturalar;

namespace ZecNet.OnMuhasebe.FaturaHareketler;
public class EfCoreFaturaHareketRepository : EfCoreCommonRepository<FaturaHareket>, IFaturaHareketRepository
{
    public EfCoreFaturaHareketRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }
}
