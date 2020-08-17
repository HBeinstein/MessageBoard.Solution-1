﻿// <auto-generated />
using System;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Solution.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    [Migration("20200817183736_UpdateSeedData")]
    partial class UpdateSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoard.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("MessageBoard.Models.GroupMessage", b =>
                {
                    b.Property<int>("GroupMessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupId");

                    b.Property<int>("MessageId");

                    b.HasKey("GroupMessageId");

                    b.HasIndex("GroupId");

                    b.HasIndex("MessageId");

                    b.ToTable("GroupMessages");
                });

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.Property<string>("UserName");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            Body = "Hello? Hello???",
                            Date = new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hello",
                            UserName = "Test1"
                        },
                        new
                        {
                            MessageId = 2,
                            Body = "I don't know why you say goodbye I say hello.",
                            Date = new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Goodbye",
                            UserName = "Test2"
                        },
                        new
                        {
                            MessageId = 3,
                            Body = "This is a test of the emergency alert system.",
                            Date = new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "This is only a test",
                            UserName = "Test3"
                        },
                        new
                        {
                            MessageId = 4,
                            Body = "You would be dead. Probably, who knows. If you saw a flash, most likely.",
                            Date = new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "If this was a real alert",
                            UserName = "Test4"
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.GroupMessage", b =>
                {
                    b.HasOne("MessageBoard.Models.Group", "Group")
                        .WithMany("Messages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MessageBoard.Models.Message", "Message")
                        .WithMany("Groups")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
