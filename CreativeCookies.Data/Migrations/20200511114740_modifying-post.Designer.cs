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
    [Migration("20200511114740_modifying-post")]
    partial class modifyingpost
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

                    b.Property<string>("youtubeVideoTrailerUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("youtubeVideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a2b94a50-f897-4d01-9298-279744272de2"),
                            Content = "First seeded Post's content",
                            Description = "First seeded Post's description",
                            PublicationDate = new DateTime(2020, 5, 11, 13, 47, 39, 380, DateTimeKind.Local).AddTicks(7189),
                            Title = "First",
                            youtubeVideoTrailerUrl = "kmXUd6VLdj8",
                            youtubeVideoUrl = "TGJiUNtOReI"
                        },
                        new
                        {
                            Id = new Guid("2fa86d6d-31ae-4b16-b917-a770118935be"),
                            Content = "And this is second post",
                            Description = "The description of second post",
                            PublicationDate = new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Second",
                            youtubeVideoTrailerUrl = "kmXUd6VLdj8",
                            youtubeVideoUrl = "TGJiUNtOReI"
                        },
                        new
                        {
                            Id = new Guid("0a1f2935-ad13-4827-81b5-cd965207e820"),
                            Content = "And this is the third post",
                            Description = "It's description",
                            PublicationDate = new DateTime(2020, 5, 14, 1, 47, 39, 385, DateTimeKind.Local).AddTicks(4683),
                            Title = "Third",
                            youtubeVideoTrailerUrl = "kmXUd6VLdj8",
                            youtubeVideoUrl = "TGJiUNtOReI"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}