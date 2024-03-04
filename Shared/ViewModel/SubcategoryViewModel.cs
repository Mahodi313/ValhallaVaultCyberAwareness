namespace Shared.ViewModel
{
    public class SubcategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SegmentId { get; set; }
        public SegmentViewModel Segment { get; set; }
        public List<QuestionViewModel> Questions { get; set; } = new();
    }
}
