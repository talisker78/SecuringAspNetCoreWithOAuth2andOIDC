﻿// <auto-generated />
using System;
using Marvin.IDP.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Marvin.IDP.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20240627193616_AddAccountActivation")]
    partial class AddAccountActivation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Marvin.IDP.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityCode")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SecurityCodeExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Subject")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Active = true,
                            ConcurrencyStamp = "56d1b2db-8886-4b65-9be4-87db83b0a9f2",
                            Email = "david@someprider.com",
                            Password = "password",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                            UserName = "David"
                        },
                        new
                        {
                            Id = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Active = true,
                            ConcurrencyStamp = "a67844af-483a-429a-8f8c-0d4a629897e9",
                            Email = "emma@someprovider.com",
                            Password = "password",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                            UserName = "Emma"
                        });
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c07b1756-bee5-4166-a87f-e09b53522d02"),
                            ConcurrencyStamp = "402cbc91-0f01-4073-a0f0-1b0c05dff94f",
                            Type = "given_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "David"
                        },
                        new
                        {
                            Id = new Guid("73861394-62fb-42c2-a95a-582136aa2e43"),
                            ConcurrencyStamp = "19b0b3f7-6e5b-4789-bff3-b989df7c63b2",
                            Type = "family_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Flagg"
                        },
                        new
                        {
                            Id = new Guid("c719e2ca-ded8-409c-85a2-f760cdc4b777"),
                            ConcurrencyStamp = "3187f58d-9e04-4884-9a76-1c4398e8ec8f",
                            Type = "country",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "nl"
                        },
                        new
                        {
                            Id = new Guid("ff496d98-cc5e-4978-bb1e-8f3ea48844dd"),
                            ConcurrencyStamp = "e2bf69dc-090b-492c-973e-fa774b84ca0e",
                            Type = "role",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "FreeUser"
                        },
                        new
                        {
                            Id = new Guid("139d3240-8fb6-4f6f-a20e-17896f03a874"),
                            ConcurrencyStamp = "aea9abd9-cd73-4802-bb3c-5630acb73ec7",
                            Type = "given_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Emma"
                        },
                        new
                        {
                            Id = new Guid("1020515b-91f3-4c4d-ac30-481a2ef97c8e"),
                            ConcurrencyStamp = "c6e1577f-8484-40cb-b809-7db1575cb808",
                            Type = "family_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Flagg"
                        },
                        new
                        {
                            Id = new Guid("096b1607-747e-46eb-8633-52d3ffcdd095"),
                            ConcurrencyStamp = "40349312-d963-4f80-b7c0-b19c283efd7f",
                            Type = "country",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "be"
                        },
                        new
                        {
                            Id = new Guid("c36aa4b0-27eb-46b2-a0f7-c2db67cf32ae"),
                            ConcurrencyStamp = "daf565cd-1f34-4457-8833-5b2018af00f9",
                            Type = "role",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "PayingUser"
                        });
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserClaim", b =>
                {
                    b.HasOne("Marvin.IDP.Entities.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Marvin.IDP.Entities.User", b =>
                {
                    b.Navigation("Claims");
                });
#pragma warning restore 612, 618
        }
    }
}
