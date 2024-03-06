using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository.Interfaces;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.DAL.Repository
{
    /// <summary>
    /// Repository for handling the data access logic for <see cref="AnswerModel"/> entities.
    /// </summary>
    public class AnswerRepository : IAnswerRepository
    {
        private readonly ApplicationDbContext _context;
        public AnswerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Asynchronously creates a new answer entity in the database.
        /// </summary>
        /// <param name="entity">The answer model to create.</param>
        /// <returns>The newly created as a <see cref="AnswerModel"/> object.</returns>
        public async Task<AnswerModel> CreateAsync(AnswerModel entity)
        {
            _context.Answers.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Asynchronously deletes an answer entity identified by its ID.
        /// </summary>
        /// <param name="id">The ID of the answer to delete.</param>
        /// <exception cref="InvalidOperationException">Thrown if the answer cannot be found.</exception>
        public async Task DeleteAsync(int id)
        {
            var answer = await GetByIdAsync(id);
            if (answer != null)
            {
                //_context.Answers.RemoveAsync(answer);
                _context.Answers.Remove(answer);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Answer not found");
            }
        }

        /// <summary>
        /// Asynchronously retrieves all answer entities from the database.
        /// </summary>
        /// <returns>A list of all <see cref="AnswerModel"/> entities.</returns>
        public async Task<IEnumerable<AnswerModel>> GetAllAsync()
        {
            return await _context.Answers.ToListAsync();
        }

        /// <summary>
        /// Asynchronously retrieves an answer entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the answer to retrieve.</param>
        /// <returns>The answer entity if found; otherwise, null.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the answer cannot be found.</exception>
        public async Task<AnswerModel> GetByIdAsync(int id)
        {
            var answer = await _context.Answers.FindAsync(id);
            if (answer == null)
            {
                throw new InvalidOperationException("Answer not found");
            }
            return answer;
        }

        /// <summary>
        /// Asynchronously retrieves all answer entities for a specified question ID.
        /// </summary>
        /// <param name="questionId">The ID of the question.</param>
        /// <returns>A list of answer entities associated with the question ID.</returns>
        public async Task<IEnumerable<AnswerModel>> GetByQuestionIdAsync(int questionId)
        {
            return await _context.Answers.Where(a => a.QuestionId == questionId).ToListAsync();
        }

        /// <summary>
        /// Asynchronously retrieves all correct answer entities for a specified question ID.
        /// </summary>
        /// <param name="questionId">The ID of the question.</param>
        /// <returns>A list of correct answer entities associated with the question ID.</returns>
        public async Task<IEnumerable<AnswerModel>> GetCorrectAnswersByQuestionIdAsync(int questionId)
        {
            return await _context.Answers.Where(a => a.QuestionId == questionId && a.IsCorrectAnswer).ToListAsync();
        }

        /// <summary>
        /// Asynchronously updates an existing answer entity in the database with the provided answer details.
        /// </summary>
        /// <param name="entity">The answer model with updated information.</param>
        /// <exception cref="InvalidOperationException">Thrown if the answer to update is not found.</exception>
        public async Task UpdateAsync(AnswerModel entity)
        {
            var answer = await _context.Answers.FindAsync(entity.Id);
            if (answer == null)
            {
                throw new InvalidOperationException("Answer not found");
            }

            answer.Answer = entity.Answer;
            answer.IsCorrectAnswer = entity.IsCorrectAnswer;
            answer.Explanation = entity.Explanation;

            // Markerar entiteten som "Modified" vilket informerar databaskontexten att entiteten har ändrats.
            _context.Entry(answer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
