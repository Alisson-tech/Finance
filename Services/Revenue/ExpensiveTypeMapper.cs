using AutoMapper;
using Finance.Models;

namespace Finance.Service.Revenue
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExpensiveType, ExpensiveTypeDto>().ReverseMap();
        }
    }
}
