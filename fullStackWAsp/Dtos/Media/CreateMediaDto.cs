using fullStackWAsp.enums;

namespace fullStackWAsp.Dtos.Media
{
    public class CreateMediaDto
    {
        public MediaType MediaType { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
        public required string Code { get; set; }
        public required string Title { get; set; }
        public required string EnTitle { get; set; }
        public  required string Slug { get; set; }
        public required bool SubTitle { get; set; }
        public long Duration { get; set; }
        public required string Description { get; set; }
        public string? IntroVideoUrl { get; set; }
        public required string BannerUrl { get; set; }
        public Status Status { get; set; }

    }
}
