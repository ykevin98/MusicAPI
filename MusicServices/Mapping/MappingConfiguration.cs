using AutoMapper;
using MusicServices.ViewModels;
using MusicData.Models;

namespace MusicServices.Mapping
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<UserViewModel, User>().ReverseMap();
            CreateMap<SoundViewModel, Sound>().ReverseMap();
            CreateMap<MusicResultViewModel, MusicResult>().ReverseMap();
            CreateMap<MenuItemViewModel, MenuItem>().ReverseMap();
        }
    }
}
