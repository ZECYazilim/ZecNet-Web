using AutoMapper;
using ZecNet.OnMuhasebe.Bankalar;

namespace ZecNet.OnMuhasebe;

public class OnMuhasebeApplicationAutoMapperProfile : Profile
{
    public OnMuhasebeApplicationAutoMapperProfile()
    {
        CreateMap<Banka, SelectBankaDto>()
            .ForMember(x=>x.OzelKod1Adi,y=>y.MapFrom(z=>z.OzelKod1.Ad))
            .ForMember(x=>x.OzelKod2Adi,y=>y.MapFrom(z=>z.OzelKod2.Ad));

        CreateMap<Banka, ListBankaDto>()
            .ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad))
            .ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad));

        CreateMap<CreateBankaDto, Banka>();
        CreateMap<UpdateBankaDto,Banka>();
    }
}