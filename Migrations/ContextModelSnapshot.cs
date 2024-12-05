﻿// <auto-generated />
using System;
using Finance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Finance.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Finance.Models.Expenses", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("Finance.Models.ExpensesValues", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePaid")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ExpensesValues");
                });

            modelBuilder.Entity("Finance.Models.ExpensiveType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExpensiveType");
                });

            modelBuilder.Entity("Finance.Models.Revenue", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Revenue");
                });

            modelBuilder.Entity("Finance.Models.RevenueType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RevenueTypes");
                });

            modelBuilder.Entity("Finance.Models.RevenueValues", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateReceived")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRecept")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Received")
                        .HasColumnType("bit");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("RevenueValues");
                });

            modelBuilder.Entity("Finance.Models.Expenses", b =>
                {
                    b.HasOne("Finance.Models.ExpensiveType", "Type")
                        .WithMany("Expenses")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Finance.Models.ExpensesValues", b =>
                {
                    b.HasOne("Finance.Models.Expenses", "Expenses")
                        .WithMany("ExpensesValues")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("Finance.Models.Revenue", b =>
                {
                    b.HasOne("Finance.Models.RevenueType", "Type")
                        .WithMany("Revenues")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Finance.Models.RevenueValues", b =>
                {
                    b.HasOne("Finance.Models.Revenue", "Revenue")
                        .WithMany("RevenueValues")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Revenue");
                });

            modelBuilder.Entity("Finance.Models.Expenses", b =>
                {
                    b.Navigation("ExpensesValues");
                });

            modelBuilder.Entity("Finance.Models.ExpensiveType", b =>
                {
                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("Finance.Models.Revenue", b =>
                {
                    b.Navigation("RevenueValues");
                });

            modelBuilder.Entity("Finance.Models.RevenueType", b =>
                {
                    b.Navigation("Revenues");
                });
#pragma warning restore 612, 618
        }
    }
}