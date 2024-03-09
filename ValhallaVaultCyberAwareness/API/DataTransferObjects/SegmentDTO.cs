namespace ValhallaVaultCyberAwareness.API.DataTransferObjects
{
    public class SegmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Info { get; set; }
        public int CategoryId { get; set; }
    }
}
