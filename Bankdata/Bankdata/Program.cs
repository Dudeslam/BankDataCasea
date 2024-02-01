using Bankdata.BusinessLogicBanking;
using Bankdata.Models;
using Bankdata.Repository;
using System.Transactions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccountRepository<Account>, AccountRepo<Account>>();
builder.Services.AddScoped<ITransactionRepository<Transactions>, TransactionRepo<Transactions>>();
builder.Services.AddScoped<IAccountBL, AccountBL>();
builder.Services.AddScoped<ITransactionBL, TransactionBL>();
builder.Services.AddHttpContextAccessor();




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
