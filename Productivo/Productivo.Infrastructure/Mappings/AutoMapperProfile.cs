using AutoMapper;
using Productivo.Core.DTOs;
using Productivo.Core.Entities;

namespace Productivo.Infrastructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Company
            CreateMap<CompanyEntity, CompanyDto>();
            CreateMap<CompanyDto, CompanyEntity>();

            //Plan
            CreateMap<PlanEntity, PlanDto>();
            CreateMap<PlanDto, PlanEntity>();
        }
    }
}
