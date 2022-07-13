using AutoMapper;
using ZecNet.OnMuhasebe.Bankalar;

namespace ZecNet.OnMuhasebe;

public class OnMuhasebeApplicationAutoMapperProfile : Profile
{
    public OnMuhasebeApplicationAutoMapperProfile()
    {
        CreateMap<Banka, SelectBankaDto>();
        CreateMap<Banka, ListBankaDto>();
        CreateMap<CreateBankaDto, Banka>();
        CreateMap<UpdateBankaDto,Banka>();
    }
}