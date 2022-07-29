using SimpleApi.Application.Interfaces;
using SimpleApi.Application.Services;
using SimpleApi.Domain.Interfaces;
using SimpleApi.Infra.Data.Configurations;
using SimpleApi.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddInfraDataConfiguration();

builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddTransient<IBookService, BookService>();

var app = builder.Build();

//TODO - Refatorar e enteder isto 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();