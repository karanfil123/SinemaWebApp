using AutoMapper;
using Sinemam.Core.Dtos;
using Sinemam.Core.Entities;

namespace Sinemam.Service.Mappings
{
    public class ModelDtoMap : Profile
    {
        public ModelDtoMap()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Show, ShowDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
        }
    }
}
