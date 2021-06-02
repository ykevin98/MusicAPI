#region Usings

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MusicServices.Services;
using MusicServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NAudio.Wave; 

#endregion

namespace MusicWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {
        #region Private Members

        private readonly ILogger<MusicController> _logger;
        private readonly IMusicService _musicService;
        private readonly IConfiguration _configuration;

        #endregion

        #region Constructor

        public MusicController(ILogger<MusicController> logger, IMusicService musicService, IConfiguration configuration)
        {
            _logger = logger;
            _musicService = musicService;
            _configuration = configuration;
        }

        #endregion

        #region API Actions

        [HttpGet("UserInfo")]
        [ProducesResponseType(typeof(UserViewModel), StatusCodes.Status200OK)]
        public IActionResult GetUserInfo(string firstName, string lastName)
        {
            var user = _musicService.GetUserInfo(firstName, lastName);

            return Ok(user);
        }

        [HttpGet("AllUsers")]
        [ProducesResponseType(typeof(UserViewModel), StatusCodes.Status200OK)]
        public IActionResult GetAllUsers()
        {
            var users = _musicService.GetAllUsers();

            return Ok(users);
        }

        [HttpPost]
        [ProducesResponseType(typeof(MusicResultViewModel), StatusCodes.Status200OK)]
        public IActionResult AddSound(SoundViewModel sound)
        {
            var result = _musicService.AddSound(sound);

            return Ok(result);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(MusicResultViewModel), StatusCodes.Status200OK)]
        public IActionResult DeleteSound(string id)
        {
            var result = _musicService.DeleteSound(id);

            return Ok(result);
        }
        #endregion
    }
}
