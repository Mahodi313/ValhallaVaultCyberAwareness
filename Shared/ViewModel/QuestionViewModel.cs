using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.DAL.ViewModel
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Question titel is required!")]
        [MinLength(2, ErrorMessage = "Question title must be at least 2 characters long!")]
        public string Title { get; set; } = null!;
        public List<AnswerViewModel> Answers { get; set; } = new();
        public int SubcategoryId { get; set; }
        public SubcategoryViewModel Subcategory { get; set; } = null!;
        public List<UserViewResponse> UserResponses { get; set; } = new();
    }
}
