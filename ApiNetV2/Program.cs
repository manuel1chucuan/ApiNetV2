using ApiNetV2.DbConfig;
using ApiNetV2.Models;

var builder = WebApplication.CreateBuilder(args);

// Aqui registramos el scope de inyeccion de dependencias
builder.Services.AddScoped<IDbDatos, DbDatos>();
builder.Services.AddScoped<ClienteInfo>();

// Aqui registramos nuestros controladores
builder.Services.AddControllers();

// Algunas herramientas
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger si es entorno de desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
