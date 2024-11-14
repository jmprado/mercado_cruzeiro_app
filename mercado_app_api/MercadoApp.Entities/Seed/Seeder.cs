namespace MercadoApp.Entities.Seed;


public static class Seeder
{
    public static void Initialize(MercadoAppDbContext context)
    {
        context.Database.EnsureCreated();

        context.TiposLoja.AddRange(SeedData.ListaTipoLoja);
        context.Lojas.AddRange(SeedData.ListaLojas);
        context.UnidadesProduto.AddRange(SeedData.ListaUnidadeProduto);
        context.Produtos.AddRange(SeedData.ListaProduto);

        context.SaveChanges();
    }
}

