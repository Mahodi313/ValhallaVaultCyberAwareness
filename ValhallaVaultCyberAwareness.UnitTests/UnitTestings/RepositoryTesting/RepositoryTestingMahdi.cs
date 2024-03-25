using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ValhallaVaultCyberAwareness.Components.Pages;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.UnitTests.UnitTestings.RepositoryTesting
{
    public class RepositoryTestingMahdi
    {

        #region UpdateTestings

        [Fact]
        public async Task TestUpdateCategory()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestUpdateCategoryModel")
                .Options;

            using var context = new ApplicationDbContext(options);

            var category = new CategoryModel { Id = 1, Name = "InitialCategory", Info = "InitialInfo" };
            context.Categories.Add(category);
            await context.SaveChangesAsync();

            var repo = new Repository<CategoryModel>(context);

            var updatedCategory = new CategoryModel { Id = 1, Name = "UpdatedCategory", Info = "UpdatedInfo" };

            await repo.UpdateAsync(updatedCategory);

            var result = await context.Categories.FindAsync(1);
            Assert.Equal("UpdatedCategory", result.Name);
            Assert.Equal("UpdatedInfo", result.Info);
        }

        [Fact]
        public async Task TestUpdateSegment()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestUpdateSegmentModel")
                .Options;

            using var context = new ApplicationDbContext(options);

            var segment = new SegmentModel { Id = 1, Name = "InitialSegment", Info = "InitialInfo" };
            context.Segments.Add(segment);
            await context.SaveChangesAsync();

            var repo = new Repository<SegmentModel>(context);

            var updatedSegment = new SegmentModel { Id = 1, Name = "UpdatedSegment", Info = "UpdatedInfo" };

            await repo.UpdateAsync(updatedSegment);

            var result = await context.Segments.FindAsync(1);
            Assert.Equal("UpdatedSegment", result.Name);
            Assert.Equal("UpdatedInfo", result.Info);
        }

        [Fact]
        public async Task TestUpdateSubCategory()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestUpdateSubCategoryModel")
                .Options;

            using var context = new ApplicationDbContext(options);

            var subCategory = new SubcategoryModel { Id = 1, Name = "InitialSubCategory", Info = "InitialInfo", SegmentId = 1 };
            context.Subcategories.Add(subCategory);
            await context.SaveChangesAsync();

            var repo = new Repository<SubcategoryModel>(context);

            var updatedSubCategory = new SubcategoryModel { Id = 1, Name = "UpdatedSubCategory", Info = "UpdatedInfo", SegmentId = 1 };

            await repo.UpdateAsync(updatedSubCategory);

            var result = await context.Subcategories.FindAsync(1);
            Assert.Equal("UpdatedSubCategory", result.Name);
            Assert.Equal("UpdatedInfo", result.Info);
        }

        [Fact]
        public async Task TestUpdateQuestion()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestUpdateQuestionModel")
                .Options;

            using var context = new ApplicationDbContext(options);

            var question = new QuestionModel { Id = 1, Title = "InitialQuestion", SubcategoryId = 1 };
            context.Questions.Add(question);
            await context.SaveChangesAsync();

            var repo = new Repository<QuestionModel>(context);

            var updatedQuestion = new QuestionModel { Id = 1, Title = "UpdatedQuestion", SubcategoryId = 1 };

            await repo.UpdateAsync(updatedQuestion);

            var result = await context.Questions.FindAsync(1);
            Assert.Equal("UpdatedQuestion", result.Title);
            Assert.Equal(1, result.SubcategoryId);
        }

        [Fact]
        public async Task TestUpdateAnswer()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestUpdateAnswerModel")
                .Options;

            using var context = new ApplicationDbContext(options);

            var answer = new AnswerModel { Id = 1, Answer = "InitialAnswer", IsCorrectAnswer = false, Explanation = "No", QuestionId = 1 };
            context.Answers.Add(answer);
            await context.SaveChangesAsync();

            var repo = new Repository<AnswerModel>(context);

            var updatedAnswer = new AnswerModel { Id = 1, Answer = "UpdatedAnswer", IsCorrectAnswer = true, Explanation = "Yes", QuestionId = 1 };

            await repo.UpdateAsync(updatedAnswer);

            var result = await context.Answers.FindAsync(1);
            Assert.Equal("UpdatedAnswer", result.Answer);
            Assert.True(result.IsCorrectAnswer);
            Assert.Equal("Yes", result.Explanation);
            Assert.Equal(1, result.QuestionId);
        }



        #endregion




    }
}
