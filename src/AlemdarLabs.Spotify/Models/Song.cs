namespace AlemdarLabs.Spotify.Models
{
    public class Song
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public string AlbumImageUrl { get; set; }
        public int LengthInSeconds { get; set; }
        public bool IsLiked { get; set; }
    }
}
