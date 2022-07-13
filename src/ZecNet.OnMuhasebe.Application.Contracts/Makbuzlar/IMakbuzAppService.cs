using ZecNet.OnMuhasebe.Services;

namespace ZecNet.OnMuhasebe.Makbuzlar;
public interface IMakbuzAppService:ICrudAppService<SelectMakbuzDto,ListMakbuzDto,
    MakbuzListParameterDto,CreateMakbuzDto,UpdateMakbuzDto,MakbuzNoParameterDto>
{
}