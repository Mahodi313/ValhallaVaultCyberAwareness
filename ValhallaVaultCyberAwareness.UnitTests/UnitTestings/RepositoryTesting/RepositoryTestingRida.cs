using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.UnitTests.UnitTestings.RepositoryTesting
{
    public class RepositoryTestingRida
    {
        // Rida
        private readonly DbContextOptions<ApplicationDbContext> _options;

        public RepositoryTestingRida()
        {
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
        }

        #region Testing DeleteAsync(int id)

        [Fact]
        public async Task DeleteAsync_RemovesQuestion_SuccessfullyRemoved()
        {
            // Arrange
            using var context = new ApplicationDbContext(_options);

            var newQuestion = new QuestionModel()
            {
                Id = 1,
                Title = "This is a question?",
                //public string Title { get; set; } = null!;
                //public int SubcategoryId { get; set; }
                //public SubcategoryModel Subcategory { get; set; } = null!;
                //public List<AnswerModel> Answers { get; set; } = new();
                //public List<UserResponseModel> UserResponse { get; set; } = new();
            };

            await context.Questions.AddAsync(newQuestion);
            await context.SaveChangesAsync();

            var repo = new Repository<QuestionModel>(context);
            var questionId = newQuestion.Id;

            // Act
            await repo.DeleteAsync(newQuestion.Id);
            var entityInDb = await context.Questions.FindAsync(questionId);

            // Assert
            Assert.Null(entityInDb);
        }

        #endregion

        #region Testing GetByIdAsync(int id)

        [Fact]
        public async Task GetByIdAsync_FindCategoryId_SuccessfullyFound()
        {
            // Arrange
            using var context = new ApplicationDbContext(_options);

            var newCategory = new CategoryModel()
            {
                Id = 1,
                Name = "Category 1",
                Info = "This is information about Category 1."
            };

            await context.Categories.AddAsync(newCategory);
            await context.SaveChangesAsync();

            var repo = new Repository<CategoryModel>(context);

            // Act
            var result = await repo.GetByIdAsync(newCategory.Id);

            // Assert
            Assert.Equal(newCategory, result);
        }

        #endregion
    }
}
