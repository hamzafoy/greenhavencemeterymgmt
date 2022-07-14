﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenhavenMgmt.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220616234947_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("GreenhavenMgmt.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("birthYear")
                        .HasColumnType("INTEGER");

                    b.Property<int>("deathYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("plot_id")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Person");
                });
#pragma warning restore 612, 618
        }
    }
}