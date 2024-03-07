using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        /// <summary>
        /// Asynchronously creates a new <see cref="T"/> entity in the database.
        /// </summary>
        /// <param name="entity">The <see cref="T"/> to be created.</param>
        /// <returns>The newly created question as a <see cref="T"/> object.</returns>
        public async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Asynchronously deletes a <see cref="T"/> entity identified by its ID.
        /// </summary>
        /// <param name="id">The ID of the <see cref="T"/> entity to deleted.</param>
        /// <exception cref="InvalidOperationException">Thrown if the <see cref="T"/> is not found.</exception>
        public async Task<T> DeleteAsync(int id)
        {
            var entityToDelete = await GetByIdAsync(id);
            if (entityToDelete == null)
            {
                throw new InvalidOperationException("Entity not found");
            }
            _dbSet.Remove(entityToDelete);
            await _context.SaveChangesAsync();
            return entityToDelete;
        }

        /// <summary>
        /// Asynchronously retrieves all <see cref="T"/> entities from the database.
        /// </summary>
        /// <returns>A list of all <see cref="T"/> objects.</returns>
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        /// <summary>
        /// Asynchronously updates an existing <see cref="T"/> entity in the database.
        /// </summary>
        /// <param name="entity">The <see cref="T"/> entity containing the updated values.</param>
        /// <exception cref="InvalidOperationException">Thrown if the given <see cref="T"/> entity is not found.</exception>
        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                throw new InvalidOperationException("Entity not found");
            }
            return entity;
        }

        /// <summary>
        /// Asynchronously updates an existing <see cref="T"/> entity in the database with the provided question details.
        /// </summary>
        /// <param name="entity">The <see cref="T"/> entity containing the updated information for the <see cref="T"/>.</param>
        /// <exception cref="InvalidOperationException">Thrown if the <see cref="T"/> entity to be updated is not found.</exception>
        public async Task UpdateAsync(T entity)
        {
            // Hitta ID-propertyn på objektet med reflection
            var properties = entity.GetType().GetProperties();
            var id = properties.FirstOrDefault(p => p.Name == "Id")!.GetValue(entity);

            var entityToUpdate = await _dbSet.FindAsync(id);

            if (entityToUpdate == null)
            {
                throw new InvalidOperationException($"{entity.GetType()} not found");
            }
            else
            {
                foreach (var property in properties)
                {
                    if (property.Name != "Id" && (property.PropertyType.IsValueType ||
                         property.PropertyType == typeof(string) ||
                         property.PropertyType == typeof(DateTime)))
                    {
                        var value = property.GetValue(entity);

                        entityToUpdate.GetType().GetProperties()
                            .FirstOrDefault(p => p.Name == property.Name)!
                            .SetValue(entityToUpdate, value);
                    }
                }

                // Markerar entiteten som "Modified" vilket informerar databaskontexten att entiteten har ändrats.
                _context.Entry(entityToUpdate).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }





        /// <summary>
        /// Asynchronously retrieves a question entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the question to retrieve.</param>
        /// <returns>The question entity corresponding to the specified ID.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the question cannot be found.</exception>
        public async Task<List<AnswerModel>> GetAnswerForQuestionAsync(int questionId)
        {
            try
            {
                return await _context.Answers.Where(a => a.QuestionId == questionId).Include(a => a.Question).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<AnswerModel>();
            }
        }

        /// <summary>
        /// Asynchronously retrieves all questions entities for a specified subcategory ID.
        /// </summary>
        /// <param name="subcategoryId">The ID of the subcategory for which questions are to be retrieved.</param>
        /// <returns>A list of <see cref="QuestionModel"/> objects that belong to the specified subcategory.</returns>
        public async Task<List<QuestionModel>> GetQuestionsBySubcategoryAsync(int subcategoryId)
        {
            return await _context.Questions.Where(q => q.SubcategoryId == subcategoryId).ToListAsync();
        }

        /// <summary>
        /// Asynchronously retrieves user responses for a specific question.
        /// </summary>
        /// <param name="questionId">The ID of the question for which user responses are to be retrieved.</param>
        /// <returns>A list of <see cref="UserResponseModel"/> objects associated with the specified question.</returns>
        public async Task<List<UserResponseModel>> GetUserResponsesForQuestionAsync(int questionId)
        {
            return await _context.UserResponses.Where(ur => ur.QuestionId == questionId).ToListAsync();
        }




        /// <summary>
        /// Asynchronously retrieves all answer entities for a specified question ID.
        /// </summary>
        /// <param name="questionId">The ID of the question.</param>
        /// <returns>A list of answer entities associated with the question ID.</returns>
        public async Task<List<AnswerModel>> GetByQuestionIdAsync(int questionId)
        {
            return await _context.Answers.Where(a => a.QuestionId == questionId).ToListAsync();
        }

        /// <summary>
        /// Asynchronously retrieves all correct answer entities for a specified question ID.
        /// </summary>
        /// <param name="questionId">The ID of the question.</param>
        /// <returns>A list of correct answer entities associated with the question ID.</returns>
        public async Task<List<AnswerModel>> GetCorrectAnswersByQuestionIdAsync(int questionId)
        {
            return await _context.Answers.Where(a => a.QuestionId == questionId && a.IsCorrectAnswer).ToListAsync();
        }



        // TODO: Implementera logik

        public Task<List<SubcategoryModel>> GetSubcategoryBySegmentAsync(int segmentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<QuestionModel>> GetQuestionForSubcategoryAsync(int subcategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserResponseModel>> GetResponsesOfUser(string userid)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryModel>> GetCategoryIncludeSegmentAsync()
        {

            return await _context.Categories.Include(c => c.Segments).ToListAsync();
        }

        public async Task<List<SubcategoryModel>> GetSubcategoriesBySegmentAsync(int segmentId)
        {
            return await _context.Subcategories
                .Where(sc => sc.SegmentId == segmentId)
                .ToListAsync();
        }
    }
}
