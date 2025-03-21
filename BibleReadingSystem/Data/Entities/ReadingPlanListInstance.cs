using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanListInstance
{
    public int Id { get; set; }
    
    public int ReadingPlanInstanceId { get; set; }
    
    [ForeignKey("ReadingPlanInstanceId")] 
    public ReadingPlanInstance ReadingPlanInstance { get; set; } = null!;
    
    public int ReadingPlanListId { get; set; }
    
    [ForeignKey("ReadingPlanListId")]
    public ReadingPlanList ReadingPlanList { get; set; } = null!;
    
    public Guid AppUserId { get; set; }
    
    [ForeignKey("AppUserId")]
    public AppUser AppUser { get; set; } = null!;
    
    public DateTimeOffset StartDate { get; set; }
    
    public DateTimeOffset? EndDate { get; set; }
    
    public bool IsCompleted => EndDate.HasValue;
    
    public ICollection<ReadingPlanListBibleChapterCompletion> Completions { get; set; } = new List<ReadingPlanListBibleChapterCompletion>();
}