﻿// <auto-generated />
using System;
using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreProject.Migrations
{
    [DbContext(typeof(HplusSportsContext))]
    partial class HplusSportsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreProject.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CmpLastFirst")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasMaxLength(102)
                        .IsUnicode(false)
                        .HasColumnType("varchar(102)")
                        .HasColumnName("cmp_LastFirst")
                        .HasComputedColumnSql("(([str_fld_LastName]+', ')+[str_fld_FirstName])", true);

                    b.Property<string>("StrFldAddress")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("str_fld_Address");

                    b.Property<string>("StrFldCity")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("str_fld_City");

                    b.Property<string>("StrFldEmail")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("str_fld_Email");

                    b.Property<string>("StrFldFirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("str_fld_FirstName");

                    b.Property<string>("StrFldLastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("str_fld_LastName");

                    b.Property<string>("StrFldPhone")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("str_fld_Phone");

                    b.Property<string>("StrFldState")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("str_fld_State");

                    b.Property<string>("StrFldZipcode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("str_fld_Zipcode");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("EFCoreProject.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<byte[]>("LastUpdate")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<int>("SalespersonId")
                        .HasColumnType("int")
                        .HasColumnName("SalespersonID");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValueSql("('none')");

                    b.Property<decimal?>("TotalDue")
                        .HasColumnType("money");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SalespersonId");

                    b.HasIndex(new[] { "OrderDate" }, "IX_Order")
                        .IsDescending();

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("EFCoreProject.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderItemID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("ProductID");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem", (string)null);
                });

            modelBuilder.Entity("EFCoreProject.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("ProductID");

                    b.Property<int?>("ExpirationDays")
                        .HasColumnType("int");

                    b.Property<bool>("Perishable")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Refrigerated")
                        .HasColumnType("bit");

                    b.Property<int?>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Variety")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ProductId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("EFCoreProject.Models.SalesGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "State", "Type" }, "IX_StateType")
                        .IsUnique();

                    b.ToTable("SalesGroup", (string)null);
                });

            modelBuilder.Entity("EFCoreProject.Models.Salesperson", b =>
                {
                    b.Property<int>("SalespersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SalespersonID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalespersonId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SalesGroupState")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasDefaultValueSql("(N'CA')");

                    b.Property<int>("SalesGroupType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Zipcode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("SalespersonId");

                    b.ToTable("Salesperson", (string)null);
                });

            modelBuilder.Entity("EFCoreProject.Models.Order", b =>
                {
                    b.HasOne("EFCoreProject.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_Customer");

                    b.HasOne("EFCoreProject.Models.Salesperson", "Salesperson")
                        .WithMany("Orders")
                        .HasForeignKey("SalespersonId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_Salesperson");

                    b.Navigation("Customer");

                    b.Navigation("Salesperson");
                });

            modelBuilder.Entity("EFCoreProject.Models.OrderItem", b =>
                {
                    b.HasOne("EFCoreProject.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderItem_Order");

                    b.HasOne("EFCoreProject.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderItem_Product1");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EFCoreProject.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("EFCoreProject.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EFCoreProject.Models.Product", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EFCoreProject.Models.Salesperson", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
