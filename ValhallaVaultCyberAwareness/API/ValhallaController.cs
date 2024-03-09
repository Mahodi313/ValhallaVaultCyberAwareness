using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.API.DataTransferObjects;
using ValhallaVaultCyberAwareness.Components.Pages;
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




        [HttpGet("GetAllSegmentsAndSubcategories")]
        public async Task<IActionResult> GetAllSegmentsAndSubcategoriesAsync()
        {
            //Get all segments
            var Seg = await uow.SegmentRepo.GetAllAsync(s => s.Subcategorys);


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
            var Sub = await uow.SubcategoryRepo.GetAllAsync(su => su.Questions);


            if (Sub.Any())
            {
                //Turn Dbmodel to Apimodel
                var ApiSubcategoryToReturn = Sub.Select(sb => new SubcategoryApiModel
                {
                    Id = sb.Id,
                    Name = sb.Name,
                    SegmentId = sb.SegmentId,

                }).ToList();


                return Ok(ApiSubcategoryToReturn);

            }
            else
            {
                return NotFound("No subcategories available");
            }
        }

        [HttpGet("GetAllQuestionsAndAnswers")]
        public async Task<IActionResult> GetAllQuestionsAndAnswersAsync()
        {
            //Get all questions
            var Qs = await uow.QuestionRepo.GetAllAsync(q => q.Answers, q => q.UserResponse);


            if (Qs.Any())
            {
                //Turn Dbmodel to Apimodel
                var ApiQuestionsToReturn = Qs.Select(q => new QuestionApiModel
                {
                    Id = q.Id,
                    Title = q.Title,
                    SubcategoryId = q.SubcategoryId,
                    Answers = q.Answers.Select(a => new AnswerApiModel
                    {
                        Id = a.Id,
                        Answer = a.Answer,
                        IsCorrectAnswer = a.IsCorrectAnswer,
                        Explanation = a.Explanation,
                        QuestionId = a.QuestionId
                    }).ToList(),

                }).ToList();


                return Ok(ApiQuestionsToReturn);

            }
            else
            {
                return NotFound("No questions available");
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

                }).ToList();


                return Ok(ApiUserResponseToReturn);

            }
            else
            {
                return NotFound("No user data available");
            }
        }

        [HttpGet("GetAllUsersAndResponses")]
        public async Task<IActionResult> GetAllUsersAndResponsesAsync()
        {
            //Get all users
            var user = await uow.UserRepo.GetAllAsync(u => u.Responses);


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
                        IsCorrect = r.IsCorrect,
                        UserId = r.UserId,
                        QuestionId = r.QuestionId
                    }).ToList()

                }).ToList();

                //TODO: Kolla så att responses följer med sen när det finns fler användare som har gått igenom utbildningen..

                return Ok(ApiUserResponseToReturn);

            }
            else
            {
                return NotFound("No user data available");
            }
        }






        #endregion


        #region HttpGetById

        //TODO: Går inte att hämta i alla led, behövs det ens? Se över det sen!
        //[HttpGet("GetCategoryAndMetadataById/{Id}")]
        //public async Task<IActionResult> GetCategoryAndMetadataById(int id)
        //{
        //    //Get all categories
        //    var Cat = await uow.CategoryRepo.GetCategoryIncludeSegmentAsync();
        //    var Seg = Cat[id].Segments.ToList();
        //    var Sub = Seg.Select(async s =>
        //    {
        //        var SubFromSeg = await uow.SubcategoryRepo.GetSubcategoryBySegmentAsync(s.Id);
        //        return SubFromSeg;
        //    }).ToList();

        //    //var Ques = await uow.QuestionRepo.GetByIdAsync(Sub.Id);
        //    //var Ans = await uow.AnswerRepo.GetAnswerForQuestionAsync(Ques.Id);


        //    if (Cat.Any())
        //    {
        //        //Turn Dbmodel to Apimodel<
        //        var ApiCategoryToReturn = new CategoryApiModel
        //        {
        //            Id = Cat[id].Id,
        //            Name = Cat[id].Name,
        //            Segments = Seg.Select(s => new SegmentApiModel
        //            {
        //                Id = s.Id,
        //                Name = s.Name,
        //                CategoryId = s.CategoryId,
        //                /*Subcategorys = Sub.Select(su => su.SegmentId == s.Id).Select(sc => new SubcategoryApiModel
        //                {
        //                    Id = sc.Id,
        //                    Name = sc.Name,
        //                    SegmentId = sc.SegmentId,
        //                    Questions = Ques.Where(q => q.SubcategoryId == sc.Id).Select(q => new QuestionApiModel
        //                    {
        //                        Title = q.Title,
        //                        SubcategoryId = q.SubcategoryId,
        //                        Answers = q.Answers.Select(a => new AnswerApiModel
        //                        {
        //                            Id = a.Id,
        //                            Answer = a.Answer,
        //                            IsCorrectAnswer = a.IsCorrectAnswer,
        //                            Explanation = a.Explanation,
        //                            QuestionId = a.QuestionId
        //                        }).ToList(),

        //                    }).ToList()
        //                }).ToList()*/
        //            }).ToList()

        //        };





        //        return Ok(ApiCategoryToReturn);

        //    }
        //    else
        //    {
        //        return NotFound("No categories available");
        //    }

        //}





        [HttpGet("GetQuestionAndItsAnswersById/{id}")]
        public async Task<IActionResult> GetQuestionAndItsAnswersByIdAsync(int id)
        {
            var Ques = await uow.QuestionRepo.GetByIdAsync(id);

            if (Ques != null)
            {
                var Ans = await uow.AnswerRepo.GetAnswerForQuestionAsync(Ques.Id);

                //Turn Dbmodel to Apimodel<
                var ApiQuestionToReturn = new QuestionApiModel
                {
                    Id = Ques.Id,
                    Title = Ques.Title,
                    SubcategoryId = Ques.SubcategoryId,
                    Answers = Ans.Select(a => new AnswerApiModel
                    {
                        Id = a.Id,
                        Answer = a.Answer,
                        IsCorrectAnswer = true,
                        QuestionId = a.QuestionId,
                        Explanation = a.Explanation
                    }).ToList()

                };


                return Ok(ApiQuestionToReturn);

            }
            else
            {
                return NotFound("No question found  with that id!");
            }

        }






        #endregion


        #region HttpPost











        #endregion

        #region HttpDeleteById







        [HttpDelete("DeleteAnswer/{id}")]
        //Answer
        public async Task<IActionResult> DeleteAnswer(int id)
        {
            if (id <= 0)
            {
                return BadRequest("The Id can't be less than 1");
            }
            else
            {
                try
                {
                    var answer = await uow.AnswerRepo.GetByIdAsync(id);
                    await uow.AnswerRepo.DeleteAsync(id);
                    await uow.SaveChanges();

                    return Ok("Answer was successfully deleted!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no answer with that id! Please try again...");
                }
            }
        }
    }


        #endregion
}

