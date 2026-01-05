using ClinicaMedicaAPI.Infra;
using ClinicaMedicaAPI.Modelos.Interfaces.Infra;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente;
using ClinicaMedicaAPI.Services;
using ClinicaMedicaAPI.UseCases.Consulta;
using ClinicaMedicaAPI.UseCases.Medico;
using ClinicaMedicaAPI.UseCases.Paciente;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IRepositorioMedico, RepositorioMedico>();
builder.Services.AddSingleton<IRepositorioPaciente,  RepositorioPaciente>();
builder.Services.AddSingleton<IRepositorioConsulta, RepositorioConsulta>();
builder.Services.AddSingleton<IMedicoService, MedicoService>();
builder.Services.AddSingleton<IPacienteService, PacienteService>();
builder.Services.AddSingleton<IConsultaService, ConsultaService>();
builder.Services.AddSingleton<IAtualizaMedicoUseCase, AtualizaMedicoUseCase>();
builder.Services.AddSingleton<IAtualizaPacienteUseCase, AtualizaPacienteUseCase>();
builder.Services.AddSingleton<IAtualizaConsultaUseCase, AtualizaConsultaUseCase>();
builder.Services.AddSingleton<IDeletaMedicoUseCase, DeletaMedicoUseCase>();
builder.Services.AddSingleton<IDeletaPacienteUseCase, DeletaPacienteUseCase>();
builder.Services.AddSingleton<IDeletaConsultaUseCase, DeletaConsultaUseCase>();
builder.Services.AddSingleton<IRegistraMedicoUseCase, RegistraMedicoUseCase>();
builder.Services.AddSingleton<IRegistraPacienteUseCase,  RegistraPacienteUseCase>();
builder.Services.AddSingleton<IRegistraConsultaUseCase, RegistraConsultaUseCase>();
builder.Services.AddSingleton<IRecuperaMedicoUseCase, RecuperaMedicoUseCase>();
builder.Services.AddSingleton<IRecuperaPacienteUseCase, RecuperaPacienteUseCase>();
builder.Services.AddSingleton<IRecuperaConsultaUseCase, RecuperaConsultaUseCase>();

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
