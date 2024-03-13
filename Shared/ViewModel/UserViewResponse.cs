namespace ValhallaVaultCyberAwareness.DAL.ViewModel
{
    public class UserViewResponse
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public int QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public bool IsCorrect { get; set; }
        public UserViewModel? User { get; set; }
        public QuestionViewModel? Question { get; set; }
    }
}
