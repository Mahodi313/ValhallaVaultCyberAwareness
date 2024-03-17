namespace ValhallaVaultCyberAwareness.App.PageHandler
{

    //Static props to help the navbar component navigate
    public static class PageHandler
    {
        public static int? CategoryId { get; set; }
        public static bool firstCategory { get; set; }
        public static int? SegmentId { get; set; }
        public static int? SubcategoryId { get; set; }
        public static int? SubcategoryIdHolder { get; set; }
        public static bool WentToSubcategory { get; set; }

    }
}
