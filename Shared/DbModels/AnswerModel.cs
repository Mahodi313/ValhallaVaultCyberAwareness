using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels
{
    public class AnswerModel
    {
        [Key]
        public int Id { get; set; }
        public string Answer { get; set; } = null!;
        public bool IsCorrectAnswer { get; set; }
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; } = null!;
    }
}
