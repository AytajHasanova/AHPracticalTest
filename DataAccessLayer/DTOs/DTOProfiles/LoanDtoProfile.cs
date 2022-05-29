using AutoMapper;
using BusinessLayer.DTOs;
using EntityLayer.Concrete;


namespace DataAccessLayer.DTOs.DTOProfiles
{
    public class LoanDtoProfile : Profile
    {
        public LoanDtoProfile()
        {
            CreateMap<Loan, LoanDto>();
            CreateMap<LoanDto, Loan>();
        }
    }
}
