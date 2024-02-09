using AutoMapper;
using AutoMapperDemo.DTOs;
using AutoMapperDemo.Entities;

namespace AutoMapperDemo.Mappings;

public class ColisProfile: Profile
{
    public ColisProfile()
    {
        CreateMap<Colis, ColisDto>()
            .ForMember(dest => 
                dest.ReceiverInfos, opt => opt.MapFrom(src => $"{src.ReceiverName} - {src.ReceiverPhone}"))
            .ForMember(dest => 
                dest.PathLength,
                opt => opt.MapFrom<PathLengthResolver>())
            .ReverseMap();

        CreateMap<Address, AddressDto>()
            .ReverseMap();
    }
}
