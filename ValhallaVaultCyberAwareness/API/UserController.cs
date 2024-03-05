using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.ApiModel;
using Shared.DbModels;

namespace ValhallaVaultCyberAwareness.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<List<UserApiModel>> GetAllUsersAsync()
        {
            List<UserApiModel> ApiUsers = new List<UserApiModel>();

            foreach (var user in await userManager.Users.ToListAsync())
            {
                UserApiModel ApiUser = new UserApiModel
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Email = user.Email

                };
                ApiUsers.Add(ApiUser);


            }

            return ApiUsers;
        }





    }
}
