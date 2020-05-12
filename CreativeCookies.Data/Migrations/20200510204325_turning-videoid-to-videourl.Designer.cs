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
    [Migration("20200510204325_turning-videoid-to-videourl")]
    partial class turningvideoidtovideourl
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

                    b.Property<int>("VideoAccess")
                        .HasColumnType("int");

                    b.Property<string>("youtubeVideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cbc85ab1-b760-408d-8fbc-cf2916e775b6"),
                            Content = "First seeded Post's content",
                            Description = "First seeded Post's description",
                            PublicationDate = new DateTime(2020, 5, 10, 22, 43, 24, 533, DateTimeKind.Local).AddTicks(4320),
                            Title = "First",
                            VideoAccess = 1,
                            youtubeVideoUrl = "TGJiUNtOReI"
                        },
                        new
                        {
                            Id = new Guid("08c3bd00-0ce7-46e7-b7f7-7065354e279f"),
                            Content = "And this is second post",
                            Description = "The description of second post",
                            PublicationDate = new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Second",
                            VideoAccess = 0,
                            youtubeVideoUrl = "kmXUd6VLdj8"
                        },
                        new
                        {
                            Id = new Guid("013b4539-2d89-4611-8440-6a059025d3c9"),
                            Content = "And this is the third post",
                            Description = "It's description",
                            PublicationDate = new DateTime(2020, 5, 13, 10, 43, 24, 538, DateTimeKind.Local).AddTicks(2375),
                            Title = "Third",
                            VideoAccess = 0,
                            youtubeVideoUrl = "kmXUd6VLdj8"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}