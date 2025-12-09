namespace rate_limiter_service.Enums
{
    public enum RateLimiterStrategy
    {
        TokenBucket,
        SlidingWindow,
        FixedWindow,
        LeakyBucket
    }
}
