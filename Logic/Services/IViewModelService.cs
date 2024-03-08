using ValhallaVaultCyberAwareness.DAL.ViewModel;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public interface IViewModelService
    {
        public Task<List<CategoryViewModel>> GetAllCategoriesAndMeta();
        /*public Task <SegmentViewModel> GetSegments();
        public Task<SubcategoryViewModel> GetSubcategories();
        public Task<>*/
    }
}
