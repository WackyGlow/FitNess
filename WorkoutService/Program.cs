using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkoutService.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
string cloudAMQPConnectionString =
    "amqps://cmcbjlme:aF-QmhuXS-dFiVX8SMUDzYLk0v9dGO8i@hawk.rmq.cloudamqp.com/cmcbjlme";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

Task.Factory.StartNew(() => new MessageListener(app.Services, cloudAMQPConnectionString).start());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();