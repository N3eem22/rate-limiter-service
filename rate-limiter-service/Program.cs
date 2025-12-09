using rate_limiter_service.Factories;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var redisConfig = builder.Configuration.GetSection("Redis");
var redisConnectionString = redisConfig["ConnectionString"];

builder.Services.AddSingleton(new RedisConnectionFactory(redisConnectionString));
builder.Services.AddSingleton<IConnectionMultiplexer>(option =>
{
    return option.GetRequiredService<RedisConnectionFactory>().GetConnection();
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
