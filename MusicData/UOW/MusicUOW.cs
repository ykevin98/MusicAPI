#region Usings

using MusicData.Repositories;
using MusicData.Models;
using MusicData.Context;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

#endregion

namespace MusicData.UOW
{
    #region Interface

    public interface IMusicUOW
    {
        IRepository<User> UserRepository { get; }
        IRepository<Sound> SoundRepository { get; }
        MusicResult AddSound(Sound sound);
        MusicResult DeleteSound(string id);
    }

    #endregion

    #region Interface Implementation

    public class MusicUOW : IMusicUOW
    {
        #region Private Members

        private readonly MusicContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private IRepository<User> _userRepository;
        private IRepository<Sound> _soundRepository;

        #endregion

        #region Constructors

        public MusicUOW(MusicContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        #endregion

        #region Public methods

        public IRepository<User> UserRepository
        {
            get
            {
                return _userRepository ??= new Repository<User>(_context, _httpContextAccessor);
            }
        }

        public IRepository<Sound> SoundRepository 
        { 
            get
            {
                return _soundRepository ??= new Repository<Sound>(_context, _httpContextAccessor);
            }
        }

        public MusicResult AddSound(Sound sound)
        {
            using (_context)
            {
                try
                {
                    Guid id = Guid.NewGuid();
                    sound.Id = Convert.ToString(id);
                    _context.Add(sound);

                    _context.SaveChanges();

                    MusicResult result = new MusicResult
                    {
                        Id = sound.Id,
                        IsSuccessful = true,
                        Message = "Sound add successful"
                    };

                    return result;
                }
                catch (Exception exception)
                {
                    MusicResult result = new MusicResult
                    {
                        Id = sound.Id,
                        IsSuccessful = false,
                        Message = $"An unexpected error on adding sound: {exception.Message}"
                    };

                    return result;
                }
            }   
        }

        public MusicResult DeleteSound(string id)
        {
            using (_context)
            {
                try
                {
                    var record = SoundRepository.FindBy(x => x.Id == id).FirstOrDefault();
                    if (record == null)
                    {
                        MusicResult errorResult = new MusicResult
                        {
                            Id = record.Id,
                            IsSuccessful = false,
                            Message = "There isn't a record in the database. "
                        };
                        return errorResult;
                    }
                    _context.Remove(record);

                    _context.SaveChanges();

                    MusicResult result = new MusicResult
                    {
                        Id = id,
                        IsSuccessful = true,
                        Message = "Delete sound successful"
                    };

                    return result;
                }
                catch (Exception exception)
                {
                    MusicResult result = new MusicResult
                    {
                        Id = id,
                        IsSuccessful = false,
                        Message = $"An unexpected error on deleting sound: {exception.Message}"
                    };

                    return result;
                }
            }
        }

        #endregion
    }

    #endregion
}
