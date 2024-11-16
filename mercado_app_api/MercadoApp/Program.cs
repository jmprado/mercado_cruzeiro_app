using MercadoApp.Entities;
using MercadoApp.Entities.Seed;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Repository.Implementation;
using MercadoApp.Security;
using MercadoApp.Services.Abstraction;
using MercadoApp.Services.Implementation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MercadoAppDbContext>(options =>
{
    options.UseSqlite(connectionString, sqlite => sqlite.MigrationsAssembly("MercadoApp.Entities"));
    options.UseLazyLoadingProxies();
});

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<ITipoLojaRepository, TipoLojaRepository>();
builder.Services.AddScoped<ILojaRepository, LojaRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IUnidadeProdutoRepository, UnidadeProdutoRepository>();
builder.Services.AddScoped<IEstoqueRepository, EstoqueRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IPedidoProdutoRepository, PedidoProdutoRepository>();
builder.Services.AddScoped<IEntradaProdutoRepository, EntradaProdutoRepository>();
builder.Services.AddScoped<IImagemProdutoRepository, ImagemProdutoRepository>();

builder.Services.AddScoped<ITipoLojaService, TipoLojaService>();
builder.Services.AddScoped<ILojaService, LojaService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IUnidadeProdutoService, UnidadeProdutoService>();
builder.Services.AddScoped<IEstoqueService, EstoqueService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IPedidoProdutoService, PedidoProdutoService>();
builder.Services.AddScoped<IEntradaProdutoService, EntradaProdutoService>();
builder.Services.AddScoped<IImagemProdutoService, ImagemProdutoService>();

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Configure JWT settings
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
var jwtSettings = builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings!.Issuer,
            ValidAudience = jwtSettings.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey))
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();
SeedDatabase();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

void SeedDatabase()
{
    using var scope = app.Services.CreateScope();
    try
    {
        var scopedContext = scope.ServiceProvider.GetRequiredService<MercadoAppDbContext>();
        Seeder.Initialize(scopedContext);
    }
    catch
    {
        throw;
    }
}