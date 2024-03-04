namespace Shared.ApiModels
{
    public class QuestionApiModel
    {
        int Id { get; set; }
        public string Title { get; set; } = null!;
        public int SubcategoryId { get; set; }
        public SubcategoryApiModel Subcategory { get; set; } = null!;
        public List<UserResponseApiModel> UserResponse { get; set; } = new();

    }
}
