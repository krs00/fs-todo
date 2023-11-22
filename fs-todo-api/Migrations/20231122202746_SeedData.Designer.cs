﻿// <auto-generated />
using FsToDoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace fs_todo_api.Migrations
{
    [DbContext(typeof(FsToDoApiContext))]
    [Migration("20231122202746_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FsToDoApi.Models.ToDo", b =>
                {
                    b.Property<int>("ToDoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Completed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("ToDoId");

                    b.ToTable("ToDos");

                    b.HasData(
                        new
                        {
                            ToDoId = 1,
                            Completed = false,
                            Description = "wash all the dishes in the sink!",
                            Title = "Wash Dishes"
                        },
                        new
                        {
                            ToDoId = 2,
                            Completed = false,
                            Description = "clean the bathroom!",
                            Title = "Clean bathroom"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
