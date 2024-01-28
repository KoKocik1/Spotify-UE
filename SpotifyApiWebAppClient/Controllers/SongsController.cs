using Microsoft.AspNetCore.Mvc;
using SpotifyApiWebApp.Models;
using SpotifyApiWebApp.Services;

namespace SpotifyApiWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongsController : ControllerBase
    {
        private SongService _songService = new SongService();
        
        private readonly ILogger<SongsController> _logger;

        public SongsController(ILogger<SongsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/getAllSongs", Name = "GetAllSongs")]
        public async Task<List<SongModel>> GetAllSongs()
        {
            return await _songService.GetAllSong();
        }

        [HttpGet("/getLastSong", Name = "GetLastSong")]
        public async Task<SongModel> GetLastSong()
        {
            return await _songService.GetLastSong();
        }

        [HttpGet("/getSongCount", Name = "getSongCount")]
        public async Task<int> GetSongCount()
        {
            return await _songService.GetSongCount();
        }
    }
}
