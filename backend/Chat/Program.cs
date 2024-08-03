using Chat.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddStackExchangeRedisCache(optons =>
{
    var connection = builder.Configuration.GetConnectionString("Redis");
    optons.Configuration = connection;
});

builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

builder.Services.AddSignalR();

var app = builder.Build();

app.UseCors();

app.MapHub<ChatHub>("/chat");

app.Run();