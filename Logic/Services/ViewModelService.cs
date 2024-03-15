using ValhallaVaultCyberAwareness.DAL.Uow;
using ValhallaVaultCyberAwareness.DAL.ViewModel;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public class ViewModelService : IViewModelService
    {
        private readonly IUow uow;

        public ViewModelService(IUow uow)
        {
            this.uow = uow;
        }
        public async Task<List<CategoryViewModel>> GetAllCategoriesAndMeta()
        {
            var Cate = await uow.CategoryRepo.GetAllAsync(c => c.Segments);
            var Sub = await uow.SubcategoryRepo.GetAllAsync();
            var Ques = await uow.QuestionRepo.GetAllAsync(q => q.Answers, q => q.UserResponse);

            if (Cate.Any())
            {
                //Turn Dbmodel to Viewmodel<
                var ViewCategoriesToReturn = Cate.Select(q => new CategoryViewModel
                {
                    Id = q.Id,
                    Name = q.Name,
                    Info = q.Info,
                    Segments = q.Segments.Select(s => new SegmentViewModel
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Info = s.Info,
                        CategoryId = s.CategoryId,
                        Subcategories = s.Subcategorys.Where(su => su.Segment.Id == s.Id).Select(sc => new SubcategoryViewModel
                        {
                            Id = sc.Id,
                            Name = sc.Name,
                            SegmentId = sc.SegmentId,
                            Questions = Ques.Where(q => q.SubcategoryId == sc.Id).Select(q => new QuestionViewModel
                            {
                                Title = q.Title,
                                SubcategoryId = q.SubcategoryId,
                                Answers = q.Answers.Select(a => new AnswerViewModel
                                {
                                    Id = a.Id,
                                    Answer = a.Answer,
                                    IsCorrectAnswer = a.IsCorrectAnswer,
                                    Explanation = a.Explanation,
                                    QuestionId = a.QuestionId
                                }).ToList(),

                            }).ToList()
                        }).ToList()
                    }).ToList()

                }).ToList();

                return ViewCategoriesToReturn;

            }
            else
            {
                return null;
            }

        }
    }

}
