namespace ValhallaVaultCyberAwareness.App.Services
{
    public interface ISegmentService
    {
        public Task<bool> IsOpenSegment(int catId, int segId);
    }
}
