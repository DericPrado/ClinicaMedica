using ClinicaMedicaAPI.Infra;
using ClinicaMedicaAPI.Modelos.Interfaces.Infra;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;
using ClinicaMedicaAPI.Services;
using ClinicaMedicaAPI.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepositorioMedico, RepositorioMedico>();
builder.Services.AddScoped<IMedicoService, MedicoService>();
builder.Services.AddScoped<IAtualizaMedicoUseCase, AtualizaMedicoUseCase>();
builder.Services.AddScoped<IDeletaMedicoUseCase, DeletaMedicoUseCase>();
builder.Services.AddScoped<IRegistraMedicoUseCase, RegistraMedicoUseCase>();
builder.Services.AddScoped<IRecuperaMedicoUseCase, RecuperaMedicoUseCase>();

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
