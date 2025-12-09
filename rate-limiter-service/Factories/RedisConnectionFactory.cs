using StackExchange.Redis;

namespace rate_limiter_service.Factories

{
    public class RedisConnectionFactory(string connectionString)
    {
        private readonly Lazy<ConnectionMultiplexer> _connection = new Lazy<ConnectionMultiplexer>(() =>
                                                                               ConnectionMultiplexer.Connect(connectionString));
        public ConnectionMultiplexer GetConnection() => _connection.Value;
    }
}
