using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using MercadoApp.Repository.Implementation;
using MercadoApp.Services.Abstraction;
using MercadoApp.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MercadoAppDbContext>(options =>
{
    options.UseSqlite(connectionString);
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
