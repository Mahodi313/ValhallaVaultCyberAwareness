namespace ValhallaVaultCyberAwareness.DAL.ApiModels
{
    public class CategoryApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<SegmentApiModel> Segments { get; set; } = new();
    }
}
