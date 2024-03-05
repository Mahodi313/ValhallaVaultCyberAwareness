using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels
{
    public class SegmentModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; } = null!;
        public List<SubcategoryModel> Subcategorys { get; set; } = new();
    }
}
