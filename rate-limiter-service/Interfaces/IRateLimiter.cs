namespace rate_limiter_service.Interfaces
{
    public interface IRateLimiter
    {
        Task<bool> AllowRequestAsync(string clientId);
    }
}
