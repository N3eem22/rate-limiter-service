using rate_limiter_service.Interfaces;

namespace rate_limiter_service.RateLimiters
{
    public class TokenBucketRateLimiter : IRateLimiter
    {
        public Task<bool> AllowRequestAsync(string clientId)
        {
            throw new NotImplementedException();
        }
    }
}
