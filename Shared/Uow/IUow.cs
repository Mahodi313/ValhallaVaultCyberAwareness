using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;

namespace ValhallaVaultCyberAwareness.DAL.Uow
{
    public interface IUow : IDisposable
    {
        public IRepository<AnswerModel> AnswerRepo { get; }
        public IRepository<CategoryModel> CategoryRepo { get; }
        public IRepository<QuestionModel> QuestionRepo { get; }
        public IRepository<SegmentModel> SegmentRepo { get; }
        public IRepository<SubcategoryModel> SubcategoryRepo { get; }
        public IRepository<UserResponseModel> UserResponseRepo { get; }
        public IRepository<ApplicationUser> UserRepo { get; }
        Task SaveChanges();
    }

}
