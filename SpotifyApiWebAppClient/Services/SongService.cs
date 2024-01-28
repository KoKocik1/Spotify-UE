using SpotifyApiWebApp.Models;
using System.Runtime.InteropServices;

namespace SpotifyApiWebApp.Services
{
    public class SongService
    {
        private DataAccess _dbContext = new DataAccess();

        public async Task<List<SongModel>> GetAllSong()
        {
            return await this.GetSongList();
        }

        public async Task<SongModel> GetLastSong()
        {
            var songList = await this.GetSongList();
            
            return songList.OrderByDescending(x => x.Id).First();
        }

        public async Task<int> GetSongCount()
        {
            var songList = await this.GetSongList();

            return songList.Count;
        }

        private async Task<List<SongModel>> GetSongList()
        {
            var songList = new List<SongModel>();
            var results = await _dbContext.GetAllSongs();
            foreach (var item in results)
            {
                var song = new SongModel()
                {
                    Id = item.Id,
                    SongName = item.SongName,
                    Duration = item.Duration,
                    Explicit = item.Explicit,
                    Popularity = item.Popularity,
                    AlbumType = item.AlbumType,
                    AlbumName = item.AlbumName,
                    SpotifyId = item.SpotifyId,
                    Artist1 = item.Artist1,
                    Artist2 = item.Artist2,
                    Artist3 = item.Artist3,
                    Artist4 = item.Artist4,
                    Position = item.Position,
                };
                songList.Add(song);
            }
            return songList;
        }
    }
}
