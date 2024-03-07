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



        IRepository<AnswerModel> IUow.AnswerRepo => _answerRepo;

        IRepository<CategoryModel> IUow.CategoryRepo => _categoryRepo;

        IRepository<QuestionModel> IUow.QuestionRepo => _questionRepo;

        IRepository<SegmentModel> IUow.SegmentRepo => _segmentRepo;

        IRepository<SubcategoryModel> IUow.SubcategoryRepo => _subcategoryRepo;

        IRepository<UserResponseModel> IUow.UserResponseRepo => _userResponseRepo;
        public IRepository<ApplicationUser> UserRepo => _userRepo;


        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }


    }
}
