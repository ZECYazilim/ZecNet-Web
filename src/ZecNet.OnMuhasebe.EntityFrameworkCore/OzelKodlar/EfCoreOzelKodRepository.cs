using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;
using ZecNet.OnMuhasebe.Commons;
using ZecNet.OnMuhasebe.EntityFrameworkCore;

namespace ZecNet.OnMuhasebe.OzelKodlar;
public class EfCoreOzelKodRepository : EfCoreCommonRepository<OzelKod>, IOzelKodRepository
{
    public EfCoreOzelKodRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }
}