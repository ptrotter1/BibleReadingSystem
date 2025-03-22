namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanMode : ISoftDeletable
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    
    public bool IsDeleted { get; set; }
}

public static class ReadingPlanModes
{
    public static readonly ReadingPlanMode OneChapterPerList = new()
    {
        Id = Guid.Parse("CFE77371-FD3C-4D90-82DD-98F6E4443112"),
        Name = "One Chapter Per List"
    };

    public static readonly IReadOnlyList<ReadingPlanMode> All =
    [
        OneChapterPerList
    ];
}