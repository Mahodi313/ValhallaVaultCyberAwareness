using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.API.DataTransferObjects;
using ValhallaVaultCyberAwareness.DAL.ApiModels;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Uow;

namespace ValhallaVaultCyberAwareness.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IUow uow;

        public AnswerController(IUow uow)
        {
            this.uow = uow;
        }

        #region HttpGet

        [HttpGet("GetAllAnswers")]
        public async Task<ActionResult<AnswerDTO>> GetAllAnswers()
        {
            try
            {
                var answers = await uow.AnswerRepo.GetAllAsync();

                if (answers.Any())
                {
                    var ApiAnswerToSave = answers.Select(q => new AnswerDTO
                    {
                        Id = q.Id,
                        Answer = q.Answer,
                        IsCorrectAnswer = q.IsCorrectAnswer,
                        Explanation = q.Explanation,
                        QuestionId = q.QuestionId,

                    }).ToList();

                    return Ok(ApiAnswerToSave);
                }
                else
                {
                    return NotFound("Answers not found!");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving answers!");
            }
        }

        [HttpGet("GetAnswerById/{id}")]
        public async Task<ActionResult<AnswerDTO>> GetAnswerById(int id)
        {
            try
            {
                var answer = await uow.AnswerRepo.GetByIdAsync(id);

                if (answer != null)
                {

                    //Turn Dbmodel to Apimodel<
                    var ApiAnswerToSave = new AnswerDTO
                    {
                        Id = answer.Id,
                        Answer = answer.Answer,
                        IsCorrectAnswer = answer.IsCorrectAnswer,
                        Explanation = answer.Explanation,
                        QuestionId = answer.QuestionId,
                    };


                    return Ok(ApiAnswerToSave);

                }
                else
                {
                    return NotFound("There are no answer with that id!");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving answer by id");
            }

        }

        #endregion

        #region HttpPost

        [HttpPost("OnPostAnswer")]
        public async Task<IActionResult> OnPostAnswer([FromBody] AnswerPostDTO answer)
        {
            if (answer == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                AnswerModel answerToAdd = new()
                {
                    Answer = answer.Answer,
                    IsCorrectAnswer = answer.IsCorrectAnswer,
                    Explanation = answer.Explanation,
                    QuestionId = answer.QuestionId
                };

                await uow.AnswerRepo.CreateAsync(answerToAdd);
                await uow.SaveChanges();

                return Ok("Answer was successfully added!");
            }
        }

        #endregion

        #region HttpPut
        [HttpPut("UpdateAnswer")]
        public async Task<IActionResult> OnPut([FromBody] AnswerDTO answer)
        {
            if (answer == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                try
                {
                    AnswerModel answerToUpdate = new()
                    {
                        Id = answer.Id,
                        Answer = answer.Answer,
                        IsCorrectAnswer = answer.IsCorrectAnswer,
                        Explanation = answer.Explanation,
                        QuestionId = answer.QuestionId
                    };

                    await uow.AnswerRepo.UpdateAsync(answerToUpdate);

                    return Ok("Answer was successfully updated!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no answer with that id! Please try again...");
                }
            }
        }

        #endregion

        #region HttpDelete
        [HttpDelete("DeleteAnswer/{id}")]
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
        #endregion
    }
}
