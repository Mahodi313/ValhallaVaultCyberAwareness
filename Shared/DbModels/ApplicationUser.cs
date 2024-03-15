using Microsoft.AspNetCore.Identity;

namespace ValhallaVaultCyberAwareness.DAL.DbModels
{
    public class ApplicationUser : IdentityUser
    {
        public List<UserResponseModel> Responses { get; set; } = new();
    }

}
