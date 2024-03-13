﻿using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.DAL.DbModels
{
    public class SegmentModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Info { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; } = null!;
        public List<SubcategoryModel> Subcategorys { get; set; } = new();
    }
}
