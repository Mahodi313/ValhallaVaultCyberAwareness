namespace Shared.ApiModels
{
    public class AnswerApiModel
    {
        public int Id { get; set; }
        public string Answer { get; set; } = null!;
        public bool IsCorrectAnswer { get; set; }
        public int QuestionId { get; set; }
        public QuestionApiModel Question { get; set; } = null!;
    }
}
