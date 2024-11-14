﻿// <auto-generated />
using System;
using MercadoApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MercadoApp.Entities.Migrations
{
    [DbContext(typeof(MercadoAppDbContext))]
    [Migration("20241114151415_Update III")]
    partial class UpdateIII
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("MercadoApp.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Telefone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Whatsapp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("MercadoApp.Entities.EntradaProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataOperacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("IdProduto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto");

                    b.ToTable("entrada_produto", (string)null);
                });

            modelBuilder.Entity("MercadoApp.Entities.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdLoja")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProduto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUnidade")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdLoja");

                    b.HasIndex("IdProduto");

                    b.HasIndex("IdUnidade");

                    b.ToTable("estoque", (string)null);
                });

            modelBuilder.Entity("MercadoApp.Entities.ImagemProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProduto")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto");

                    b.ToTable("imagem_produto", (string)null);
                });

            modelBuilder.Entity("MercadoApp.Entities.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Delivery")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdTipoLoja")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagemLoja")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeProprietario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Whatsapp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoLoja");

                    b.ToTable("loja", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Delivery = 1,
                            Descricao = "Mercado do João",
                            Email = "",
                            IdTipoLoja = 1,
                            ImagemLoja = "",
                            Nome = "Mercado do João",
                            NomeProprietario = "João",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        },
                        new
                        {
                            Id = 2,
                            Delivery = 1,
                            Descricao = "Padaria do José",
                            Email = "",
                            IdTipoLoja = 2,
                            ImagemLoja = "",
                            Nome = "Padaria do José",
                            NomeProprietario = "José",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        },
                        new
                        {
                            Id = 3,
                            Delivery = 1,
                            Descricao = "Farmácia da Maria",
                            Email = "",
                            IdTipoLoja = 3,
                            ImagemLoja = "",
                            Nome = "Farmácia da Maria",
                            NomeProprietario = "Maria",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        },
                        new
                        {
                            Id = 4,
                            Delivery = 1,
                            Descricao = "Restaurante do Pedro",
                            Email = "",
                            IdTipoLoja = 4,
                            ImagemLoja = "",
                            Nome = "Restaurante do Pedro",
                            NomeProprietario = "Pedro",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        },
                        new
                        {
                            Id = 5,
                            Delivery = 1,
                            Descricao = "Lanchonete da Ana",
                            Email = "",
                            IdTipoLoja = 5,
                            ImagemLoja = "",
                            Nome = "Lanchonete da Ana",
                            NomeProprietario = "Ana",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        },
                        new
                        {
                            Id = 6,
                            Delivery = 1,
                            Descricao = "Pizzaria do Carlos",
                            Email = "",
                            IdTipoLoja = 6,
                            ImagemLoja = "",
                            Nome = "Pizzaria do Carlos",
                            NomeProprietario = "Carlos",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        },
                        new
                        {
                            Id = 7,
                            Delivery = 1,
                            Descricao = "Sorveteria da Júlia",
                            Email = "",
                            IdTipoLoja = 7,
                            ImagemLoja = "",
                            Nome = "Sorveteria da Júlia",
                            NomeProprietario = "Júlia",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        },
                        new
                        {
                            Id = 8,
                            Delivery = 1,
                            Descricao = "Bar do Mário",
                            Email = "",
                            IdTipoLoja = 8,
                            ImagemLoja = "",
                            Nome = "Bar do Mário",
                            NomeProprietario = "Mário",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        },
                        new
                        {
                            Id = 9,
                            Delivery = 1,
                            Descricao = "Livros do Lucas",
                            Email = "",
                            IdTipoLoja = 10,
                            ImagemLoja = "",
                            Nome = "Livros do Lucas",
                            NomeProprietario = "Lucas",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        },
                        new
                        {
                            Id = 10,
                            Delivery = 1,
                            Descricao = "Livros e Brinquedos da Laura",
                            Email = "",
                            IdTipoLoja = 11,
                            ImagemLoja = "",
                            Nome = "Livros e Brinquedos da Laura",
                            NomeProprietario = "Laura",
                            Telefone = "",
                            Whatsapp = "11999999999"
                        });
                });

            modelBuilder.Entity("MercadoApp.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Atendido")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataAtendimento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("IdCliente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdLoja")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdLoja");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("MercadoApp.Entities.PedidoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPedido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProduto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdPedido");

                    b.HasIndex("IdProduto");

                    b.ToTable("pedido_produto", (string)null);
                });

            modelBuilder.Entity("MercadoApp.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Preco")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("produto", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "",
                            Nome = "Arroz",
                            Preco = 10
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "",
                            Nome = "Feijão",
                            Preco = 5
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "",
                            Nome = "Macarrão",
                            Preco = 3
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "",
                            Nome = "Óleo",
                            Preco = 7
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "",
                            Nome = "Sal",
                            Preco = 2
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "",
                            Nome = "Açúcar",
                            Preco = 4
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "",
                            Nome = "Café",
                            Preco = 8
                        },
                        new
                        {
                            Id = 8,
                            Descricao = "",
                            Nome = "Leite",
                            Preco = 6
                        },
                        new
                        {
                            Id = 9,
                            Descricao = "",
                            Nome = "Manteiga",
                            Preco = 9
                        },
                        new
                        {
                            Id = 10,
                            Descricao = "",
                            Nome = "Queijo",
                            Preco = 12
                        },
                        new
                        {
                            Id = 11,
                            Descricao = "",
                            Nome = "Presunto",
                            Preco = 15
                        },
                        new
                        {
                            Id = 12,
                            Descricao = "",
                            Nome = "Pão",
                            Preco = 1
                        },
                        new
                        {
                            Id = 13,
                            Descricao = "",
                            Nome = "Bolo",
                            Preco = 20
                        },
                        new
                        {
                            Id = 14,
                            Descricao = "",
                            Nome = "Refrigerante",
                            Preco = 5
                        },
                        new
                        {
                            Id = 15,
                            Descricao = "",
                            Nome = "Cerveja",
                            Preco = 3
                        },
                        new
                        {
                            Id = 16,
                            Descricao = "",
                            Nome = "Vinho",
                            Preco = 10
                        },
                        new
                        {
                            Id = 17,
                            Descricao = "",
                            Nome = "Whisky",
                            Preco = 50
                        },
                        new
                        {
                            Id = 18,
                            Descricao = "",
                            Nome = "Vodka",
                            Preco = 30
                        },
                        new
                        {
                            Id = 19,
                            Descricao = "",
                            Nome = "Tequila",
                            Preco = 25
                        },
                        new
                        {
                            Id = 20,
                            Descricao = "",
                            Nome = "Cachaça",
                            Preco = 20
                        },
                        new
                        {
                            Id = 21,
                            Descricao = "",
                            Nome = "Licor",
                            Preco = 15
                        },
                        new
                        {
                            Id = 22,
                            Descricao = "",
                            Nome = "Suco",
                            Preco = 5
                        },
                        new
                        {
                            Id = 23,
                            Descricao = "",
                            Nome = "Água",
                            Preco = 2
                        },
                        new
                        {
                            Id = 24,
                            Descricao = "",
                            Nome = "Energético",
                            Preco = 10
                        },
                        new
                        {
                            Id = 25,
                            Descricao = "",
                            Nome = "Café",
                            Preco = 8
                        },
                        new
                        {
                            Id = 26,
                            Descricao = "",
                            Nome = "Chá",
                            Preco = 5
                        },
                        new
                        {
                            Id = 27,
                            Descricao = "",
                            Nome = "Chocolate",
                            Preco = 3
                        },
                        new
                        {
                            Id = 28,
                            Descricao = "",
                            Nome = "Balas",
                            Preco = 1
                        },
                        new
                        {
                            Id = 29,
                            Descricao = "",
                            Nome = "Salgadinhos",
                            Preco = 6
                        });
                });

            modelBuilder.Entity("MercadoApp.Entities.TipoLoja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tipo_loja", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "",
                            Nome = "Mercado"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "",
                            Nome = "Padaria"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "",
                            Nome = "Farmácia"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "",
                            Nome = "Restaurante"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "",
                            Nome = "Lanchonete"
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "",
                            Nome = "Pizzaria"
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "",
                            Nome = "Sorveteria"
                        },
                        new
                        {
                            Id = 8,
                            Descricao = "",
                            Nome = "Bar"
                        },
                        new
                        {
                            Id = 9,
                            Descricao = "",
                            Nome = "Brinquedos"
                        },
                        new
                        {
                            Id = 10,
                            Descricao = "",
                            Nome = "Livros"
                        },
                        new
                        {
                            Id = 11,
                            Descricao = "",
                            Nome = "Livros e Brinquedos"
                        },
                        new
                        {
                            Id = 12,
                            Descricao = "",
                            Nome = "Loja de Cosméticos"
                        },
                        new
                        {
                            Id = 13,
                            Descricao = "",
                            Nome = "Loja de Perfumaria"
                        },
                        new
                        {
                            Id = 14,
                            Descricao = "",
                            Nome = "Loja de Joias"
                        },
                        new
                        {
                            Id = 15,
                            Descricao = "",
                            Nome = "Loja de Bijuterias"
                        },
                        new
                        {
                            Id = 16,
                            Descricao = "",
                            Nome = "Loja de Cama, Mesa e Banho"
                        },
                        new
                        {
                            Id = 17,
                            Descricao = "",
                            Nome = "Loja de Enxoval"
                        },
                        new
                        {
                            Id = 18,
                            Descricao = "",
                            Nome = "Loja de Bebidas"
                        },
                        new
                        {
                            Id = 19,
                            Descricao = "",
                            Nome = "Hortifruti"
                        },
                        new
                        {
                            Id = 20,
                            Descricao = "",
                            Nome = "Loja de Materiais de Construção"
                        },
                        new
                        {
                            Id = 21,
                            Descricao = "",
                            Nome = "Mercadão"
                        },
                        new
                        {
                            Id = 22,
                            Descricao = "",
                            Nome = "Plantas & Flores"
                        },
                        new
                        {
                            Id = 23,
                            Descricao = "",
                            Nome = "Floricultura"
                        },
                        new
                        {
                            Id = 24,
                            Descricao = "",
                            Nome = "Produtos da Roça"
                        },
                        new
                        {
                            Id = 25,
                            Descricao = "",
                            Nome = "Queijaria"
                        },
                        new
                        {
                            Id = 26,
                            Descricao = "",
                            Nome = "Queijaria & Cachaçaria"
                        });
                });

            modelBuilder.Entity("MercadoApp.Entities.UnidadeProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("unidade_produto", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Unidade"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Kg"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "G"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "L"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Ml"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Pacote"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Caixa"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Dúzia"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Lata"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Garrafa"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Saco"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Pote"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "Barra"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "Fardo"
                        },
                        new
                        {
                            Id = 15,
                            Nome = "Pacote"
                        },
                        new
                        {
                            Id = 16,
                            Nome = "Saco"
                        });
                });

            modelBuilder.Entity("MercadoApp.Entities.EntradaProduto", b =>
                {
                    b.HasOne("MercadoApp.Entities.Produto", "Produto")
                        .WithMany("EntradaProdutos")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("MercadoApp.Entities.Estoque", b =>
                {
                    b.HasOne("MercadoApp.Entities.Loja", "Loja")
                        .WithMany("Estoques")
                        .HasForeignKey("IdLoja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MercadoApp.Entities.Produto", "Produto")
                        .WithMany("Estoques")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MercadoApp.Entities.UnidadeProduto", "UnidadeProduto")
                        .WithMany("Estoques")
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loja");

                    b.Navigation("Produto");

                    b.Navigation("UnidadeProduto");
                });

            modelBuilder.Entity("MercadoApp.Entities.ImagemProduto", b =>
                {
                    b.HasOne("MercadoApp.Entities.Produto", "Produto")
                        .WithMany("ImagemProdutos")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("MercadoApp.Entities.Loja", b =>
                {
                    b.HasOne("MercadoApp.Entities.TipoLoja", "TipoLoja")
                        .WithMany("Lojas")
                        .HasForeignKey("IdTipoLoja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoLoja");
                });

            modelBuilder.Entity("MercadoApp.Entities.Pedido", b =>
                {
                    b.HasOne("MercadoApp.Entities.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MercadoApp.Entities.Loja", "Loja")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdLoja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Loja");
                });

            modelBuilder.Entity("MercadoApp.Entities.PedidoProduto", b =>
                {
                    b.HasOne("MercadoApp.Entities.Pedido", "Pedido")
                        .WithMany("PedidoProdutos")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MercadoApp.Entities.Produto", "Produto")
                        .WithMany("PedidoProdutos")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("MercadoApp.Entities.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("MercadoApp.Entities.Loja", b =>
                {
                    b.Navigation("Estoques");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("MercadoApp.Entities.Pedido", b =>
                {
                    b.Navigation("PedidoProdutos");
                });

            modelBuilder.Entity("MercadoApp.Entities.Produto", b =>
                {
                    b.Navigation("EntradaProdutos");

                    b.Navigation("Estoques");

                    b.Navigation("ImagemProdutos");

                    b.Navigation("PedidoProdutos");
                });

            modelBuilder.Entity("MercadoApp.Entities.TipoLoja", b =>
                {
                    b.Navigation("Lojas");
                });

            modelBuilder.Entity("MercadoApp.Entities.UnidadeProduto", b =>
                {
                    b.Navigation("Estoques");
                });
#pragma warning restore 612, 618
        }
    }
}
