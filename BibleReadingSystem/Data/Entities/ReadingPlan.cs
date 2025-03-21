using System.ComponentModel.DataAnnotations;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlan
{
    public int Id { get; set; }
    
    [MaxLength(512)]
    public string Name { get; set; } = string.Empty;
    
    public ICollection<ReadingPlanList> ReadingPlanLists { get; set; } = new List<ReadingPlanList>();
}