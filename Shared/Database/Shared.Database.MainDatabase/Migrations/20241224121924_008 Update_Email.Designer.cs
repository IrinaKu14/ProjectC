﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shared.Database.MainDatabase;

#nullable disable

namespace Shared.Database.MainDatabase.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20241224121924_008 Update_Email")]
    partial class _008Update_Email
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("ProjectC.SharedEntities.Message", b =>
                {
                    b.Property<int>("UniqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT")
                        .HasColumnName("message_body");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UniqId");

                    b.HasIndex("AuthorID");

                    b.ToTable("main_messages", (string)null);
                });

            modelBuilder.Entity("ProjectC.SharedEntities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsActiv")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 50,
                            Email = "admin@mail.com",
                            FirstName = "Admin",
                            Gender = true,
                            PasswordHash = "password",
                            SecondName = "Main"
                        });
                });

            modelBuilder.Entity("ProjectC.SharedEntities.Message", b =>
                {
                    b.HasOne("ProjectC.SharedEntities.User", "Producer")
                        .WithMany("Message")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("ProjectC.SharedEntities.User", b =>
                {
                    b.Navigation("Message");
                });
#pragma warning restore 612, 618
        }
    }
}
