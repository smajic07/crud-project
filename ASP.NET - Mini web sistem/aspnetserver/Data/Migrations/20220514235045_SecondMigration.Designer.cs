﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetserver.Data;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220514235045_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("aspnetserver.Data.Objava", b =>
                {
                    b.Property<int>("ObjavaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("TEXT");

                    b.HasKey("ObjavaId");

                    b.ToTable("Objave");

                    b.HasData(
                        new
                        {
                            ObjavaId = 1,
                            Naslov = "Objava 1",
                            Sadrzaj = "Ovo je 1. objava sa nekim zanimljivim sadržajem."
                        },
                        new
                        {
                            ObjavaId = 2,
                            Naslov = "Objava 2",
                            Sadrzaj = "Ovo je 2. objava sa nekim zanimljivim sadržajem."
                        },
                        new
                        {
                            ObjavaId = 3,
                            Naslov = "Objava 3",
                            Sadrzaj = "Ovo je 3. objava sa nekim zanimljivim sadržajem."
                        },
                        new
                        {
                            ObjavaId = 4,
                            Naslov = "Objava 4",
                            Sadrzaj = "Ovo je 4. objava sa nekim zanimljivim sadržajem."
                        },
                        new
                        {
                            ObjavaId = 5,
                            Naslov = "Objava 5",
                            Sadrzaj = "Ovo je 5. objava sa nekim zanimljivim sadržajem."
                        },
                        new
                        {
                            ObjavaId = 6,
                            Naslov = "Objava 6",
                            Sadrzaj = "Ovo je 6. objava sa nekim zanimljivim sadržajem."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
