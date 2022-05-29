using AutoMapper;
using EntityLayer.Concrete;


namespace DataAccessLayer.DTOs.DTOProfiles
{ 
    public class ClientDtoProfile : Profile
    {
        public ClientDtoProfile()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<ClientDto, Client>();
        }
    }
}
