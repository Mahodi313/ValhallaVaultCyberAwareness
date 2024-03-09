using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.API.DataTransferObjects;
using ValhallaVaultCyberAwareness.API.Models;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Uow;

namespace ValhallaVaultCyberAwareness.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IUow uow;

        public QuestionController(IUow uow)
        {
            this.uow = uow;
        }

        #region HttpGet

        [HttpGet("GetAllQuestions")]
        public async Task<ActionResult<QuestionDTO>> GetAllQuestions()
        {
            try
            {
                var questions = await uow.QuestionRepo.GetAllAsync();

                if (questions.Any())
                {
                    var ApiQuestionToSave = questions.Select(q => new QuestionDTO
                    {
                        Id = q.Id,
                        Title = q.Title,
                        SubcategoryId = q.SubcategoryId,

                    }).ToList();

                    return Ok(ApiQuestionToSave);
                }
                else
                {
                    return NotFound("Questions not found!");
                }
            }
            catch (Exception) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving questions!");
            }
        }

        [HttpGet("GetQuestionById/{id}")]
        public async Task<ActionResult<QuestionDTO>> GetQuestionById(int id)
        {
            try
            {
                var question = await uow.QuestionRepo.GetByIdAsync(id);

                if (question != null)
                {

                    //Turn Dbmodel to Apimodel<
                    var ApiQuestionToSave = new QuestionDTO
                    {
                        Id = question.Id,
                        Title = question.Title,
                        SubcategoryId = question.SubcategoryId
                    };


                    return Ok(ApiQuestionToSave);

                }
                else
                {
                    return NotFound("There are no question with that id!");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving question by id");
            }

        }

        [HttpGet("GetQuestionAndItsAnswersById/{id}")]
        public async Task<ActionResult<QuestionApiModel>> GetQuestionAndItsAnswersById(int id)
        {
            try
            {
                var Ques = await uow.QuestionRepo.GetByIdAsync(id);

                if (Ques != null)
                {
                    var Ans = await uow.AnswerRepo.GetAnswerForQuestionAsync(Ques.Id);

                    // Turn Dbmodel to Apimodel
                    var ApiQuestionToReturn = new QuestionApiModel
                    {
                        Id = Ques.Id,
                        Title = Ques.Title,
                        SubcategoryId = Ques.SubcategoryId,
                        Answers = Ans.Select(a => new AnswerApiModel
                        {
                            Id = a.Id,
                            Answer = a.Answer,
                            IsCorrectAnswer = a.IsCorrectAnswer,
                            QuestionId = a.QuestionId,
                            Explanation = a.Explanation
                        }).ToList()
                    };

                    return Ok(ApiQuestionToReturn);
                }
                else
                {
                    return NotFound("No question found with that id!");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        #endregion

        #region HttpPost

        [HttpPost("OnPostQuestion")]
        public async Task<IActionResult> OnPostQuestion([FromBody] QuestionPostDTO question)
        {
            if (question == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                // Transfer the DTO to Db-Model
                QuestionModel questionToAdd = new()
                {
                    Title = question.Title,
                    SubcategoryId = question.SubcategoryId
                };

                await uow.QuestionRepo.CreateAsync(questionToAdd);
                await uow.SaveChanges();

                return Ok("Question was successfully added!");
            }
        }

        #endregion

        #region HttpPut
        [HttpPut("UpdateQuestion")]
        public async Task<IActionResult> OnPut([FromBody] QuestionDTO question)
        {
            if (question == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                try
                {
                    QuestionModel questionToUpdate = new()
                    {
                        Id = question.Id,
                        Title = question.Title,
                        SubcategoryId = question.SubcategoryId
                    };

                    await uow.QuestionRepo.UpdateAsync(questionToUpdate);

                    return Ok("Question was successfully updated!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no question with that id! Please try again...");
                }
            }
        }

        #endregion

        #region HttpDelete
        [HttpDelete("DeleteQuestion/{id}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            if (id <= 0)
            {
                return BadRequest("The Id can't be less than 1");
            }
            else
            {
                try
                {
                    //This variable is only here to check if it exists, if not, it throws exception.
                    var question = await uow.QuestionRepo.GetByIdAsync(id);
                    await uow.QuestionRepo.DeleteAsync(id);
                    await uow.SaveChanges();

                    return Ok("Question was successfully deleted!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no question with that id! Please try again...");
                }
            }
        }
        #endregion
    }
}
