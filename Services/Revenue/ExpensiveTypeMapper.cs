using AutoMapper;
using Finance.Models;

namespace Finance.Service.Revenue;

public class ExpensiveMappingProfile : Profile
{
    public ExpensiveMappingProfile()
    {
        CreateMap<ExpensiveType, ExpensiveTypeDto>().ReverseMap();
    }
}
