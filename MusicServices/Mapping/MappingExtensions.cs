#region Usings

using MusicData.Models;
using AutoMapper;
using MusicServices.ViewModels;
using System.Collections.Generic;

#endregion

namespace MusicServices.Mapping
{
    public static class MappingExtensions
    {
        #region ToViewModels

        public static UserViewModel ToViewModel(this User model, IMapper mapper)
        {
            return mapper.Map<UserViewModel>(model);
        }

        public static IEnumerable<UserViewModel> ToViewModels(this IEnumerable<User> models, IMapper mapper)
        {
            return mapper.Map<IEnumerable<UserViewModel>>(models);
        }

        public static MusicResultViewModel ToViewModels(this MusicResult model, IMapper mapper)
        {
            return mapper.Map<MusicResultViewModel>(model);
        }
        #endregion

        #region ToDataModels

        public static Sound ToDataModel(this SoundViewModel viewModel, IMapper mapper)
        {
            return mapper.Map<Sound>(viewModel);
        }

        #endregion
    }
}
