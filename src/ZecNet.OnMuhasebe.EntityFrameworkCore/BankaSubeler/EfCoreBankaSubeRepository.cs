using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;
using ZecNet.OnMuhasebe.Commons;
using ZecNet.OnMuhasebe.EntityFrameworkCore;

namespace ZecNet.OnMuhasebe.BankaSubeler;
public class EfCoreBankaSubeRepository : EfCoreCommonRepository<BankaSube>,IBankaSubeRepository
{
    public EfCoreBankaSubeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }
}