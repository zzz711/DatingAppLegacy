using AutoMapper;
using DatingApp_API.Dtos;
using DatingApp_API.Models;
using System.Linq;

namespace DatingApp_API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt => 
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age, opt => 
                    opt.MapFrom( src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailsDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                    opt.MapFrom(src => src.Photos.FirstOrDefault( p => p.IsMain).Url))
                .ForMember(dest => dest.Age, opt => 
                    opt.MapFrom( src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotosFroDetailedDto>();
        }
    }
}