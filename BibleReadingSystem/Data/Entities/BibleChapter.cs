using System.ComponentModel.DataAnnotations;

namespace BibleReadingSystem.Data.Entities;

public class BibleChapter
{
    public int Id { get; set; }
    
    [MaxLength(16)]
    public string Name { get; set; } = string.Empty;
}