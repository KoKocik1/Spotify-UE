namespace SpotifyApiWebApp.Models
{
    public class SongModel
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public double Duration { get; set; }
        public bool Explicit { get; set; }
        public int Popularity { get; set; }
        public string AlbumType { get; set; }
        public string AlbumName { get; set; }
        public string SpotifyId { get; set; }
        public string Artist1 { get; set; }
        public string Artist2 { get; set; }
        public string Artist3 { get; set; }
        public string Artist4 { get; set; }
        public int Position { get; set; }
    }
}
