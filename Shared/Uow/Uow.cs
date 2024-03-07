using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.DAL.Uow
{
    public class Uow : IUow
    {
        private readonly ApplicationDbContext _context;
        private IRepository<AnswerModel> _answerRepo;
        private IRepository<CategoryModel> _categoryRepo;
        private IRepository<QuestionModel> _questionRepo;
        private IRepository<SegmentModel> _segmentRepo;
        private IRepository<SubcategoryModel> _subcategoryRepo;
        private IRepository<UserResponseModel> _userResponseRepo;
        private IRepository<ApplicationUser> _userRepo;

        public Uow(ApplicationDbContext context)
        {
            _context = context;
            _answerRepo = new Repository<AnswerModel>(context);
            _categoryRepo = new Repository<CategoryModel>(context);
            _questionRepo = new Repository<QuestionModel>(context);
            _segmentRepo = new Repository<SegmentModel>(context);
            _subcategoryRepo = new Repository<SubcategoryModel>(context);
            _userResponseRepo = new Repository<UserResponseModel>(context);
            _userRepo = new Repository<ApplicationUser>(context);
        }



        IRepository<AnswerModel> IUow.AnswerRepo { get; }

        IRepository<CategoryModel> IUow.CategoryRepo { get; }

        IRepository<QuestionModel> IUow.QuestionRepo { get; }

        IRepository<SegmentModel> IUow.SegmentRepo { get; }

        IRepository<SubcategoryModel> IUow.SubcategoryRepo { get; }

        IRepository<UserResponseModel> IUow.UserResponseRepo { get; }
        public IRepository<ApplicationUser> UserRepo { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
