using AutoMapper;
using Domain.Entities;
using Services.Dto;


namespace Services.Dto.ProfileMapping
{

    public class MapperProfile : Profile
    {
      public MapperProfile()
        {
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<SocialNetwork, SocialNetworkDto>().ReverseMap();
        }

    }

}