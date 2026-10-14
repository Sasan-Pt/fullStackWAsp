using fullStackWAsp.Classes;
using fullStackWAsp.Dtos.Media;
using fullStackWAsp.enums;

public class MediaEntity : BaseEntity
{
    public MediaType MediaType { get; set; }

    public DateTimeOffset ReleaseDate { get; set; }
 
    public required string Code { get; set; }

    public required string Title { get; set; }

    public required string EnTitle { get; set; }

    public required string Slug { get; set; }

    public required bool SubTitle { get; set; }

    public long Duration { get; set; }

    public string? Description { get; set; }

    public string? IntroVideoUrl { get; set; }

    public string? BannerUrl { get; set; }

    public Status Status { get; set; }

    // Navigation property
    public ICollection<SeasonEntity> Seasons { get; set; } = [];
}