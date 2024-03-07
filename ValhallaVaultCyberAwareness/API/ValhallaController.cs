using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.DAL.ApiModel;
using ValhallaVaultCyberAwareness.DAL.ApiModels;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Uow;

namespace ValhallaVaultCyberAwareness.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValhallaController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUow uow;

        public ValhallaController(UserManager<ApplicationUser> userManager, IUow uow)
        {
            this.userManager = userManager;
            this.uow = uow;

        }


        #region HttpGetAll

        [HttpGet("GetAllAnswers")]
        public async Task<IActionResult> GetAllAnswersAsync()
        {
            //Get all Answers
            //var As = await uow.AnswerRepo.GetAllAsync();
            var As = await uow.AnswerRepo.GetAllAsync();


            if (As.Any())
            {
                //Turn Dbmodel to Apimodel
                var ApiAnswersToReturn = As.Select(a => new AnswerApiModel
                {
                    Id = a.Id,
                    Answer = a.Answer,
                    IsCorrectAnswer = a.IsCorrectAnswer,
                    QuestionId = a.QuestionId
                }).ToList();


                return Ok(ApiAnswersToReturn);

            }
            else
            {
                return NotFound("No answers available");
            }

        }


        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            //Get all categories
            var Cate = await uow.CategoryRepo.GetAllAsync();


            if (Cate.Any())
            {
                //Turn Dbmodel to Apimodel
                var ApiCategoriesToReturn = Cate.Select(q => new CategoryApiModel
                {
                    Id = q.Id,
                    Name = q.Name,
                    Segments = q.Segments.Select(s => new SegmentApiModel
                    {
                        Id = s.Id,
                        Name = s.Name,
                        CategoryId = s.CategoryId,
                        Subcategorys = s.Subcategorys.Select(sc => new SubcategoryApiModel
                        {
                            Id = sc.Id,
                            Name = sc.Name,
                            SegmentId = sc.SegmentId,
                            Questions = sc.Questions.Select(q => new QuestionApiModel
                            {
                                Title = q.Title,
                                SubcategoryId = q.SubcategoryId,
                                Answers = q.Answers.Select(a => new AnswerApiModel
                                {
                                    Id = a.Id,
                                    Answer = a.Answer,
                                    IsCorrectAnswer = a.IsCorrectAnswer,
                                    QuestionId = a.QuestionId
                                }).ToList(),

                                //? Do we need to send userresponse?
                                UserResponse = q.UserResponse.Select(ur => new UserResponseApiModel
                                {
                                    Id = ur.Id,
                                    UserId = ur.UserId,
                                    QuestionId = ur.QuestionId
                                }).ToList()

                            }).ToList()
                        }).ToList()
                    }).ToList()

                }).ToList();





                return Ok(ApiCategoriesToReturn);

            }
            else
            {
                return NotFound("No categories available");
            }

        }


        [HttpGet("GetAllQuestions")]
        public async Task<IActionResult> GetAllQuestionsAsync()
        {
            //Get all questions
            var Qs = await uow.QuestionRepo.GetAllAsync();


            if (Qs.Any())
            {
                //Turn Dbmodel to Apimodel
                var ApiQuestionsToReturn = Qs.Select(q => new QuestionApiModel
                {
                    Title = q.Title,
                    SubcategoryId = q.SubcategoryId,
                    Answers = q.Answers.Select(a => new AnswerApiModel
                    {
                        Id = a.Id,
                        Answer = a.Answer,
                        IsCorrectAnswer = a.IsCorrectAnswer,
                        QuestionId = a.QuestionId
                    }).ToList(),

                    //? Do we need to send userresponse?
                    UserResponse = q.UserResponse.Select(ur => new UserResponseApiModel
                    {
                        Id = ur.Id,
                        UserId = ur.UserId,
                        QuestionId = ur.QuestionId
                    }).ToList()

                }).ToList();


                return Ok(ApiQuestionsToReturn);

            }
            else
            {
                return NotFound("No questions available");
            }

        }

        [HttpGet("GetAllSegments")]
        public async Task<IActionResult> GetAllSegmentsAsync()
        {
            //Get all segments
            var Seg = await uow.SegmentRepo.GetAllAsync();


            if (Seg.Any())
            {
                //Turn Dbmodel to Apimodel
                var ApiSegmentsToReturn = Seg.Select(se => new SegmentApiModel
                {
                    Id = se.Id,
                    Name = se.Name,
                    CategoryId = se.CategoryId,
                    Subcategorys = se.Subcategorys.Select(sc => new SubcategoryApiModel
                    {
                        Id = sc.Id,
                        Name = sc.Name,
                        SegmentId = sc.SegmentId,
                        Questions = sc.Questions.Select(q => new QuestionApiModel
                        {
                            Title = q.Title,
                            SubcategoryId = q.SubcategoryId,
                            Answers = q.Answers.Select(a => new AnswerApiModel
                            {
                                Id = a.Id,
                                Answer = a.Answer,
                                IsCorrectAnswer = a.IsCorrectAnswer,
                                QuestionId = a.QuestionId
                            }).ToList(),

                            //? Do we need to send userresponse?
                            UserResponse = q.UserResponse.Select(ur => new UserResponseApiModel
                            {
                                Id = ur.Id,
                                UserId = ur.UserId,
                                QuestionId = ur.QuestionId
                            }).ToList()

                        }).ToList()
                    }).ToList()
                }).ToList();


                return Ok(ApiSegmentsToReturn);

            }
            else
            {
                return NotFound("No segments available");
            }
        }

        [HttpGet("GetAllSubcategories")]
        public async Task<IActionResult> GetAllSubcategoriesAsync()
        {
            //Get all subcaregories
            var Sub = await uow.SubcategoryRepo.GetAllAsync();


            if (Sub.Any())
            {
                //Turn Dbmodel to Apimodel
                var ApiSubcategoryToReturn = Sub.Select(sb => new SubcategoryApiModel
                {
                    Id = sb.Id,
                    Name = sb.Name,
                    SegmentId = sb.SegmentId,
                    Questions = sb.Questions.Select(q => new QuestionApiModel
                    {
                        Title = q.Title,
                        SubcategoryId = q.SubcategoryId,
                        Answers = q.Answers.Select(a => new AnswerApiModel
                        {
                            Id = a.Id,
                            Answer = a.Answer,
                            IsCorrectAnswer = a.IsCorrectAnswer,
                            QuestionId = a.QuestionId
                        }).ToList(),

                        //? Do we need to send userresponse?
                        UserResponse = q.UserResponse.Select(ur => new UserResponseApiModel
                        {
                            Id = ur.Id,
                            UserId = ur.UserId,
                            QuestionId = ur.QuestionId
                        }).ToList()

                    }).ToList()
                }).ToList();


                return Ok(ApiSubcategoryToReturn);

            }
            else
            {
                return NotFound("No subcategories available");
            }
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            //Get all users
            var user = await uow.UserRepo.GetAllAsync();


            if (user.Any())
            {
                //Turn Dbmodel to Apimodel
                var ApiUserResponseToReturn = user.Select(u => new UserApiModel
                {
                    Id = u.Id,
                    Username = u.UserName,
                    Email = u.Email,
                    Responses = u.Responses.Select(r => new UserResponseApiModel
                    {
                        Id = r.Id,
                        UserId = r.UserId,
                        QuestionId = r.QuestionId
                    }).ToList()

                }).ToList();


                return Ok(ApiUserResponseToReturn);

            }
            else
            {
                return NotFound("No user data available");
            }
        }

        [HttpGet("GetAllUserResponses")]
        public async Task<IActionResult> GetAllUserResponsesAsync()
        {
            //Get all user responses
            var uResp = await uow.UserResponseRepo.GetAllAsync();


            if (uResp.Any())
            {
                //Turn Dbmodel to Apimodel
                var ApiUserResponseToReturn = uResp.Select(ur => new UserResponseApiModel
                {
                    Id = ur.Id,
                    UserId = ur.UserId,
                    QuestionId = ur.QuestionId
                }).ToList();


                return Ok(ApiUserResponseToReturn);

            }
            else
            {
                return NotFound("No responses available");
            }
        }




        #endregion


        #region HttpGetById

        /*[HttpGet("{id}")]
        public async Task<List<UserApiModel>> GetAnswerByAsync(int id)
        {
            return new List<UserApiModel>();
        }*/


        #endregion


        #region HttpPost

        /* [HttpPost]
         public async Task<List<UserApiModel>> GetUserByIdAsync(int id)
         {
             return new List<UserApiModel>();
         }*/


        #endregion


        #region HttpPutById

        /*[HttpPut("id")]
        public async Task<List<UserApiModel>> GetUsByIdAsync(int id)
        {
            return new List<UserApiModel>();
        }*/


        #endregion


        #region HttpDeleteById

        /*[HttpDelete]
        public async Task<List<UserApiModel>> GetUByIdAsync(int id)
        {
            return new List<UserApiModel>();

        }*/


        #endregion




    }
}
