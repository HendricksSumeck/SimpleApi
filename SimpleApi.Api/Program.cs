using SimpleApi.Infra.Data.Configurations;
using SimpleApi.Infra.IoC.Configurations;
using SimpleApi.Infra.IoC.Injectors;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

//Add Auto Mapper Config
builder.Services.AddAutoMapperConfig();

// Add Infra Data Config
builder.Services.AddInfraDataConfig();

// Add IoC Services
builder.Services.AddServices();
builder.Services.AddRepositorys();

var app = builder.Build();

//TODO - Refactor and understand it 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();