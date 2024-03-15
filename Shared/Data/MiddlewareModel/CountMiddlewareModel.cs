using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.DAL.Data.MiddlewareModel
{
    public class CountMiddlewareModel
    {
        [Key]
        public int CountId { get; set; }
        public int Count { get; set; }
        public string Type { get; set; } = null!;
    }
}
