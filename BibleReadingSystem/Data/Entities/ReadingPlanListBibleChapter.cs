using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanListBibleChapter : ISoftDeletable
{
    public Guid Id { get; set; }
    
    public Guid ReadingPlanListId { get; set; }
    
    [ForeignKey(nameof(ReadingPlanListId))]
    public ReadingPlanList ReadingPlanList { get; set; } = null!;
    
    public Guid BibleChapterId { get; set; }
    
    [ForeignKey(nameof(BibleChapterId))]
    public BibleChapter BibleChapter { get; set; } = null!;
    public bool IsDeleted { get; set; }
}