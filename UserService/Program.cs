using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UserService.Infrastructure;
using static UserService.Infrastructure.UserMessagePublisher;

var builder = WebApplication.CreateBuilder(args);

// The connection string for CloudAMQP
string cloudAMQPConnectionString =
   "amqps://cmcbjlme:aF-QmhuXS-dFiVX8SMUDzYLk0v9dGO8i@hawk.rmq.cloudamqp.com/cmcbjlme";

// Add services to the container.

// Add controllers
builder.Services.AddControllers();

// Add Swagger/OpenAPI support
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register MessagePublisher (a messaging gateway) for dependency injection
builder.Services.AddSingleton<IUserMessagePublisher>(new
    UserMessagePublisher(cloudAMQPConnectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
// Enable Swagger and SwaggerUI in development environment
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

// Enable HTTPS redirection
//app.UseHttpsRedirection();

// Enable authorization
app.UseAuthorization();

// Map the controllers
app.MapControllers();

// Start the application
app.Run();