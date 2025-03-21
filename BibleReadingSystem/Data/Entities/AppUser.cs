using Microsoft.AspNetCore.Identity;

namespace BibleReadingSystem.Data.Entities;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser<Guid>
{

}