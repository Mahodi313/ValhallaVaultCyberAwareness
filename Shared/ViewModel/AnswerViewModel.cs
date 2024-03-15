namespace ValhallaVaultCyberAwareness.DAL.ViewModel
{
    public class AnswerViewModel
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Answer is required!")]
        public string Answer { get; set; } = null!;
        public bool IsCorrectAnswer { get; set; }
        public string? Explanation { get; set; }
        public int QuestionId { get; set; }
        public QuestionViewModel Question { get; set; } = null!;
    }
}
