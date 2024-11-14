namespace MercadoApp.Entities.Seed;

public static class SeedData
{
    public static UnidadeProduto[] ListaUnidadeProduto =
    [
        new UnidadeProduto { Id = 1, Nome = "Unidade" },
        new UnidadeProduto { Id = 2, Nome = "Kg" },
        new UnidadeProduto { Id = 3, Nome = "G" },
        new UnidadeProduto { Id = 4, Nome = "L" },
        new UnidadeProduto { Id = 5, Nome = "Ml" },
        new UnidadeProduto { Id = 6, Nome = "Pacote" },
        new UnidadeProduto { Id = 7, Nome = "Caixa" },
        new UnidadeProduto { Id = 8, Nome = "Dúzia" },
        new UnidadeProduto { Id = 9, Nome = "Lata" },
        new UnidadeProduto { Id = 10, Nome = "Garrafa" },
        new UnidadeProduto { Id = 11, Nome = "Saco" },
        new UnidadeProduto { Id = 12, Nome = "Pote" },
        new UnidadeProduto { Id = 13, Nome = "Barra" },
        new UnidadeProduto { Id = 14, Nome = "Fardo" },
        new UnidadeProduto { Id = 15, Nome = "Pacote" },
        new UnidadeProduto { Id = 16, Nome = "Saco" }
    ];

    public static Produto[] ListaProduto =
    {
        new Produto { Id = 1, Nome = "Arroz", Preco = 10, IdLoja = 1 },
        new Produto { Id = 2, Nome = "Feijão", Preco = 5, IdLoja = 1 },
        new Produto { Id = 3, Nome = "Macarrão", Preco = 3, IdLoja = 1 },
        new Produto { Id = 4, Nome = "Óleo", Preco = 7, IdLoja = 1 },
        new Produto { Id = 5, Nome = "Sal", Preco = 2, IdLoja = 1 },
        new Produto { Id = 6, Nome = "Açúcar", Preco = 4, IdLoja = 1 },
        new Produto { Id = 7, Nome = "Café", Preco = 8, IdLoja = 1 },
        new Produto { Id = 8, Nome = "Leite", Preco = 6, IdLoja = 1 },
        new Produto { Id = 9, Nome = "Manteiga", Preco = 9, IdLoja = 1 },
        new Produto { Id = 10, Nome = "Queijo", Preco = 12, IdLoja = 1 },
        new Produto { Id = 11, Nome = "Presunto", Preco = 15, IdLoja = 1 },
        new Produto { Id = 12, Nome = "Pão", Preco = 1, IdLoja = 1 },
        new Produto { Id = 13, Nome = "Bolo", Preco = 20, IdLoja = 1 },
        new Produto { Id = 14, Nome = "Refrigerante", Preco = 5, IdLoja = 1 },
        new Produto { Id = 15, Nome = "Cerveja", Preco = 3, IdLoja = 1 },
        new Produto { Id = 16, Nome = "Vinho", Preco = 10, IdLoja = 1 },
        new Produto { Id = 17, Nome = "Whisky", Preco = 50, IdLoja = 1 },
        new Produto { Id = 18, Nome = "Vodka", Preco = 30, IdLoja = 1 },
        new Produto { Id = 19, Nome = "Tequila", Preco = 25, IdLoja = 1 },
        new Produto { Id = 20, Nome = "Cachaça", Preco = 20, IdLoja = 1 },
        new Produto { Id = 21, Nome = "Licor", Preco = 15, IdLoja = 1 },
        new Produto { Id = 22, Nome = "Suco", Preco = 5, IdLoja = 1 },
        new Produto { Id = 23, Nome = "Água", Preco = 2, IdLoja = 1 },
        new Produto { Id = 24, Nome = "Energético", Preco = 10, IdLoja = 1 },
        new Produto { Id = 25, Nome = "Café", Preco = 8, IdLoja = 1 },
        new Produto { Id = 26, Nome = "Chá", Preco = 5, IdLoja = 1 },
        new Produto { Id = 27, Nome = "Chocolate", Preco = 3, IdLoja = 1 },
        new Produto { Id = 28, Nome = "Balas", Preco = 1, IdLoja = 1 },
        new Produto { Id = 29, Nome = "Salgadinhos", Preco = 6, IdLoja = 1 },
    };


