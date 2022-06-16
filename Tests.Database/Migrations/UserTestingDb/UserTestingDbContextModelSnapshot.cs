﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tests.Database.Context;

namespace Tests.Database.Migrations.UserTestingDb
{
    [DbContext(typeof(UserTestingDbContext))]
    partial class UserTestingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tests.Database.Model.AnswerOptions", b =>
                {
                    b.Property<int>("IdAnswerOptions")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("CorrectAnswer")
                        .HasColumnType("bit");

                    b.Property<string>("Possiblenswer")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("QuestionsId")
                        .HasPrecision(10)
                        .HasColumnType("int");

                    b.HasKey("IdAnswerOptions");

                    b.HasIndex("QuestionsId");

                    b.ToTable("AnswerOptions");
                });

            modelBuilder.Entity("Tests.Database.Model.ListTests", b =>
                {
                    b.Property<int>("IdListTest")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Img")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Note")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("StatusPublic")
                        .HasColumnType("bit");

                    b.HasKey("IdListTest");

                    b.ToTable("ListTests");
                });

            modelBuilder.Entity("Tests.Database.Model.Questions", b =>
                {
                    b.Property<int>("IdQuestions")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionText")
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<int?>("TestsId")
                        .HasPrecision(10)
                        .HasColumnType("int");

                    b.HasKey("IdQuestions");

                    b.HasIndex("TestsId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Tests.Database.Model.UserTest", b =>
                {
                    b.Property<int>("TestId")
                        .HasPrecision(10)
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.ToTable("UserTests");
                });

            modelBuilder.Entity("Tests.Database.Model.AnswerOptions", b =>
                {
                    b.HasOne("Tests.Database.Model.Questions", "Question")
                        .WithMany("AnswerOptions")
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Tests.Database.Model.Questions", b =>
                {
                    b.HasOne("Tests.Database.Model.ListTests", "ListTests")
                        .WithMany("Questions")
                        .HasForeignKey("TestsId");

                    b.Navigation("ListTests");
                });

            modelBuilder.Entity("Tests.Database.Model.ListTests", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Tests.Database.Model.Questions", b =>
                {
                    b.Navigation("AnswerOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
