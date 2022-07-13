using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;
using ZecNet.OnMuhasebe.Commons;
using ZecNet.OnMuhasebe.EntityFrameworkCore;

namespace ZecNet.OnMuhasebe.Donemler;
public class EfCoreDonemRepository : EfCoreCommonRepository<Donem>, IDonemRepository
{
    public EfCoreDonemRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }
}