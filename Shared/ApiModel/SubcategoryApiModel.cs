namespace ValhallaVaultCyberAwareness.DAL.ApiModels
{
    public class SubcategoryApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SegmentId { get; set; }
        public List<QuestionApiModel> Questions { get; set; } = new();
    }
}
