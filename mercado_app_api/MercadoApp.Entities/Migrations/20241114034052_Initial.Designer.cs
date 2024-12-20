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
    [Migration("20241114034052_Initial")]
    partial class Initial
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
                });

            modelBuilder.Entity("MercadoApp.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

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

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Preco")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("produto", (string)null);
                });

            modelBuilder.Entity("MercadoApp.Entities.TipoLoja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tipo_loja", (string)null);
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
