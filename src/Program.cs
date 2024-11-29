using ArjSys.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

// Configuração do banco de dados SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);


// Adiciona a configuração do Swagger (Documentação da API)
builder.Services.AddEndpointsApiExplorer(); // Necessário para o Swagger
builder.Services.AddSwaggerGen(); // Gera o Swagger UI

var app = builder.Build();

// Habilita o Swagger apenas no ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    // Gera a documentação Swagger
    app.UseSwagger();

    // Configura o Swagger UI com o endpoint especificado
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArjSYS API v1"));
}

// Configura o pipeline de requisições HTTP
app.UseHttpsRedirection();  // Redireciona para HTTPS
app.UseAuthorization();  // Habilita a autorização (caso necessário)

app.MapControllers();  // Mapeia os controllers da API

app.Run();
