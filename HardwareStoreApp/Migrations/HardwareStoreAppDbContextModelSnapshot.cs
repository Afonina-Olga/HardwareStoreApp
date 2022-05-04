﻿// <auto-generated />
using System;
using HardwareStoreApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HardwareStoreApp.Migrations
{
    [DbContext(typeof(HardwareStoreAppDbContext))]
    partial class HardwareStoreAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("HardwareStoreApp.Models.Balance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StoreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("Balance");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StoreId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StoreId1")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductId1");

                    b.HasIndex("StoreId");

                    b.HasIndex("StoreId1")
                        .IsUnique();

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.Balance", b =>
                {
                    b.HasOne("HardwareStoreApp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HardwareStoreApp.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.Product", b =>
                {
                    b.OwnsOne("HardwareStoreApp.Models.Category", "Category", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Id")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Name")
                                .HasColumnType("TEXT");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.Sale", b =>
                {
                    b.HasOne("HardwareStoreApp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HardwareStoreApp.Models.Product", null)
                        .WithMany("Sales")
                        .HasForeignKey("ProductId1");

                    b.HasOne("HardwareStoreApp.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HardwareStoreApp.Models.Store", null)
                        .WithOne("Sale")
                        .HasForeignKey("HardwareStoreApp.Models.Sale", "StoreId1");

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.Store", b =>
                {
                    b.OwnsOne("HardwareStoreApp.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("StoreId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("House")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Id")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Region")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .HasColumnType("TEXT");

                            b1.HasKey("StoreId");

                            b1.ToTable("Stores");

                            b1.WithOwner()
                                .HasForeignKey("StoreId");
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.Product", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("HardwareStoreApp.Models.Store", b =>
                {
                    b.Navigation("Sale");
                });
#pragma warning restore 612, 618
        }
    }
}
