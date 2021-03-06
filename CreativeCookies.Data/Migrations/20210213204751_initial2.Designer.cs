﻿// <auto-generated />
using System;
using CreativeCookies.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CreativeCookies.Data.Migrations
{
    [DbContext(typeof(PostsContext))]
    [Migration("20210213204751_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CreativeCookies.Domain.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("videoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d36497c-21ca-46e8-abff-ddbeb03a7998"),
                            Content = "First seeded Post's content",
                            Description = "First seeded Post's description",
                            PublicationDate = new DateTime(2021, 2, 13, 21, 47, 51, 665, DateTimeKind.Local).AddTicks(9780),
                            Title = "First",
                            imageUrl = "assets/images/first.jpg",
                            videoUrl = "https://www.youtube.com/embed/TGJiUNtOReI"
                        },
                        new
                        {
                            Id = new Guid("9b2f8056-bcd6-4ad6-912f-8a7aa290878f"),
                            Content = "And this is second post",
                            Description = "The description of second post",
                            PublicationDate = new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Second",
                            imageUrl = "assets/images/second.jpg",
                            videoUrl = "https://www.youtube.com/embed/TGJiUNtOReI"
                        },
                        new
                        {
                            Id = new Guid("25b9b333-e6ab-4d8b-a152-0498f43882de"),
                            Content = "And this is the third post",
                            Description = "It's description",
                            PublicationDate = new DateTime(2021, 2, 16, 9, 47, 51, 667, DateTimeKind.Local).AddTicks(5891),
                            Title = "Third",
                            imageUrl = "assets/images/third.jpg",
                            videoUrl = "https://www.youtube.com/embed/TGJiUNtOReI"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
