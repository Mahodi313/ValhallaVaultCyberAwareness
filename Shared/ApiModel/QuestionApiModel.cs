namespace ValhallaVaultCyberAwareness.DAL.ApiModels
{
    public class QuestionApiModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int SubcategoryId { get; set; }
        public SubcategoryApiModel Subcategory { get; set; } = null!;
        public List<AnswerApiModel> Answers { get; set; } = new();
        public List<UserResponseApiModel> UserResponse { get; set; } = new();

    }
}
