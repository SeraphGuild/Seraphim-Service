﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seraphim.Storage;

#nullable disable

namespace Seraphim.Migrations
{
    [DbContext(typeof(SeraphimContext))]
    [Migration("20211225080154_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Seraphim.Model.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Seraphim.Model.Team", b =>
                {
                    b.OwnsMany("Seraphim.Model.TeamMember", "Members", b1 =>
                        {
                            b1.Property<int>("TeamId")
                                .HasColumnType("int")
                                .HasColumnOrder(1);

                            b1.Property<long>("DiscordId")
                                .HasColumnType("bigint")
                                .HasColumnOrder(0);

                            b1.Property<int>("Rank")
                                .HasColumnType("int");

                            b1.HasKey("TeamId", "DiscordId");

                            b1.ToTable("TeamMember");

                            b1.WithOwner("Team")
                                .HasForeignKey("TeamId");

                            b1.Navigation("Team");
                        });

                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
