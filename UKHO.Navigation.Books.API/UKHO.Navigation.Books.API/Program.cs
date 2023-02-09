using FluentValidation;
using UKHO.Navigation.Books.API.Data;
using UKHO.Navigation.Books.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<IBookService, BookService>();

builder.Services.AddValidatorsFromAssemblyContaining<Program>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IDbConnectionFactory>
(_ => new SqlLiteDbConnectionFactory(
    builder.Configuration.GetValue<string>("Database:ConnectionString")));
builder.Services.AddSingleton<DatabaseInitializer>();

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

var dataBaseInit = app.Services.GetRequiredService<DatabaseInitializer>();
await dataBaseInit.InitializeAsync();

app.Run();
