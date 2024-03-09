using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.API.DataTransferObjects;
using ValhallaVaultCyberAwareness.Components.Pages;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Uow;

namespace ValhallaVaultCyberAwareness.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SegmentController : ControllerBase
    {
        private readonly IUow uow;

        public SegmentController(IUow uow)
        {
            this.uow = uow;
        }

        #region HttpGet
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<SegmentDTO>>> GetAll()
        {
            try
            {
                var segments = await uow.SegmentRepo.GetAllAsync();

                if (segments == null || segments.Count == 0)
                {
                    return NotFound("No segments found!");
                }

                return Ok(segments);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving segment");
            }
        }

        [HttpGet("GetSegmentById/{id}")]
        public async Task<ActionResult<SegmentDTO>> GetSegmentById(int id)
        {
            try
            {
                var segment = await uow.SegmentRepo.GetByIdAsync(id);

                if (segment == null)
                {
                    return NotFound("There are no segments with that id!");
                }

                var ApiSegmentToSave = new CategoryDTO
                {
                    Id = segment.Id,
                    Name = segment.Name,
                    Info = segment.Info
                };

                return Ok(ApiSegmentToSave);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the segment");
            }
        }
        #endregion

        #region HttpPost
        [HttpPost("OnPostSegment")]
        public async Task<IActionResult> OnPostSegment([FromBody] SegmentPostDTO segment)
        {
            if (segment == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                // Transfer the DTO to Db-Model
                SegmentModel segmentToAdd = new()
                {
                    Name = segment.Name,
                    Info = segment.Info,
                    CategoryId = segment.CategoryId,

                };

                await uow.SegmentRepo.CreateAsync(segmentToAdd);
                await uow.SaveChanges();

                return Ok("Segment was successfully added!");
            }
        }
        #endregion

        #region HttpPut
        [HttpPut("UpdateSegment")]
        public async Task<IActionResult> OnPut([FromBody] SegmentDTO segment)
        {
            if (segment == null)
            {
                return BadRequest("Error: Invalid input! Please try again..");
            }
            else
            {
                try
                {
                    SegmentModel segmentToUpdate = new()
                    {
                        Id = segment.Id,
                        Name = segment.Name,
                        Info = segment.Info,
                        CategoryId = segment.CategoryId,
                    };

                    await uow.SegmentRepo.UpdateAsync(segmentToUpdate);

                    return Ok("Segment was successfully updated!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no segment with that id! Please try again...");
                }
            }
        }
        #endregion

        #region HttpDelete
        [HttpDelete("DeleteSegment/{id}")]
        //Segment
        public async Task<IActionResult> DeleteSegment(int id)
        {
            if (id <= 0)
            {
                return BadRequest("The Id can't be less than 1");
            }
            else
            {
                try
                {
                    var segment = await uow.SegmentRepo.GetByIdAsync(id);
                    await uow.SegmentRepo.DeleteAsync(id);
                    await uow.SaveChanges();

                    return Ok("Segment was successfully deleted!");
                }
                catch (InvalidOperationException)
                {
                    return NotFound("There is no segment with that id! Please try again...");
                }
            }
        }
        #endregion  

    }
}