namespace Shared.ViewModel
{
    public class SegmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }
        public List<SubcategoryViewModel> Subcategories { get; set; } = new();
    }
}
