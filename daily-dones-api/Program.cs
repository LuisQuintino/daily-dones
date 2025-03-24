using api_domain.Config;
using api_domain.Repositories;
using api_domain.Services;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BdContext>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();


var app = builder.Build();

var config = new ConfigurationBuilder()
		.AddJsonFile($"appsettings.Development.json", optional: false)
		.AddEnvironmentVariables()
		.Build();


// Configure the HTTP request pipeline.d
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

