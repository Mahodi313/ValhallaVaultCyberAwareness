namespace ValhallaVaultCyberAwareness.App.Services
{
    public interface IQuestionService
    {
        Task<bool> CanAccessQuestion(int segmentId, int subcategoryId, int questionId, string userId);
    }
}
