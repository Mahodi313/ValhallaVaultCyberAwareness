using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.DAL.Uow
{
    public class Uow : IUow
    {
        private readonly ApplicationDbContext _context;

        public Uow(ApplicationDbContext context)
        {
            _context = context;
            AnswerRepo = new Repository<AnswerModel>(context);
            CategoryRepo = new Repository<CategoryModel>(context);
            QuestionRepo = new Repository<QuestionModel>(context);
            SegmentRepo = new Repository<SegmentModel>(context);
            SubcategoryRepo = new Repository<SubcategoryModel>(context);
            UserResponseRepo = new Repository<UserResponseModel>(context);
        }

        public IRepository<AnswerModel> AnswerRepo => throw new NotImplementedException();

        public IRepository<CategoryModel> CategoryRepo => throw new NotImplementedException();

        public IRepository<QuestionModel> QuestionRepo => throw new NotImplementedException();

        public IRepository<SegmentModel> SegmentRepo => throw new NotImplementedException();

        public IRepository<SubcategoryModel> SubcategoryRepo => throw new NotImplementedException();

        public IRepository<UserResponseModel> UserResponseRepo => throw new NotImplementedException();



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
