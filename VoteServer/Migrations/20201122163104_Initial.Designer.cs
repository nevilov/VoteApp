﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VoteServer;

namespace VoteServer.Migrations
{
    [DbContext(typeof(VoteDBContext))]
    [Migration("20201122163104_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("VoteServer.VoteInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("DescriptionVoting")
                        .HasColumnType("text");

                    b.Property<DateTime>("End_dateVoting")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Start_dateVoting")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TitleVoting")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VoteInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
