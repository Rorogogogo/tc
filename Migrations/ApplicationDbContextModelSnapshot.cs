﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tc.Data;

#nullable disable

namespace tc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ActivityTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ActivityName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("ActivityTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6f47efed-1d4e-4196-aeeb-c69a05dc693b"),
                            ActivityName = "Standard1",
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1920)
                        },
                        new
                        {
                            Id = new Guid("5e907643-1b38-48fa-8eb0-e1686c025947"),
                            ActivityName = "Standard2",
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1920)
                        });
                });

            modelBuilder.Entity("ApplicationUserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AppointmentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ActivityTypeId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("VenueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityTypeId");

                    b.HasIndex("UserId");

                    b.HasIndex("VenueId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c7e9509d-1345-477d-ba3f-64fd5f22db64"),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("03609fd3-32a1-4aad-ba34-3f5b8ccbf7bc"),
                            Name = "Standard",
                            NormalizedName = "STANDARD"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("VenueActivitySetupEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("OffSceneOffset")
                        .HasColumnType("int");

                    b.Property<int>("OnSceneOffset")
                        .HasColumnType("int");

                    b.Property<string>("Scene")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("VenueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("VenueActivitySetups");
                });

            modelBuilder.Entity("VenueEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Venues");

                    b.HasData(
                        new
                        {
                            Id = new Guid("960c65a6-af65-4fd8-8251-ef8ae040fbd8"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1660),
                            VenueName = "Venue1"
                        },
                        new
                        {
                            Id = new Guid("f0ca534e-4bf2-41f6-8720-a964f079f3cf"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1720),
                            VenueName = "Venue2"
                        },
                        new
                        {
                            Id = new Guid("bbd81d4a-5042-4a26-9451-a44d099a35d3"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1740),
                            VenueName = "Venue3"
                        },
                        new
                        {
                            Id = new Guid("44dae368-bf84-4c59-a334-67214fdd54c5"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1750),
                            VenueName = "Venue4"
                        },
                        new
                        {
                            Id = new Guid("ae6b6c4e-9f96-4238-9e40-bf1a34d86d3f"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1760),
                            VenueName = "Venue5"
                        },
                        new
                        {
                            Id = new Guid("fac43fc2-c23b-481d-8a35-bd8af895b7ee"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1780),
                            VenueName = "Venue6"
                        },
                        new
                        {
                            Id = new Guid("47e5c39d-fe80-42e8-bc4a-2c5273c54784"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1790),
                            VenueName = "Venue7"
                        },
                        new
                        {
                            Id = new Guid("27052b7c-585c-4423-bb92-8ae721fecf36"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1800),
                            VenueName = "Venue8"
                        },
                        new
                        {
                            Id = new Guid("9e477352-e487-4148-b0be-195793d497d2"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1810),
                            VenueName = "Venue9"
                        },
                        new
                        {
                            Id = new Guid("d80f47d7-0f14-4360-b776-1362124c96ae"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1820),
                            VenueName = "Venue10"
                        },
                        new
                        {
                            Id = new Guid("d0d37d81-906a-40cd-9bf6-ed141c92966d"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1840),
                            VenueName = "Venue11"
                        },
                        new
                        {
                            Id = new Guid("be959c01-4b40-40e0-b969-c961d1193614"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1850),
                            VenueName = "Venue12"
                        },
                        new
                        {
                            Id = new Guid("8223cb24-26b8-44e9-b5fc-3509a64af6bb"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1860),
                            VenueName = "Venue13"
                        },
                        new
                        {
                            Id = new Guid("df043272-4df0-4bb1-9687-50adfdb9bba5"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1880),
                            VenueName = "Venue14"
                        },
                        new
                        {
                            Id = new Guid("5ec2aa7a-c2d6-4d11-8b63-702d635d2555"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1890),
                            VenueName = "Venue15"
                        },
                        new
                        {
                            Id = new Guid("b1539c49-9eb0-4ab5-9ad0-0ab2e6d92685"),
                            CreateDate = new DateTime(2024, 8, 1, 15, 1, 56, 479, DateTimeKind.Local).AddTicks(1900),
                            VenueName = "Venue16"
                        });
                });

            modelBuilder.Entity("AppointmentEntity", b =>
                {
                    b.HasOne("ActivityTypeEntity", "ActivityType")
                        .WithMany()
                        .HasForeignKey("ActivityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationUserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VenueEntity", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActivityType");

                    b.Navigation("User");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ApplicationUserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ApplicationUserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationUserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ApplicationUserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
