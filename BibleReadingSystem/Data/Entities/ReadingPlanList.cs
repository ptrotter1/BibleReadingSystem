using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanList : ISoftDeletable
{
    public Guid Id { get; set; }
    
    [MaxLength(256)]
    public string Name { get; set; } = string.Empty;
    
    public Guid ReadingPlanId { get; set; }
    
    [ForeignKey(nameof(ReadingPlanId))]
    public ReadingPlan ReadingPlan { get; set; } = null!;
    
    public ICollection<ReadingPlanListBibleChapter> BibleChapters { get; set; } = new List<ReadingPlanListBibleChapter>();
    
    public int Order { get; set; }
    public bool IsDeleted { get; set; }
}