﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PegasusPetshop.Database;

#nullable disable

namespace PegasusPetshop.Migrations
{
    [DbContext(typeof(PetshopContext))]
    partial class PetshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PegasusPetshop.Models.ClienteModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Contato")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuantidadePets")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("PegasusPetshop.Models.PetshopModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Salario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("funcionarios");
                });

            modelBuilder.Entity("PegasusPetshop.Models.PetsModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Plano")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TipoPet")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("idDono")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("pets");
                });

            modelBuilder.Entity("PegasusPetshop.Models.ProdutoModel", b =>
                {
                    b.Property<int>("CodigoDeBarra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClasseDoProduto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DataDeValidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QuantidadeEmEstoque")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CodigoDeBarra");

                    b.ToTable("produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
