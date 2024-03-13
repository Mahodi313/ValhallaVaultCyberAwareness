namespace ValhallaVaultCyberAwareness.API.Models
{

    /*
     * These API models are used for specific methods in the controllers
     * These Controllers are: QuestionController and CategoryController
     * The methods that are mentioned are:
     * 
     * GetAllCategoriesAndMetadata -> CategoryController
     * GetQuestionAndItsAnswersById -> QuestionController
     * 
     */

    public class CategoryApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<SegmentApiModel> Segments { get; set; } = new();
    }

    public class SegmentApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public List<SubcategoryApiModel> Subcategorys { get; set; } = new();
    }

    public class SubcategoryApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Info { get; set; }
        public int SegmentId { get; set; }
        public List<QuestionApiModel> Questions { get; set; } = new();
    }

    public class QuestionApiModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int SubcategoryId { get; set; }
        public List<AnswerApiModel> Answers { get; set; } = new();
        public List<UserResponseApiModel> UserResponse { get; set; } = new();
    }

    public class AnswerApiModel
    {
        public int Id { get; set; }
        public string Answer { get; set; } = null!;
        public bool IsCorrectAnswer { get; set; }
        public string? Explanation { get; set; }
        public int QuestionId { get; set; }
    }

    public class UserResponseApiModel
    {
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string UserId { get; set; } = null!;
        public int QuestionId { get; set; }
        public int? AnswerId { get; set; }
    }
}
