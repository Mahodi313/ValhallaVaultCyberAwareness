using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.DAL.DbModels
{
    public class SubcategoryModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Info { get; set; } = null!;
        public int SegmentId { get; set; }
        public SegmentModel Segment { get; set; }
        public List<QuestionModel> Questions { get; set; } = new();
    }
}
