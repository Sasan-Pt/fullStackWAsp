using fullStackWAsp.Classes;
using fullStackWAsp.enums;

namespace fullStackWAsp.Dtos.Media
{
    public class EditMediaDto
    {
        public MediaType MediaType { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
        
        public required string Title { get; set; }
        public required string EnTitle { get; set; }
        
        public required bool SubTitle { get; set; }
        public long Duration { get; set; }
        public string Description { get; set; }
        public string IntroVideoUrl { get; set; }
        public string BannerUrl { get; set; }
        public Status Status { get; set; }
    }
}
