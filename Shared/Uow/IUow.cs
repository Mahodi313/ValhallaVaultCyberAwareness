using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.DAL.Uow
{
    public interface IUow : IDisposable
    {
        IRepository<AnswerModel> AnswerRepo { get; }
        IRepository<CategoryModel> CategoryRepo { get; }
        IRepository<QuestionModel> QuestionRepo { get; }
        IRepository<SegmentModel> SegmentRepo { get; }
        IRepository<SubcategoryModel> SubcategoryRepo { get; }
        IRepository<UserResponseModel> UserResponseRepo { get; }
        void SaveChanges();
    }
    {

    }
}
