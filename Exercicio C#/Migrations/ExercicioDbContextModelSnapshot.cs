﻿// <auto-generated />
using Exercicio_C_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exercicio_C_.Migrations
{
    [DbContext(typeof(ExercicioDbContext))]
    partial class ExercicioDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Exercicio_C_.Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
