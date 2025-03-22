using System.ComponentModel.DataAnnotations;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlan : ISoftDeletable
{
    public Guid Id { get; set; }
    
    [MaxLength(512)]
    public string Name { get; set; } = string.Empty;
    
    public ICollection<ReadingPlanList> ReadingPlanLists { get; set; } = new List<ReadingPlanList>();
    public bool IsDeleted { get; set; }
}