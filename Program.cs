using API_1.Data;
using API_1.Interfaces;
using API_1.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configurar el contexto de la base de datos
builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar servicios para controlar las API
builder.Services.AddControllers();

// Configurar Swagger
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Finshark API",
        Version = "v1",
        Description = "API para gestionar Finshark",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Soporte Finshark",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Licencia de Finshark",
            Url = new Uri("https://example.com/license")
        }
    });
});

builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>(); 
var app = builder.Build();

// Configurar la tubería de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Finshark API v1");
        c.RoutePrefix = string.Empty; // Esto hace que Swagger UI esté disponible en la raíz del sitio.
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();
