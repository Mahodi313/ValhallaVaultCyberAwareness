using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.DAL.Uow;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.UnitTests.UnitTestings.RepositoryTesting
{
    public class RepoTestEmma
    {
        private readonly ApplicationDbContext context;
        private readonly IUow uow;

        public RepoTestEmma()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ValhallaDb;Trusted_Connection=True;");

            context = new ApplicationDbContext(optionsBuilder.Options);

            uow = new Uow(context);
        }


        [Theory]
        [InlineData(3, 1, 3, "Del 1")]
        [InlineData(3, 2, 4, "Del 1")]
        public async Task TestGetAllAsyncOverloaded(int expectedCategoryCount, int categoryId, int expectedSegmentCount, string expectedSegmentName)
        {
            //Det finns 3 kategorier seedade i databasen
            //Den första kategorin har 3 segment
            //Den andra kategorin har 4 segment

            var categories = await uow.CategoryRepo.GetAllAsync(e => e.Segments);
            Assert.NotNull(categories);
            Assert.Equal(expectedCategoryCount, categories.Count);

            var category = categories.FirstOrDefault(c => c.Id == categoryId);
            var segmentsInCategory1 = category.Segments;
            Assert.NotEmpty(segmentsInCategory1);
            Assert.Equal(expectedSegmentCount, segmentsInCategory1.Count);

            var firstSegment = category.Segments[0].Name;
            Assert.Equal(expectedSegmentName, firstSegment);

        }


        [Theory]
        [InlineData(1, 1, 3, false)]
        [InlineData(1, 2, 3, false)]
        [InlineData(1, 3, 3, true)]
        public async Task TestGetAnswersByQuestionIdAsync(int qustionId, int AnswerId, int expectedAnswerCount, bool expectedBool)
        {
            //Fråga med id 1 har tre svar i den seedade datan
            //Det första svaret är fel svar

            var resultAnswers = await uow.QuestionRepo.GetAnswersByQuestionIdAsync(qustionId);

            Assert.NotEmpty(resultAnswers);
            Assert.Equal(expectedAnswerCount, resultAnswers.Count);

            var answer = resultAnswers.FirstOrDefault(a => a.Id == AnswerId);
            var isAnswerCorrect = answer.IsCorrectAnswer;
            Assert.Equal(expectedBool, isAnswerCorrect);

        }
    }
}
