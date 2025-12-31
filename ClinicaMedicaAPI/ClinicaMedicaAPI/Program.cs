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
builder.Services.AddSingleton<IRepositorioMedico, RepositorioMedico>();
builder.Services.AddSingleton<IMedicoService, MedicoService>();
builder.Services.AddSingleton<IAtualizaMedicoUseCase, AtualizaMedicoUseCase>();
builder.Services.AddSingleton<IDeletaMedicoUseCase, DeletaMedicoUseCase>();
builder.Services.AddSingleton<IRegistraMedicoUseCase, RegistraMedicoUseCase>();
builder.Services.AddSingleton<IRecuperaMedicoUseCase, RecuperaMedicoUseCase>();

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
