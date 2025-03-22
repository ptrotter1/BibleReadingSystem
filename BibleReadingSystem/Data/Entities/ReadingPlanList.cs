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
    
    public ICollection<ReadingPlanListBibleBook> BibleBooks { get; set; } = new List<ReadingPlanListBibleBook>();
    public ICollection<ReadingPlanListBibleChapter> BibleChapters { get; set; } = new List<ReadingPlanListBibleChapter>();
    
    public int Order { get; set; }
    public bool IsDeleted { get; set; }
}

public static class ReadingPlanLists
{
    public static readonly ReadingPlanList ProfessorGrantHornerList1 = new()
    {
        Id = Guid.Parse("BBC79590-54BC-4189-B072-DD44C60492AD"),
        Name = "List 1",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 1
    };
    
    public static readonly ReadingPlanList ProfessorGrantHornerList2 = new()
    {
        Id = Guid.Parse("0081F906-5098-412A-8BC0-823B5CC09CEF"),
        Name = "List 2",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 2
    };
    
    public static readonly ReadingPlanList ProfessorGrantHornerList3 = new()
    {
        Id = Guid.Parse("9D84E0DE-8592-47E1-86A5-252F3111240D"),
        Name = "List 3",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 3
    };
    
    public static readonly ReadingPlanList ProfessorGrantHornerList4 = new()
    {
        Id = Guid.Parse("918615D5-C406-4E9B-8916-FD265B203C3A"),
        Name = "List 4",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 4
    };
    
    public static readonly ReadingPlanList ProfessorGrantHornerList5 = new()
    {
        Id = Guid.Parse("35FE8B97-642E-405A-961E-6B56A2D596AD"),
        Name = "List 5",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 5
    };
    
    public static readonly ReadingPlanList ProfessorGrantHornerList6 = new()
    {
        Id = Guid.Parse("1BD7761B-7EB8-40CF-ACE0-8E59DB3A9BF0"),
        Name = "List 6",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 6
    };
    
    public static readonly ReadingPlanList ProfessorGrantHornerList7 = new()
    {
        Id = Guid.Parse("A9E354CA-A508-443F-9676-10D097518BAC"),
        Name = "List 7",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 7
    };
    
    public static readonly ReadingPlanList ProfessorGrantHornerList8 = new()
    {
        Id = Guid.Parse("BF640718-0C8B-4236-AFB6-3B5EA43FFCD7"),
        Name = "List 8",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 8
    };
    
    public static readonly ReadingPlanList ProfessorGrantHornerList9 = new()
    {
        Id = Guid.Parse("FAA7B54A-5D4D-4BF8-A767-ABC9DC4AA7EF"),
        Name = "List 9",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 9
    };
    
    public static readonly ReadingPlanList ProfessorGrantHornerList10 = new()
    {
        Id = Guid.Parse("FF3633CA-F6B6-4E03-9E94-451AC1FC6846"),
        Name = "List 10",
        ReadingPlanId = ReadingPlans.ProfessorGrantHorner.Id,
        Order = 10
    };
    
    public static readonly IReadOnlyList<ReadingPlanList> All = 
    [
        ProfessorGrantHornerList1,
        ProfessorGrantHornerList2,
        ProfessorGrantHornerList3,
        ProfessorGrantHornerList4,
        ProfessorGrantHornerList5,
        ProfessorGrantHornerList6,
        ProfessorGrantHornerList7,
        ProfessorGrantHornerList8,
        ProfessorGrantHornerList9,
        ProfessorGrantHornerList10
    ];
}