    public static Loja[] ListaLojas =
    {
        new Loja { Id = 1, Nome = "Mercado do João", NomeProprietario = "João", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Mercado do João", ImagemLoja = "", Delivery = 1, IdTipoLoja = 1 },
        new Loja { Id = 2, Nome = "Padaria do José", NomeProprietario = "José", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Padaria do José", ImagemLoja = "", Delivery = 1, IdTipoLoja = 2 },
        new Loja { Id = 3, Nome = "Farmácia da Maria", NomeProprietario = "Maria", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Farmácia da Maria", ImagemLoja = "", Delivery = 1, IdTipoLoja = 3 },
        new Loja { Id = 4, Nome = "Restaurante do Pedro", NomeProprietario = "Pedro", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Restaurante do Pedro", ImagemLoja = "", Delivery = 1, IdTipoLoja = 4 },
        new Loja { Id = 5, Nome = "Lanchonete da Ana", NomeProprietario = "Ana", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Lanchonete da Ana", ImagemLoja = "", Delivery = 1, IdTipoLoja = 5 },
        new Loja { Id = 6, Nome = "Pizzaria do Carlos", NomeProprietario = "Carlos", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Pizzaria do Carlos", ImagemLoja = "", Delivery = 1, IdTipoLoja = 6 },
        new Loja { Id = 7, Nome = "Sorveteria da Júlia", NomeProprietario = "Júlia", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Sorveteria da Júlia", ImagemLoja = "", Delivery = 1, IdTipoLoja = 7 },
        new Loja { Id = 8, Nome = "Bar do Mário", NomeProprietario = "Mário", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Bar do Mário", ImagemLoja = "", Delivery = 1, IdTipoLoja = 8 },
        new Loja { Id = 9, Nome = "Livros do Lucas", NomeProprietario = "Lucas", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Livros do Lucas", ImagemLoja = "", Delivery = 1, IdTipoLoja = 10 },
        new Loja { Id = 10, Nome = "Livros e Brinquedos da Laura", NomeProprietario = "Laura", Email = "", Telefone = "", Whatsapp = "11999999999", Descricao = "Livros e Brinquedos da Laura", ImagemLoja = "", Delivery = 1, IdTipoLoja = 11 },
    };

    public static TipoLoja[] ListaTipoLoja =
    {
        new TipoLoja { Id = 1, Nome = "Mercado" },
        new TipoLoja { Id = 2, Nome = "Padaria" },
        new TipoLoja { Id = 3, Nome = "Farmácia" },
        new TipoLoja { Id = 4, Nome = "Restaurante" },
        new TipoLoja { Id = 5, Nome = "Lanchonete" },
        new TipoLoja { Id = 6, Nome = "Pizzaria" },
        new TipoLoja { Id = 7, Nome = "Sorveteria" },
        new TipoLoja { Id = 8, Nome = "Bar" },
        new TipoLoja { Id = 9, Nome = "Brinquedos" },
        new TipoLoja { Id = 10, Nome = "Livros" },
        new TipoLoja { Id = 11, Nome = "Livros e Brinquedos" },
        new TipoLoja { Id = 12, Nome = "Loja de Cosméticos" },
        new TipoLoja { Id = 13, Nome = "Loja de Perfumaria" },
        new TipoLoja { Id = 14, Nome = "Loja de Joias" },
        new TipoLoja { Id = 15, Nome = "Loja de Bijuterias" },
        new TipoLoja { Id = 16, Nome = "Loja de Cama, Mesa e Banho" },
        new TipoLoja { Id = 17, Nome = "Loja de Enxoval" },
        new TipoLoja { Id = 18, Nome = "Loja de Bebidas" },
        new TipoLoja { Id = 19, Nome = "Hortifruti" },
        new TipoLoja { Id = 20, Nome = "Loja de Materiais de Construção" },
        new TipoLoja { Id = 21, Nome = "Mercadão" },
        new TipoLoja { Id = 22, Nome = "Plantas & Flores" },
        new TipoLoja { Id = 23, Nome = "Floricultura" },
        new TipoLoja { Id = 24, Nome = "Produtos da Roça" },
        new TipoLoja { Id = 25, Nome = "Queijaria" },
        new TipoLoja { Id = 26, Nome = "Queijaria & Cachaçaria" },
    };
}
