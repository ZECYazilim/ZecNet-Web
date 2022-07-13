using Volo.Abp.EntityFrameworkCore;
using ZecNet.OnMuhasebe.Commons;
using ZecNet.OnMuhasebe.EntityFrameworkCore;

namespace ZecNet.OnMuhasebe.Stoklar;
public class EfCoreStokRepository : EfCoreCommonRepository<Stok>, IStokRepository
{
    public EfCoreStokRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }
}