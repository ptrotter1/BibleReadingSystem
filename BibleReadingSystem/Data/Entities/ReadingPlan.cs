using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlan : ISoftDeletable
{
    public Guid Id { get; set; }
    
    [MaxLength(512)]
    public string Name { get; set; } = string.Empty;
    
    public ICollection<ReadingPlanList> ReadingPlanLists { get; set; } = new List<ReadingPlanList>();
    public bool IsDeleted { get; set; }
    
    public Guid ReadingPlanModeId { get; set; }
    
    [ForeignKey(nameof(ReadingPlanModeId))]
    public ReadingPlanMode ReadingPlanMode { get; set; } = null!;
}

public static class ReadingPlans
{
    public static readonly ReadingPlan ProfessorGrantHorner = new()
    {
        Id = Guid.Parse("02FD2897-C17C-44AB-869F-94817F2790C8"),
        Name = "Professor Grant Horner's Bible Reading System",
        ReadingPlanModeId = ReadingPlanModes.OneChapterPerList.Id
    };
    
    public static readonly IReadOnlyList<ReadingPlan> All = 
    [
        ProfessorGrantHorner
    ];
}