using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.DAL.DbModels
{
    public class AnswerModel
    {
        [Key]
        public int Id { get; set; }
        public string Answer { get; set; } = null!;
        public bool IsCorrectAnswer { get; set; } = false;
        public string? Explanation { get; set; } = null;
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; } = null!;


    }
}
