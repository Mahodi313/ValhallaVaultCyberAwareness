using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.DAL.DbModels
{
    public class UserResponseModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; } = null!;
        public int? AnswerId { get; set; }
    }
}
