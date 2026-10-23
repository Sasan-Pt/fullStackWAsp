using fullStackWAsp.enums;

namespace fullStackWAsp.Dtos.Media
{
    public class CarouselDto
    {
        public MediaType MediaType { get; set; }
        public required string Title { get; set; }
        public required string EnTitle { get; set; }
        public required string Slug { get; set; }
        public  string? Description { get; set; }
        public  string? BannerUrl { get; set; }
    }
}
