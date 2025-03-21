using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanListBibleChapter
{
    public int Id { get; set; }
    
    public int ReadingPlanListId { get; set; }
    
    [ForeignKey("ReadingPlanListId")]
    public ReadingPlanList ReadingPlanList { get; set; } = null!;
    
    [ForeignKey("BibleChapterId")]
    public int BibleChapterId { get; set; }
    
    public BibleChapter BibleChapter { get; set; } = null!;
}