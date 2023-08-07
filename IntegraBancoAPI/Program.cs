using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Inteface;
using IntegraBancoAPI.Mappings;
using IntegraBancoAPI.Models;
using IntegraBancoAPI.Rest;
using IntegraBancoAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
builder.Services.AddSingleton<IBancoApi, BancoApiRest>();
//builder.Services.AddSingleton<IBancoServices, BancoModel>();

builder.Services.AddAutoMapper(typeof(EnderecoMapping));

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
