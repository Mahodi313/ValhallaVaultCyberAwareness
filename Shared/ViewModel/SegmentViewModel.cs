using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModel
{
    public class SegmentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Segment name is required!")]
        [MinLength(2, ErrorMessage = "Segment name must be at least 2 characters long!")]
        public string? Name { get; set; }
        public int CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }
        public List<SubcategoryViewModel> Subcategories { get; set; } = new();
    }
}
