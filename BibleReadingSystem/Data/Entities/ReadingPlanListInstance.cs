using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanListInstance : ISoftDeletable
{
    public Guid Id { get; set; }
    
    public Guid ReadingPlanInstanceId { get; set; }
    
    [ForeignKey(nameof(ReadingPlanInstanceId))] 
    public ReadingPlanInstance ReadingPlanInstance { get; set; } = null!;
    
    public Guid ReadingPlanListId { get; set; }
    
    [ForeignKey(nameof(ReadingPlanInstanceId))]
    public ReadingPlanList ReadingPlanList { get; set; } = null!;
    
    public Guid AppUserId { get; set; }
    
    [ForeignKey(nameof(AppUserId))]
    public AppUser AppUser { get; set; } = null!;
    
    public DateTimeOffset StartDate { get; set; }
    
    public DateTimeOffset? EndDate { get; set; }
    
    public bool IsCompleted => EndDate.HasValue;
    
    public ICollection<ReadingPlanListBibleChapterCompletion> Completions { get; set; } = new List<ReadingPlanListBibleChapterCompletion>();
    
    public bool IsDeleted { get; set; }
}