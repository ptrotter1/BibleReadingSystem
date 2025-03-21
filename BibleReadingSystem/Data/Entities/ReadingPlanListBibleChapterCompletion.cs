using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanListBibleChapterCompletion
{
    public int Id { get; set; }
    
    public int ReadingPlanListId { get; set; }
    
    [ForeignKey("ReadingPlanListId")]
    public ReadingPlanList ReadingPlanList { get; set; } = null!;
    
    public int ReadingPlanListInstanceId { get; set; }
    
    [ForeignKey("ReadingPlanListInstanceId")]
    public ReadingPlanListInstance ReadingPlanListInstance { get; set; } = null!;
    
    public int BibleChapterId { get; set; }
    
    [ForeignKey("BibleChapterId")]
    public BibleChapter BibleChapter { get; set; } = null!;
    
    public DateTimeOffset? DateTimeCompleted { get; set; }
    
    public bool IsCompleted => DateTimeCompleted.HasValue;
}