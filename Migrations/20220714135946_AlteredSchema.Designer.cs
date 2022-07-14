﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenhavenMgmt.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220714135946_AlteredSchema")]
    partial class AlteredSchema
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

                    b.Property<int>("birthDay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("birthMonth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("birthYear")
                        .HasColumnType("INTEGER");

                    b.Property<int>("deathDay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("deathMonth")
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