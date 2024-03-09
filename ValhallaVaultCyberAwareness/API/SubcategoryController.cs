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
    public class SubcategoryController : ControllerBase
    {
        private readonly IUow uow;

        public SubcategoryController(IUow uow)
        {
            this.uow = uow;
        }

        #region HttpGet

        [HttpGet("GetAllSubcategories")]
        public async Task<ActionResult<SubCategoryDTO>> GetAllSubcategories()
        {
            var SubCategory = await uow.SubcategoryRepo.GetAllAsync();


            if (SubCategory.Any())
            {
                var ApiSubCategoriesToSave = SubCategory.Select(q => new SubCategoryDTO
                {
                    Id = q.Id,
                    Name = q.Name,
                    SegmentId = q.SegmentId,


                }).ToList();


                return Ok(ApiSubCategoriesToSave);
            }
            else
            {
                return NotFound("No Subcategories available");
            }
        }

        [HttpGet("GetSubCategoryById/{id}")]
        public async Task<ActionResult<SubCategoryDTO>> GetSubCategoryByIdAsync(int id)
        {
            var subcategory = await uow.SubcategoryRepo.GetByIdAsync(id);

            if (subcategory != null)
            {

                //Turn Dbmodel to Apimodel<
                var ApiSubCategoryToSave = new SubCategoryDTO
                {
                    Id = subcategory.Id,
                    Name = subcategory.Name,
                    SegmentId = subcategory.SegmentId
                };


                return Ok(ApiSubCategoryToSave);

            }
            else
            {
                return NotFound("No subcategory found  with that id!");
            }
        }

        #endregion

        #region HttpPost

        [HttpPost("OnPostSubCategory")]
        public async Task<IActionResult> OnPostSubCategory([FromBody] SubcategoryPostDTO subCategory)
        {
            if (subCategory == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                // Transfer the DTO to Db-Model
                SubcategoryModel subCategoryToAdd = new()
                {
                    Name = subCategory.Name,
                    SegmentId = subCategory.SegmentId,
                };

                await uow.SubcategoryRepo.CreateAsync(subCategoryToAdd);
                await uow.SaveChanges();

                return Ok("Subcategory was successfully added!");
            }
        }

        #endregion

        #region HttpPut
        [HttpPut("UpdateSubCategory")]
        public async Task<IActionResult> OnPut([FromBody] SubCategoryDTO subCategory)
        {
            if (subCategory == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                try
                {
                    SubcategoryModel subCategoryToUpdate = new()
                    {
                        Id= subCategory.Id,
                        Name = subCategory.Name,
                        SegmentId = subCategory.SegmentId,
                    };

                    await uow.SubcategoryRepo.UpdateAsync(subCategoryToUpdate);

                    return Ok("Subcategory was successfully updated!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no subcategory with that id! Please try again...");
                }
            }
        }

        #endregion

        #region HttpDelete
        [HttpDelete("DeleteSubCategory/{id}")]
        public async Task<IActionResult> DeleteSubCategory(int id)
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
                    var subCategory = await uow.SubcategoryRepo.GetByIdAsync(id);
                    await uow.SubcategoryRepo.DeleteAsync(id);
                    await uow.SaveChanges();

                    return Ok("Subcategory was successfully deleted!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no subcategory with that id! Please try again...");
                }
            }
        }
        #endregion
    }
}


