using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanInstance : ISoftDeletable
{
    public Guid Id { get; set; }
    
    public Guid ReadingPlanId { get; set; }
    
    [ForeignKey(nameof(ReadingPlanId))]
    public ReadingPlan ReadingPlan { get; set; } = null!;
    
    public Guid AppUserId { get; set; }
    
    [ForeignKey(nameof(AppUserId))]
    public AppUser AppUser { get; set; } = null!;
    
    public DateTimeOffset StartDate { get; set; }
    
    public DateTimeOffset? EndDate { get; set; }
    
    public bool IsCompleted => EndDate.HasValue;
    public bool IsDeleted { get; set; }
}