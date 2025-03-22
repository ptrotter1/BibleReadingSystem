namespace BibleReadingSystem.Data.Entities;

public interface ISoftDeletable
{
    public bool IsDeleted { get; set; }
}