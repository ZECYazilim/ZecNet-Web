using System.Threading.Tasks;

namespace ZecNet.OnMuhasebe.Data;

public interface IOnMuhasebeDbSchemaMigrator
{
    Task MigrateAsync();
}
