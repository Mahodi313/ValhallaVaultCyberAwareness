using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.DAL.DbModels
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Info { get; set; }
        public List<SegmentModel> Segments { get; set; } = new();
    }
}
