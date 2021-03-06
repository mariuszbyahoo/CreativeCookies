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
    [Migration("20200510132151_modifying-the-video-url")]
    partial class modifyingthevideourl
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

                    b.Property<string>("VideoID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("476858c8-26bc-4634-999c-c08655abe230"),
                            Content = "First seeded Post's content",
                            Description = "First seeded Post's description",
                            PublicationDate = new DateTime(2020, 5, 10, 15, 21, 51, 209, DateTimeKind.Local).AddTicks(6128),
                            Title = "First",
                            VideoAccess = 1,
                            VideoID = "TGJiUNtOReI"
                        },
                        new
                        {
                            Id = new Guid("f6974ef2-511f-471d-966b-d93d8c947f79"),
                            Content = "And this is second post",
                            Description = "The description of second post",
                            PublicationDate = new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Second",
                            VideoAccess = 0,
                            VideoID = "kmXUd6VLdj8"
                        },
                        new
                        {
                            Id = new Guid("e9a03907-6bc4-49d0-821b-2da38de6b85c"),
                            Content = "And this is the third post",
                            Description = "It's description",
                            PublicationDate = new DateTime(2020, 5, 13, 3, 21, 51, 213, DateTimeKind.Local).AddTicks(9431),
                            Title = "Third",
                            VideoAccess = 0,
                            VideoID = "kmXUd6VLdj8"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
