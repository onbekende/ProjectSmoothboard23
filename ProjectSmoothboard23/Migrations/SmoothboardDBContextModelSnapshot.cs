﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectSmoothboard23.Models;

namespace ProjectSmoothboard23.Migrations
{
    [DbContext(typeof(SmoothboardDBContext))]
    partial class SmoothboardDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectSmoothboard23.Models.FAQ", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("answer");

                    b.Property<string>("question");

                    b.HasKey("id");

                    b.ToTable("FAQ");
                });

            modelBuilder.Entity("ProjectSmoothboard23.Models.Product", b =>
                {
                    b.Property<int>("productid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description");

                    b.Property<decimal>("prijs");

                    b.Property<string>("productname");

                    b.HasKey("productid");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ProjectSmoothboard23.Models.Subscription", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("country");

                    b.Property<string>("email");

                    b.Property<int>("gender");

                    b.Property<string>("lastname");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Subscription");
                });
#pragma warning restore 612, 618
        }
    }
}
