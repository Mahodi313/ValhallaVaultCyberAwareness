namespace ValhallaVaultCyberAwareness.API.DataTransferObjects
{
    public class SegmentPostDTO
    {
        public string Name { get; set; } = null!;
        public string? Info { get; set; }
        public int CategoryId { get; set; }
    }
}
