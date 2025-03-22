using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanListBibleChapterCompletion : ISoftDeletable
{
    public Guid Id { get; set; }
    
    public Guid ReadingPlanListId { get; set; }
    
    [ForeignKey(nameof(ReadingPlanListId))]
    public ReadingPlanList ReadingPlanList { get; set; } = null!;
    
    public Guid ReadingPlanListInstanceId { get; set; }
    
    [ForeignKey(nameof(ReadingPlanListInstanceId))]
    public ReadingPlanListInstance ReadingPlanListInstance { get; set; } = null!;
    
    public Guid BibleChapterId { get; set; }
    
    [ForeignKey(nameof(BibleChapterId))]
    public BibleChapter BibleChapter { get; set; } = null!;
    
    public DateTimeOffset? DateTimeCompleted { get; set; }
    
    public bool IsCompleted => DateTimeCompleted.HasValue;
    
    public bool IsDeleted { get; set; }
}