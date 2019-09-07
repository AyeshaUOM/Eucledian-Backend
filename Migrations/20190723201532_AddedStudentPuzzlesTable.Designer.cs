﻿// <auto-generated />
using System;
using Etudiant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Etudiant.Migrations
{
    [DbContext(typeof(EtudiantContext))]
    [Migration("20190723201532_AddedStudentPuzzlesTable")]
    partial class AddedStudentPuzzlesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Etudiant.Models.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AccessDate");

                    b.Property<bool>("Active");

                    b.Property<int?>("AttendanceId");

                    b.Property<int?>("ClassId");

                    b.Property<bool>("Edit");

                    b.Property<int?>("branchId");

                    b.Property<int?>("studentId");

                    b.Property<int>("veryfyMode");

                    b.HasKey("Id");

                    b.HasIndex("AttendanceId");

                    b.HasIndex("ClassId");

                    b.HasIndex("branchId");

                    b.HasIndex("studentId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("Etudiant.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CRTDatetime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Etudiant.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Etudiant.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("branchId");

                    b.Property<string>("category");

                    b.Property<string>("dayOfWeek");

                    b.Property<bool>("isActive");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("timeOfDay");

                    b.Property<int?>("userId");

                    b.HasKey("Id");

                    b.HasIndex("branchId");

                    b.HasIndex("userId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Etudiant.Models.DefaultPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("admissionFee");

                    b.Property<int?>("branchId");

                    b.Property<decimal>("classFee");

                    b.Property<int>("latePaymentDate");

                    b.Property<bool>("latePaymentEnabled");

                    b.Property<decimal>("latePaymentPrecentage");

                    b.Property<bool>("monthEndEnabled");

                    b.Property<decimal>("monthEndPrecentage");

                    b.HasKey("Id");

                    b.HasIndex("branchId");

                    b.ToTable("DefaultPayments");
                });

            modelBuilder.Entity("Etudiant.Models.ExternalPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("NICNumber");

                    b.Property<string>("gender");

                    b.HasKey("Id");

                    b.ToTable("externalPlayer");
                });

            modelBuilder.Entity("Etudiant.Models.GoodReceiveNote_Main", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("Discount");

                    b.Property<int>("LotId");

                    b.Property<string>("Note");

                    b.Property<decimal>("TotalCostPrice");

                    b.Property<int?>("branchId");

                    b.Property<int?>("userId");

                    b.HasKey("id");

                    b.HasIndex("branchId");

                    b.HasIndex("userId");

                    b.ToTable("goodReceiveNote_Mains");
                });

            modelBuilder.Entity("Etudiant.Models.GoodReceiveNote_Sub", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<decimal>("CostPrice");

                    b.Property<int>("Qty");

                    b.Property<decimal>("SellPrice");

                    b.Property<decimal>("Total");

                    b.Property<int?>("goodReceiveNote_Mainid");

                    b.Property<int?>("itemId");

                    b.HasKey("id");

                    b.HasIndex("goodReceiveNote_Mainid");

                    b.HasIndex("itemId");

                    b.ToTable("goodReceiveNote_Subs");
                });

            modelBuilder.Entity("Etudiant.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("CategoryId");

                    b.Property<decimal>("CostPrice");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("SellPrice");

                    b.Property<int?>("subCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("subCategoryId");

                    b.ToTable("items");
                });

            modelBuilder.Entity("Etudiant.Models.ItemPicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId");

                    b.Property<string>("Picture");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("itemPictures");
                });

            modelBuilder.Entity("Etudiant.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("branchId");

                    b.Property<bool>("isActive");

                    b.Property<bool>("isAdmissionWaveOff");

                    b.Property<int>("noOfMonths");

                    b.Property<string>("packageName");

                    b.Property<decimal>("precentage");

                    b.HasKey("Id");

                    b.HasIndex("branchId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("Etudiant.Models.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressLine3");

                    b.Property<string>("FatherMobileNumber");

                    b.Property<string>("FatherName");

                    b.Property<string>("FatherOccupation");

                    b.Property<string>("FatherOfficeAddress");

                    b.Property<string>("LandLineNumber");

                    b.Property<string>("MotherMobileNumber");

                    b.Property<string>("MotherName");

                    b.Property<string>("MotherOccupation");

                    b.Property<string>("MotherOfficeAddress");

                    b.Property<string>("ParentType");

                    b.Property<string>("SMSAlertNumber");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Etudiant.Models.Puzzle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("ExerciseType");

                    b.Property<string>("Name");

                    b.Property<int>("NoofQuestions");

                    b.HasKey("Id");

                    b.ToTable("puzzles");
                });

            modelBuilder.Entity("Etudiant.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Division");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Etudiant.Models.Sibbing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Sibbings");
                });

            modelBuilder.Entity("Etudiant.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdmissionDate");

                    b.Property<decimal>("AdmissionFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("BranchId");

                    b.Property<int?>("ClassId");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Grade");

                    b.Property<string>("IndexNumber")
                        .IsRequired();

                    b.Property<string>("LastName");

                    b.Property<string>("Note");

                    b.Property<int>("ParentId");

                    b.Property<string>("Photo");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<string>("School");

                    b.Property<string>("SecondName");

                    b.Property<bool>("Status");

                    b.Property<string>("StudentType");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("ClassId");

                    b.HasIndex("ParentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Etudiant.Models.StudentClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId");

                    b.Property<bool>("active");

                    b.Property<DateTime>("datetime");

                    b.Property<bool>("status");

                    b.Property<int?>("studentId");

                    b.Property<int?>("userId");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("studentId");

                    b.HasIndex("userId");

                    b.ToTable("studentClasses");
                });

            modelBuilder.Entity("Etudiant.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("categoryId");

                    b.HasKey("Id");

                    b.HasIndex("categoryId");

                    b.ToTable("subCategories");
                });

            modelBuilder.Entity("Etudiant.Models.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndingDate");

                    b.Property<double>("ExternalFee");

                    b.Property<double>("InternalFee");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartingDate");

                    b.Property<string>("Venue");

                    b.HasKey("Id");

                    b.ToTable("tournament");
                });

            modelBuilder.Entity("Etudiant.Models.TournamentPlayers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlayerId");

                    b.Property<int>("TournamentId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TournamentId");

                    b.ToTable("tournamentPlayers");
                });

            modelBuilder.Entity("Etudiant.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressLine3");

                    b.Property<int?>("BranchId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int>("Role");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Etudiant.Models.Attendance", b =>
                {
                    b.HasOne("Etudiant.Models.Attendance")
                        .WithMany("AttendanceList")
                        .HasForeignKey("AttendanceId");

                    b.HasOne("Etudiant.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Etudiant.Models.Branch", "branch")
                        .WithMany()
                        .HasForeignKey("branchId");

                    b.HasOne("Etudiant.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId");
                });

            modelBuilder.Entity("Etudiant.Models.Class", b =>
                {
                    b.HasOne("Etudiant.Models.Branch", "branch")
                        .WithMany()
                        .HasForeignKey("branchId");

                    b.HasOne("Etudiant.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("Etudiant.Models.DefaultPayment", b =>
                {
                    b.HasOne("Etudiant.Models.Branch", "branch")
                        .WithMany()
                        .HasForeignKey("branchId");
                });

            modelBuilder.Entity("Etudiant.Models.GoodReceiveNote_Main", b =>
                {
                    b.HasOne("Etudiant.Models.Branch", "branch")
                        .WithMany()
                        .HasForeignKey("branchId");

                    b.HasOne("Etudiant.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("Etudiant.Models.GoodReceiveNote_Sub", b =>
                {
                    b.HasOne("Etudiant.Models.GoodReceiveNote_Main", "goodReceiveNote_Main")
                        .WithMany()
                        .HasForeignKey("goodReceiveNote_Mainid");

                    b.HasOne("Etudiant.Models.Item", "item")
                        .WithMany()
                        .HasForeignKey("itemId");
                });

            modelBuilder.Entity("Etudiant.Models.Item", b =>
                {
                    b.HasOne("Etudiant.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Etudiant.Models.SubCategory", "subCategory")
                        .WithMany()
                        .HasForeignKey("subCategoryId");
                });

            modelBuilder.Entity("Etudiant.Models.ItemPicture", b =>
                {
                    b.HasOne("Etudiant.Models.Item", "Item")
                        .WithMany("ItemPicture")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etudiant.Models.Package", b =>
                {
                    b.HasOne("Etudiant.Models.Branch", "branch")
                        .WithMany()
                        .HasForeignKey("branchId");
                });

            modelBuilder.Entity("Etudiant.Models.Student", b =>
                {
                    b.HasOne("Etudiant.Models.Branch")
                        .WithMany("Students")
                        .HasForeignKey("BranchId");

                    b.HasOne("Etudiant.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Etudiant.Models.Parent", "Parent")
                        .WithMany("Students")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etudiant.Models.StudentClass", b =>
                {
                    b.HasOne("Etudiant.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Etudiant.Models.Student", "student")
                        .WithMany("StudentClass")
                        .HasForeignKey("studentId");

                    b.HasOne("Etudiant.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("Etudiant.Models.SubCategory", b =>
                {
                    b.HasOne("Etudiant.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etudiant.Models.TournamentPlayers", b =>
                {
                    b.HasOne("Etudiant.Models.Student", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Etudiant.Models.Tournament", "Tournament")
                        .WithMany()
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etudiant.Models.User", b =>
                {
                    b.HasOne("Etudiant.Models.Branch", "Branch")
                        .WithMany("Users")
                        .HasForeignKey("BranchId");
                });
#pragma warning restore 612, 618
        }
    }
}
