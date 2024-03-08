namespace ValhallaVaultCyberAwareness.DAL.ApiModels
{
    public class UserResponseApiModel
    {
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string UserId { get; set; } = null!;
        public int QuestionId { get; set; }

    }
}
