using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ZecNet.OnMuhasebe.Services;
public interface ICodeAppService<in TGetCodeInput>:IApplicationService
{
    Task<string> GetCodeAsync(TGetCodeInput input);
}