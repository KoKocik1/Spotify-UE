using Postgrest.Attributes;
using Postgrest.Models;

namespace SpotifyApiWebApp.Models
{
    [Table("Top50Poland")]
    public class SongDto : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }
        [Column("song_name")]
        public string SongName { get; set; }
        [Column("duration")]
        public double Duration { get; set; }
        [Column("explicit")]
        public bool Explicit { get; set; }
        [Column("popularity")]
        public int Popularity { get; set; }
        [Column("album_type")]
        public string AlbumType { get; set; }
        [Column("album_name")]
        public string AlbumName { get; set; }
        [Column("spotify_id")]
        public string SpotifyId { get; set; }
        [Column("artist_1")]
        public string Artist1 { get; set; }
        [Column("artist_2")]
        public string Artist2 { get; set; }
        [Column("artist_3")]
        public string Artist3 { get; set; }
        [Column("artist_4")]
        public string Artist4 { get; set; }
        [Column("position")]
        public int Position { get; set; }
    }
}
