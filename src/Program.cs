using ArjSys.Data;
using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Data.Repositories;
using ArjSys.Services.Interfaces;
using ArjSys.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

// Configuração do banco de dados SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Registro dos repositórios
builder.Services.AddScoped<IEstoqueRepository, EstoqueRepository>();
builder.Services.AddScoped<IItemVendaRepository, ItemVendaRepository>();
builder.Services.AddScoped<IProducaoRepository, ProducaoRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProjetoRepository, ProjetoRepository>();
builder.Services.AddScoped<IVendaRepository, VendaRepository>();

// Registro dos serviços
builder.Services.AddScoped<IEstoqueService, EstoqueService>();
builder.Services.AddScoped<IItemVendaService, ItemVendaService>();
builder.Services.AddScoped<IProducaoService, ProducaoService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IProjetoService, ProjetoService>();
builder.Services.AddScoped<IVendaService, VendaService>();



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
