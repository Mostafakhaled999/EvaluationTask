﻿// <auto-generated />
using EvaluationTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvaluationTask.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230310141030_boxEntity")]
    partial class boxEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EvaluationTask.Model.Box", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("fromDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("noEnvelope")
                        .HasColumnType("int");

                    b.Property<int>("shipmentId")
                        .HasColumnType("int");

                    b.Property<string>("toDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("shipmentId");

                    b.ToTable("box");
                });

            modelBuilder.Entity("EvaluationTask.Model.Shipment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("fromDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("noBoxes")
                        .HasColumnType("int");

                    b.Property<string>("toDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Shipment");
                });

            modelBuilder.Entity("EvaluationTask.Model.Box", b =>
                {
                    b.HasOne("EvaluationTask.Model.Shipment", "shipment")
                        .WithMany()
                        .HasForeignKey("shipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("shipment");
                });
#pragma warning restore 612, 618
        }
    }
}
