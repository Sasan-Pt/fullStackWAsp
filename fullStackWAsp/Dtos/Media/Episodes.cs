using fullStackWAsp.Classes;

public class EpisodeEntity : BaseEntity
{
    public Guid SeasonId { get; set; }   // FK

    public int EpisodeNumber { get; set; }

    public required string Title { get; set; }

    public string? Description { get; set; }

    public int DurationSeconds { get; set; }

    // Navigation property
    public SeasonEntity Season { get; set; } = null!;
}