using BibleReadingSystem.Data.Entities;
using BibleReadingSystem.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BibleReadingSystem.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>(options)
{
    private const string DefaultSchema = "brs";
    
    public DbSet<BibleBook> BibleBooks { get; set; } = null!;
    public DbSet<BibleChapter> BibleChapters { get; set; } = null!;
    public DbSet<ReadingPlan> ReadingPlans { get; set; } = null!;
    public DbSet<ReadingPlanInstance> ReadingPlanInstances { get; set; } = null!;
    public DbSet<ReadingPlanList> ReadingPlanLists { get; set; } = null!;
    public DbSet<ReadingPlanListBibleChapter> ReadingPlanListBibleChapters { get; set; } = null!;
    public DbSet<ReadingPlanListBibleChapterCompletion> ReadingPlanListBibleChapterCompletions { get; set; } = null!;
    public DbSet<ReadingPlanListInstance> ReadingPlanListInstances { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.HasDefaultSchema(DefaultSchema);
        
        // Rename Identity tables
        builder.Entity<AppUser>(entity => entity.ToTable("AppUsers"));
        builder.Entity<AppRole>(entity => entity.ToTable("AppRoles"));
        builder.Entity<AppUserClaim>(entity => entity.ToTable("AppUserClaims"));
        builder.Entity<AppUserRole>(entity => entity.ToTable("AppUserRoles"));
        builder.Entity<AppUserLogin>(entity => entity.ToTable("AppUserLogins"));
        builder.Entity<AppRoleClaim>(entity => entity.ToTable("AppRoleClaims"));
        builder.Entity<AppUserToken>(entity => entity.ToTable("AppUserTokens"));

        builder.Entity<BibleBook>().HasData(Entities.BibleBooks.All);
        builder.Entity<BibleChapter>().HasData(Entities.BibleChapters.All);
        
        // Add the default query filter for entities that implement ISoftDeletable
        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            if (typeof(ISoftDeletable).IsAssignableFrom(entityType.ClrType))
            {
                entityType.AddSoftDeleteQueryFilter();
            }
            
            // Turn off cascading deletes
            foreach (var foreignKey in entityType.GetForeignKeys())
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}