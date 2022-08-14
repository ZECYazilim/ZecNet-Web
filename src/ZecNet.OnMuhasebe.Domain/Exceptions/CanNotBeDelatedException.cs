using Volo.Abp;

namespace ZecNet.OnMuhasebe.Exceptions;
public class CanNotBeDelatedException:BusinessException
{
    public CanNotBeDelatedException():base(OnMuhasebeDomainErrorCodes.CanNotBeDelated)
    {

    }
}