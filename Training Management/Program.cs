using Microsoft.EntityFrameworkCore;
using TrainingManagement.Common.Repositories;
using TrainingManagement.Common.Services;
using TrainingManagement.DAO.DB;
using TrainingManagement.DAO.Repositories;
using TrainingManagement.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IAccountSrevice, AccountService>();
builder.Services.AddTransient<IAccountRepository, AccountRepository>();


builder.Services.AddDbContext<Training_DBContext>(options =>
options.UseSqlServer(builder.Configuration.GetValue<string>("ConnectionStrings:DefaultConnections"))
);
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

namespace Training_Management
{
    class Training_DBContext
    {
    }
}