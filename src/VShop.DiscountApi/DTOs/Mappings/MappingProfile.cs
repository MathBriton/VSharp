using AutoMapper;
using VShop.DiscountApi.Models;

namespace VShop.DiscountApi.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CuponDTO, coupon>().ReverseMap();
    }
}