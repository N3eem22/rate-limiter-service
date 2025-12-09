namespace rate_limiter_service.Models
{
    public class RateLimiterRequest
    {
        public string Key { get; set; }
        public string Strategy { get; set; }
        public Dictionary<string, int> Config { get; set; }
    }
}
