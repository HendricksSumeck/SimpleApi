using SimpleApi.Infra.Data.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfraDataConfiguration();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();