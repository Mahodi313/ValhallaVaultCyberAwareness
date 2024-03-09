using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ValhallaVaultCyberAwareness.API.DataTransferObjects;
using ValhallaVaultCyberAwareness.DAL.ApiModels;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;
using ValhallaVaultCyberAwareness.DAL.Uow;

namespace ValhallaVaultCyberAwareness.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUow uow;

        public CategoryController(IUow uow)
        {
            this.uow = uow;
        }

        #region HttpGet

        [HttpGet("GetAllCategoriesAndMetadata")]
        public async Task<ActionResult<List<CategoryApiModel>>> GetAllCategoriesAndMetadata()
        {
            //Get all categories
            var Cate = await uow.CategoryRepo.GetAllAsync(c => c.Segments);
            var Sub = await uow.SubcategoryRepo.GetAllAsync();
            var Ques = await uow.QuestionRepo.GetAllAsync(q => q.Answers, q => q.UserResponse);

            if (Cate.Any())
            {
                //Turn Dbmodel to Apimodel<
                var ApiCategoriesToReturn = Cate.Select(q => new CategoryApiModel
                {
                    Id = q.Id,
                    Name = q.Name,
                    Segments = q.Segments.Select(s => new SegmentApiModel
                    {
                        Id = s.Id,
                        Name = s.Name,
                        CategoryId = s.CategoryId,
                        Subcategorys = s.Subcategorys.Where(su => su.Segment.Id == s.Id).Select(sc => new SubcategoryApiModel
                        {
                            Id = sc.Id,
                            Name = sc.Name,
                            SegmentId = sc.SegmentId,
                            Questions = Ques.Where(q => q.SubcategoryId == sc.Id).Select(q => new QuestionApiModel
                            {
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

        [HttpGet("GetAllCategories")]
        public async Task<ActionResult<CategoryApiModel>> GetAllCategories()
        {
            //Get all categories
            var Cate = await uow.CategoryRepo.GetAllAsync();


            if (Cate.Any())
            {
                //Turn Dbmodel to Apimodel<
                var ApiCategoriesToReturn = Cate.Select(q => new CategoryApiModel
                {
                    Id = q.Id,
                    Name = q.Name

                }).ToList();


                return Ok(ApiCategoriesToReturn);
            }
            else
            {
                return NotFound("No categories available");
            }
        }

        [HttpGet("GetCategoryById/{id}")]
        public async Task<ActionResult<CategoryDTO>> GetCategoryByIdAsync(int id)
        {
            var Cat = await uow.CategoryRepo.GetByIdAsync(id);

            if (Cat != null)
            {

                //Turn Dbmodel to Apimodel<
                var ApiCategoryToReturn = new CategoryDTO
                {
                    Id = Cat.Id,
                    Title = Cat.Name,
                };


                return Ok(ApiCategoryToReturn);

            }
            else
            {
                return NotFound("No category found  with that id!");
            }

        }

        #endregion

        #region HttpPost

        [HttpPost("OnPostCategory")]
        public async Task<IActionResult> OnPostCategory([FromBody] CategoryPostDTO category)
        {
            if (category == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                // Transfer the DTO to Db-Model
                CategoryModel categoryToAdd = new()
                {
                    Name = category.Title,
                    Info = category.Info
                };

                await uow.CategoryRepo.CreateAsync(categoryToAdd);
                await uow.SaveChanges();

                return Ok("Category was successfully added!");
            }
        }

        #endregion

        #region HttpPut
        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> OnPut([FromBody] CategoryDTO category)
        {
            if (category == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                try
                {
                    var categoryToUpdate = await uow.CategoryRepo.GetByIdAsync(category.Id);

                    categoryToUpdate.Name = category.Title;
                    categoryToUpdate.Info = category.Info;

                    await uow.SaveChanges();

                    return Ok("Category was successfully updated!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no category with that id! Please try again...");
                }
            }
        }

        #endregion

        #region HttpDelete
        [HttpDelete("DeleteCategory/{id}")]
        //Category
        public async Task<IActionResult> DeleteCategory(int id)
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
                    var category = await uow.CategoryRepo.GetByIdAsync(id);
                    await uow.CategoryRepo.DeleteAsync(id);
                    await uow.SaveChanges();

                    return Ok("Category was successfully deleted!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no category with that id! Please try again...");
                }
            }
        }
        #endregion
    }
}
