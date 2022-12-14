// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Razor.Data;

#nullable disable

namespace Project_Razor.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20220923174424_tableShoppingCart")]
    partial class tableShoppingCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Project_Razor.Models.Admin", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("admin");

                    b.HasData(
                        new
                        {
                            Id = "caa82ac9-8d80-452b-9b21-1d5ebf87ed18",
                            Nome = "sa",
                            Senha = "1234"
                        });
                });

            modelBuilder.Entity("Project_Razor.Models.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT")
                        .HasColumnName("dataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("nome");

                    b.Property<string>("shoppingCartId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("shoppingCartId");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("Project_Razor.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("descricao");

                    b.Property<int>("Estoque")
                        .HasColumnType("INTEGER")
                        .HasColumnName("estoque");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("imageName");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("preco");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("produto");
                });

            modelBuilder.Entity("Project_Razor.Models.ShoppingCart", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Project_Razor.Models.Client", b =>
                {
                    b.HasOne("Project_Razor.Models.ShoppingCart", "shoppingCart")
                        .WithMany()
                        .HasForeignKey("shoppingCartId");

                    b.Navigation("shoppingCart");
                });

            modelBuilder.Entity("Project_Razor.Models.Product", b =>
                {
                    b.HasOne("Project_Razor.Models.ShoppingCart", null)
                        .WithMany("Products")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("Project_Razor.Models.ShoppingCart", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
