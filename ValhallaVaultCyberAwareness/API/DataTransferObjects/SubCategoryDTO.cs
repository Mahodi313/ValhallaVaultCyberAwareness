﻿namespace ValhallaVaultCyberAwareness.API.DataTransferObjects
{
    public class SubCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Info { get; set; }
        public int SegmentId { get; set; }
    }
}
