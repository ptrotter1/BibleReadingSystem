using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanList
{
    public int Id { get; set; }
    
    [MaxLength(256)]
    public string Name { get; set; } = string.Empty;
    
    public int ReadingPlanId { get; set; }
    
    [ForeignKey("ReadingPlanId")]
    public ReadingPlan ReadingPlan { get; set; } = null!;
    
    public ICollection<ReadingPlanListBibleChapter> BibleChapters { get; set; } = new List<ReadingPlanListBibleChapter>();
    
    public int Order { get; set; }
}