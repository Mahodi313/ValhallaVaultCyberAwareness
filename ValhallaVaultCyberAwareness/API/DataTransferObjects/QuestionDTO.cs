﻿namespace ValhallaVaultCyberAwareness.API.DataTransferObjects
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int SubcategoryId { get; set; }
    }
}
