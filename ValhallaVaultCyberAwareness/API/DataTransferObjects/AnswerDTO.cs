namespace ValhallaVaultCyberAwareness.API.DataTransferObjects
{
    public class AnswerDTO
    {
        public int Id { get; set; }
        public string Answer { get; set; } = null!;
        public bool IsCorrectAnswer { get; set; }
        public string? Explanation { get; set; }
        public int QuestionId { get; set; }
    }
}
