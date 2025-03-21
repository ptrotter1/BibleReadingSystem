using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanInstance
{
    public int Id { get; set; }
    
    public int ReadingPlanId { get; set; }
    
    [ForeignKey("ReadingPlanId")]
    public ReadingPlan ReadingPlan { get; set; } = null!;
    
    public Guid AppUserId { get; set; }
    
    [ForeignKey("AppUserId")]
    public AppUser AppUser { get; set; } = null!;
    
    public DateTimeOffset StartDate { get; set; }
    
    public DateTimeOffset? EndDate { get; set; }
    
    public bool IsCompleted => EndDate.HasValue;
}