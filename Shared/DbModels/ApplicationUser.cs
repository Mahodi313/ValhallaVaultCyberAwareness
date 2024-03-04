using Microsoft.AspNetCore.Identity;

namespace Shared.DbModels
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<UserResponseModel> Responses { get; set; } = new();
    }

}
