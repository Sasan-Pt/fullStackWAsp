using fullStackWAsp.Classes;

public class SeasonEntity : BaseEntity
{
    public Guid MediaId { get; set; }   // FK

    public int SeasonNumber { get; set; }

    public required string Title { get; set; }

    // Navigation property
    public MediaEntity Media { get; set; } = null!;

    // Navigation property
    public ICollection<EpisodeEntity> Episodes { get; set; } = [];
}