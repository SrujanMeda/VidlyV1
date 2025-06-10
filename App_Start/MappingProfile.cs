using AutoMapper;
using VidlyV1.Dtos;
using VidlyV1.Models;

namespace VidlyV1.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}