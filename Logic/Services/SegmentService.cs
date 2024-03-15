using System.Security.Claims;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.ViewModel;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public class SegmentService : ISegmentService
    {
        private readonly IViewModelService service;
        private readonly IAuthService authService;
        private readonly IUserResponseService userResponseService;
        private CategoryViewModel? category { get; set; }
        private List<CategoryViewModel>? categories { get; set; }
        private SegmentViewModel? segment { get; set; }
        private List<SegmentViewModel>? segments { get; set; }
        private List<SubcategoryViewModel>? subcategories { get; set; }
        private List<UserResponseModel> userResponses = new();
        private ClaimsPrincipal? currentUser;
        bool isAccess { get; set; } = true;
        private Dictionary<int, bool>? validate { get; set; } = new();

        public SegmentService(IViewModelService service, IAuthService authService, IUserResponseService userResponseService)
        {
            this.service = service;
            this.authService = authService;
            this.userResponseService = userResponseService;
        }
        public async Task<bool> IsOpenSegment(int catId, int segId)
        {
            categories = await service.GetAllCategoriesAndMeta();

            if (categories.Any())
            {
                category = (CategoryViewModel)categories.FirstOrDefault(c => c.Id == catId);
                segments = category.Segments.Where(s => s.CategoryId == catId).ToList();
                subcategories = category.Segments.SelectMany(s => s.Subcategories).ToList();

            }

            //Medhis logik från Homepage
            currentUser = await authService.GetCurrentUserDataAsync();
            if (currentUser.Identity.IsAuthenticated)
            {
                var userId = currentUser.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (userId != null)
                {
                    userResponses = await userResponseService.GetUserResponsesAsync(userId);
                }
            }


            foreach (SegmentViewModel seg in segments)
            {
                int Comp = CalculateSegmentCompletion(seg);
                if (Comp == 100) { isAccess = true; validate.Add(seg.Id, true); }
                else if (isAccess) { isAccess = false; validate.Add(seg.Id, true); }
                else if (!isAccess) { isAccess = false; validate.Add(seg.Id, false); }

            }


            try
            {
                isAccess = validate[segId];
                return isAccess;
            }
            catch
            {
                return false;
            }
        }


        //Medhis logik från homepage
        private int CalculateSegmentCompletion(SegmentViewModel segment)
        {
            int precentage = userResponseService.CalculateSegmentCompletionBasedOnUser(segment, userResponses);

            return precentage;
        }

    }
}
