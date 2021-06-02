#region Usings

using MusicServices.ViewModels;
using MusicData.UOW;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MusicServices.Mapping;

#endregion

namespace MusicServices.Services
{
    #region Interface

    public interface IMusicService
    {
        public UserViewModel GetUserInfo(string firstName, string lastName);
        public IEnumerable<UserViewModel>GetAllUsers();
        public MusicResultViewModel AddSound(SoundViewModel sound);
        public MusicResultViewModel DeleteSound(string id);
    }

    #endregion

    #region Interface Implementation

    public class MusicService : IMusicService
    {
        #region Private Members

        private readonly IMusicUOW _musicUOW;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors

        public MusicService(IMusicUOW musicUOW, IMapper mapper)
        {
            _musicUOW = musicUOW;
            _mapper = mapper;
        }

        #endregion

        #region Public Methods

        public UserViewModel GetUserInfo(string firstName, string lastName) 
        {
            var result = _musicUOW.UserRepository.FindBy(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();

            return result.ToViewModel(_mapper);
        }

        public IEnumerable<UserViewModel> GetAllUsers()
        {
            var results = _musicUOW.UserRepository.All().ToList();

            return results.ToViewModels(_mapper);
        }

        public MusicResultViewModel AddSound(SoundViewModel sound)
        {
            var result = _musicUOW.AddSound(sound.ToDataModel(_mapper));

            return result.ToViewModels(_mapper);
        }

        public MusicResultViewModel DeleteSound(string id)
        {
            var result = _musicUOW.DeleteSound(id);

            return result.ToViewModels(_mapper);
        }
        #endregion
    }

    #endregion
}
