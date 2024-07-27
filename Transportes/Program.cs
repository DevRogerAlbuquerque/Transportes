using AutoMapper;
using Cqrs.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using Transportes.Models.Dominio;
using Transportes.Repositorios;
using Transportes.Servicos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IServico, Servico>();
builder.Services.AddScoped<IRepositorio, RepositorioBase<IDbModel>>();
var connectionString = builder.Configuration.GetConnectionString("Transportes");
builder.Services.AddTransient<QueryFactory>((serviceProvider) =>
{
    var connection = new SqlConnection(connectionString);

    var compiler = new SqlServerCompiler();

    return new QueryFactory(connection, compiler);
});

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