namespace ValhallaVaultCyberAwareness.App.Services
{
    public interface ISubcategoryService
    {
        Task<bool> IsOpenSubcategory(int segmentId, int subcategoryId, string userId);
    }
}
