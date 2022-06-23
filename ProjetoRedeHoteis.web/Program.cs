using ProjetoRedeHoteis.lib.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using ProjetoRedeHoteis.lib.Data.Repositorios;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RedeHoteisContext>(
    conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("RedeHoteisDB")));

builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling =
Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<EstadiaRepositorio>();
builder.Services.AddScoped<HospedeRepositorio>();
builder.Services.AddScoped<HotelRepositorio>();
builder.Services.AddScoped<QuartoRepositorio>();
builder.Services.AddScoped<ServicoRepositorio>();
builder.Services.AddScoped<TipoDeQuartoRepositorio>();

builder.Services.AddScoped<IEstadiaRepositorio, EstadiaRepositorio>();
builder.Services.AddScoped<IHospedeRepositorio, HospedeRepositorio>();
builder.Services.AddScoped<IHotelRepositorio, HotelRepositorio>();
builder.Services.AddScoped<IQuartoRepositorio, QuartoRepositorio>();
builder.Services.AddScoped<IServicoRepositorio, ServicoRepositorio>();
builder.Services.AddScoped<ITipoDeQuartoRepositorio, TipoDeQuartoRepositorio>();


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
