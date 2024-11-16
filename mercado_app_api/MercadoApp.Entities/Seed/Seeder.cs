namespace MercadoApp.Entities.Seed;


public static class Seeder
{
    public static void Initialize(MercadoAppDbContext context)
    {
        context.Database.EnsureCreated();

        if (context.TiposLoja.Any())
            context.TiposLoja.RemoveRange(SeedData.ListaTipoLoja);

        if (context.Lojas.Any())
            context.Lojas.RemoveRange(SeedData.ListaLojas);

        if (context.UnidadesProduto.Any())
            context.UnidadesProduto.RemoveRange(SeedData.ListaUnidadeProduto);

        if (context.Produtos.Any())
            context.Produtos.RemoveRange(SeedData.ListaProduto);

        context.SaveChanges();

        context.TiposLoja.AddRange(SeedData.ListaTipoLoja);
        context.Lojas.AddRange(SeedData.ListaLojas);
        context.UnidadesProduto.AddRange(SeedData.ListaUnidadeProduto);
        context.Produtos.AddRange(SeedData.ListaProduto);

        context.SaveChanges();
    }
}

