using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.DAL.ViewModel
{
    public class SubcategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Subcategory name is required!")]
        [MinLength(2, ErrorMessage = "Subcategory name must be at least 2 characters long!")]
        public string Name { get; set; } = null!;
        public int SegmentId { get; set; }
        public SegmentViewModel? Segment { get; set; }
        public List<QuestionViewModel> Questions { get; set; } = new();
    }
}
