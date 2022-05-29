using AutoMapper;
using BusinessLayer.DTOs;
using EntityLayer.Concrete;


namespace DataAccessLayer.DTOs.DTOProfiles
{
    public class InvoiceDtoProfile :Profile
    {
        public InvoiceDtoProfile()
        {
            CreateMap<Invoice, InvoiceDTO>();
            CreateMap<InvoiceDTO, Invoice>();
        }
    }
}
