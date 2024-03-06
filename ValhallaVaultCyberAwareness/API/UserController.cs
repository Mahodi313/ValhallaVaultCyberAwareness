using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.DAL.ApiModel;
using ValhallaVaultCyberAwareness.DAL.ApiModels;
using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericUserController<T> : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;

        public GenericUserController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }


        #region //[HttpGetAll]

        [HttpGet]
        public async Task<List<AnswerApiModel>> GetAllAnswersAsync()
        {

            List<AnswerApiModel> ApiAnswers = new List<AnswerApiModel>();

            foreach (var user in await userManager.Users.ToListAsync())
            {
                UserApiModel ApiUser = new UserApiModel
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Email = user.Email

                };
                //user.Add(ApiUser);


            }

            return ApiAnswers;
        }

        #endregion


        #region //[HttpGetById]

        [HttpGet("{id}")]
        public async Task<List<UserApiModel>> GetAnswerByIdAsync(int id)
        {
            return new List<UserApiModel>();
        }


        #endregion


        #region //[HttpPost]

        [HttpPost]
        public async Task<List<UserApiModel>> GetUserByIdAsync(int id)
        {
            return new List<UserApiModel>();
        }


        #endregion


        #region //[HttpPutById]

        [HttpPut("id")]
        public async Task<List<UserApiModel>> GetUsByIdAsync(int id)
        {
            return new List<UserApiModel>();
        }


        #endregion


        #region //[HttpDeleteById]

        [HttpDelete("id")]
        public async Task<List<UserApiModel>> GetUByIdAsync(int id)
        {
            return new List<UserApiModel>();

        }


        #endregion

    }
}
