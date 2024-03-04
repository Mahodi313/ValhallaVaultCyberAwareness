using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name is required!")]
        [MinLength(2, ErrorMessage = "Category name must be at least 2 characters long!")]
        public string? Name { get; set; }
        public List<SegmentViewModel> Segments { get; set; } = new();
    }
}
