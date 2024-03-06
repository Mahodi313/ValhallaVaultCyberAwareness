using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.DAL.DbModels
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int SubcategoryId { get; set; }
        public SubcategoryModel Subcategory { get; set; } = null!;
        public List<AnswerModel> Answers { get; set; } = new();
        public List<UserResponseModel> UserResponse { get; set; } = new();

    }
}
