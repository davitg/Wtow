﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Wtow.Data;

namespace Wtow.Data.Migrations
{
    [DbContext(typeof(TitleContext))]
    [Migration("20180413050147_DateTimeAreNullable")]
    partial class DateTimeAreNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wtow.Domain.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Source");

                    b.Property<int?>("TitleId");

                    b.Property<string>("Value");

                    b.HasKey("RatingId");

                    b.HasIndex("TitleId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Wtow.Domain.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Actors");

                    b.Property<string>("Awards");

                    b.Property<string>("BoxOffice");

                    b.Property<string>("Country");

                    b.Property<DateTime?>("DVD");

                    b.Property<string>("Director");

                    b.Property<string>("Genre");

                    b.Property<string>("Language");

                    b.Property<float>("Metascore");

                    b.Property<string>("Name");

                    b.Property<string>("Plot");

                    b.Property<string>("Poster");

                    b.Property<string>("Production");

                    b.Property<string>("Rated");

                    b.Property<DateTime?>("Released");

                    b.Property<string>("Response");

                    b.Property<string>("Runtime");

                    b.Property<int>("TitleType");

                    b.Property<string>("Website");

                    b.Property<string>("Writer");

                    b.Property<int>("Year");

                    b.Property<string>("imdbID");

                    b.Property<float>("imdbRating");

                    b.Property<string>("imdbVotes");

                    b.HasKey("TitleId");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("Wtow.Domain.Rating", b =>
                {
                    b.HasOne("Wtow.Domain.Title")
                        .WithMany("Ratings")
                        .HasForeignKey("TitleId");
                });
#pragma warning restore 612, 618
        }
    }
}