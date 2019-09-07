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
    [Migration("20190523171409_PackageRelationshpMig")]
    partial class PackageRelationshpMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Etudiant.Models.DefaultPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("admissionFee");

                    b.Property<decimal>("classFee");

                    b.Property<int>("latePaymentDate");

                    b.Property<bool>("latePaymentEnabled");

                    b.Property<decimal>("latePaymentPrecentage");

                    b.Property<bool>("monthEndEnabled");

                    b.Property<decimal>("monthEndPrecentage");

                    b.HasKey("Id");

                    b.ToTable("DefaultPayments");
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

                    b.Property<string>("City");

                    b.Property<string>("FatherMobileNumber");

                    b.Property<string>("FatherName");

                    b.Property<string>("FatherOccupation");

                    b.Property<string>("FatherOfficeAddress");

                    b.Property<string>("LandLineNumber");

                    b.Property<string>("MotherMobileNumber");

                    b.Property<string>("MotherName");

                    b.Property<string>("MotherOccupation");

                    b.Property<string>("MotherOfficeAddress");

                    b.Property<string>("SMSAlertNumber");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Etudiant.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

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

                    b.Property<string>("Class");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Grade");

                    b.Property<string>("IndexNumber")
                        .IsRequired();

                    b.Property<string>("LastName");

                    b.Property<string>("Note");

                    b.Property<int?>("ParentId");

                    b.Property<string>("Photo");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<string>("School");

                    b.Property<string>("SecondName");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("ParentId");

                    b.ToTable("Students");
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

                    b.HasOne("Etudiant.Models.Parent", "Parent")
                        .WithMany("Students")
                        .HasForeignKey("ParentId");
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