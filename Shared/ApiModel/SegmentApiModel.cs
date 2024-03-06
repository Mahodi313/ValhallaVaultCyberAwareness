namespace ValhallaVaultCyberAwareness.DAL.ApiModels
{
    public class SegmentApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public CategoryApiModel Category { get; set; } = null!;
        public List<SubcategoryApiModel> Subcategorys { get; set; } = new();
    }
}
