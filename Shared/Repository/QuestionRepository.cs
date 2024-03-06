using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository.Interfaces;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.DAL.Repository
{
    /// <summary>
    /// Repository for handling the data access logic for <see cref="QuestionModel"/> entities.
    /// </summary>
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext _context;
        public QuestionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Asynchronously creates a new question entity in the database.
        /// </summary>
        /// <param name="entity">The question model to be created.</param>
        /// <returns>The newly created question as a <see cref="QuestionModel"/> object.</returns>
        public async Task<QuestionModel> CreateAsync(QuestionModel entity)
        {
            _context.Questions.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Asynchronously deletes a question entity identified by its ID.
        /// </summary>
        /// <param name="id">The ID of the question to deleted.</param>
        /// <exception cref="InvalidOperationException">Thrown if the question is not found.</exception>
        public async Task DeleteAsync(int id)
        {
            var question = await GetByIdAsync(id);
            if (question != null)
            {
                _context.Questions.Remove(question);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Question not found");
            }
        }

        /// <summary>
        /// Asynchronously retrieves all question entities from the database.
        /// </summary>
        /// <returns>A list of all <see cref="QuestionModel"/> objects.</returns>
        public async Task<IEnumerable<QuestionModel>> GetAllAsync()
        {
            return await _context.Questions.ToListAsync();
        }

        /// <summary>
        /// Asynchronously retrieves a question entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the question to retrieve.</param>
        /// <returns>The question entity corresponding to the specified ID.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the question cannot be found.</exception>
        public async Task<IEnumerable<AnswerModel>> GetAnswerForQuestionAsync(int questionId)
        {
            return await _context.Answers.Where(a => a.QuestionId == questionId).ToListAsync();
        }

        /// <summary>
        /// Asynchronously updates an existing question in the database.
        /// </summary>
        /// <param name="entity">The question model containing the updated values.</param>
        /// <exception cref="InvalidOperationException">Thrown if the given question is not found.</exception>
        public async Task<QuestionModel> GetByIdAsync(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                throw new InvalidOperationException("Question not found");
            }
            return question;
        }

        /// <summary>
        /// Asynchronously retrieves all questions entities for a specified subcategory ID.
        /// </summary>
        /// <param name="subcategoryId">The ID of the subcategory for which questions are to be retrieved.</param>
        /// <returns>A list of <see cref="QuestionModel"/> objects that belong to the specified subcategory.</returns>
        public async Task<IEnumerable<QuestionModel>> GetQuestionsBySubcategoryAsync(int subcategoryId)
        {
            return await _context.Questions.Where(q => q.SubcategoryId == subcategoryId).ToListAsync();
        }

        /// <summary>
        /// Asynchronously retrieves user responses for a specific question.
        /// </summary>
        /// <param name="questionId">The ID of the question for which user responses are to be retrieved.</param>
        /// <returns>A list of <see cref="UserResponseModel"/> objects associated with the specified question.</returns>
        public async Task<IEnumerable<UserResponseModel>> GetUserResponsesForQuestionAsync(int questionId)
        {
            return await _context.UserResponses.Where(ur => ur.QuestionId == questionId).ToListAsync();
        }

        /// <summary>
        /// Asynchronously updates an existing question in the database with the provided question details.
        /// </summary>
        /// <param name="entity">The question model containing the updated information for the question.</param>
        /// <exception cref="InvalidOperationException">Thrown if the question to be updated is not found.</exception>
        public async Task UpdateAsync(QuestionModel entity)
        {
            var question = await _context.Questions.FindAsync(entity.Id);
            if (question == null)
            {
                throw new InvalidOperationException("Question not found");
            }

            question.Title = entity.Title;
            question.SubcategoryId = entity.SubcategoryId;

            // Markerar entiteten som "Modified" vilket informerar databaskontexten att entiteten har ändrats.
            _context.Entry(question).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
