using Volo.Abp;

namespace ZecNet.OnMuhasebe.Exceptions;
public class DuplicateCodeException:BusinessException
{
    public DuplicateCodeException(string code):base(OnMuhasebeDomainErrorCodes.DuplicateCode)
    {
        WithData("Kod", code);
    }
}