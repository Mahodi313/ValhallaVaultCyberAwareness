using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.DAL.ApiModels;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Uow;

namespace ValhallaVaultCyberAwareness.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUow uow;

        public UserController(UserManager<ApplicationUser> userManager, IUow uow)
        {
            this.userManager = userManager;
            this.uow = uow;
        }


        #region //[HttpGetAll]

        [HttpGet]
        public IActionResult GetAllQuestionsAsync()
        {
            //Get all questions
            List<QuestionModel> Qs = new List<QuestionModel>();
            Qs = uow.QuestionRepo.GetAllQuestions();

            List<QuestionApiModel> ApiQuestionsToReturn = new List<QuestionApiModel>();


            if (Qs.Any())
            {
                //Turn Dbmodel to Apimodel
                foreach (QuestionModel q in Qs)
                {
                    List<AnswerApiModel> As = new List<AnswerApiModel>();
                    List<UserResponseApiModel> URs = new List<UserResponseApiModel>();

                    //Get all answers to question
                    foreach (AnswerModel a in q.Answers)
                    {
                        AnswerApiModel answer = new AnswerApiModel()
                        {
                            Id = a.Id,
                            Answer = a.Answer,
                            IsCorrectAnswer = a.IsCorrectAnswer,
                            QuestionId = a.QuestionId

                        };

                        As.Add(answer);

                    }

                    //get all user responses to question
                    foreach (UserResponseModel ur in q.UserResponse)
                    {
                        UserResponseApiModel userResp = new UserResponseApiModel()
                        {
                            Id = ur.Id,
                            UserId = ur.UserId,
                            QuestionId = ur.QuestionId

                        };

                        URs.Add(userResp);

                    }

                    //new apimodel 
                    QuestionApiModel ApiQuestion = new()
                    {
                        Title = q.Title,
                        SubcategoryId = q.SubcategoryId,
                        Answers = As,
                        UserResponse = URs
                    };

                    ApiQuestionsToReturn.Add(ApiQuestion);

                }

                return Ok(ApiQuestionsToReturn);

            }

            return NotFound("No questions awailable");

        }




        #endregion


        #region //[HttpGetById]

        /*[HttpGet("{id}")]
        public async Task<List<UserApiModel>> GetAnswerByAsync(int id)
        {
            return new List<UserApiModel>();
        }*/


        #endregion


        #region //[HttpPost]

        //[HttpPost]
        /*public async Task<List<UserApiModel>> GetUserByIdAsync(int id)
        {
            return new List<UserApiModel>();
        }*/


        #endregion


        #region //[HttpPutById]

        //[HttpPut("id")]
        /*public async Task<List<UserApiModel>> GetUsByIdAsync(int id)
        {
            return new List<UserApiModel>();
        }*/


        #endregion


        #region //[HttpDeleteById]

        //[HttpDelete]
        /*public async Task<List<UserApiModel>> GetUByIdAsync(int id)
        {
            return new List<UserApiModel>();

        }
    */

        #endregion


    }

}
