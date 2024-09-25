using Kleo_Finaces.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Adding services with its implementation.

builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IBudget, Budget>();
builder.Services.AddScoped<ISource, Source>();
builder.Services.AddScoped<IIncome, Income>();
builder.Services.AddScoped<IOutcome, Outcome>();
builder.Services.AddScoped<ITransfer, Transfer>();
builder.Services.AddScoped<IIncomeCategory, IncomeCategory>();
builder.Services.AddScoped<IOutcomeCategory, OutcomeCategory>();
builder.Services.AddScoped<IUser, User>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
