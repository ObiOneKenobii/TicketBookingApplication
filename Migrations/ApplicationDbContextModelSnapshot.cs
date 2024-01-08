﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketBookingApplication.Data;

#nullable disable

namespace TicketBookingApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketBookingApplication.Models.AvailableMovies", b =>
                {
                    b.Property<int>("AvailableMoviesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvailableMoviesId"));

                    b.Property<string>("ContentRating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MovieDates")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.HasKey("AvailableMoviesId");

                    b.HasIndex("GenreId");

                    b.ToTable("AvailableMovies");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("VisitorId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.CinemaLocation", b =>
                {
                    b.Property<int>("CinemaLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CinemaLocationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("CinemaLocationId");

                    b.ToTable("CinemaLocation");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId")
                        .IsUnique();

                    b.HasIndex("LocationId")
                        .IsUnique();

                    b.ToTable("City");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Horror"
                        });
                });

            modelBuilder.Entity("TicketBookingApplication.Models.GenreMovies", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("GenreMovies");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("LocationId");

                    b.HasIndex("StateId");

                    b.HasIndex("VisitorId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Movies", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("ContentRating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ContentRating = "Pg",
                            Description = "A short Movie",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "SharkTale"
                        });
                });

            modelBuilder.Entity("TicketBookingApplication.Models.SearchForMoviesByLocation", b =>
                {
                    b.Property<int>("SearchForMoviesByLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SearchForMoviesByLocationId"));

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.HasKey("SearchForMoviesByLocationId");

                    b.HasIndex("GenreId");

                    b.HasIndex("VisitorId");

                    b.ToTable("SearchforMovies");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.HasIndex("CountryId")
                        .IsUnique();

                    b.ToTable("State");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("SelectedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SelectedTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("VisitorId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Visitor", b =>
                {
                    b.Property<int>("VisitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisitorId");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.AvailableMovies", b =>
                {
                    b.HasOne("TicketBookingApplication.Models.Visitor", "Visitors")
                        .WithMany()
                        .HasForeignKey("GenreId");

                    b.Navigation("Visitors");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Cart", b =>
                {
                    b.HasOne("TicketBookingApplication.Models.Visitor", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.City", b =>
                {
                    b.HasOne("TicketBookingApplication.Models.Country", "Country")
                        .WithOne("City")
                        .HasForeignKey("TicketBookingApplication.Models.City", "CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketBookingApplication.Models.Location", "Location")
                        .WithOne("City")
                        .HasForeignKey("TicketBookingApplication.Models.City", "LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.GenreMovies", b =>
                {
                    b.HasOne("TicketBookingApplication.Models.Genre", "Genres")
                        .WithMany("GenreMovies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketBookingApplication.Models.Movies", "Movies")
                        .WithMany("GenreMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Location", b =>
                {
                    b.HasOne("TicketBookingApplication.Models.Country", "Country")
                        .WithOne("Location")
                        .HasForeignKey("TicketBookingApplication.Models.Location", "LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TicketBookingApplication.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.HasOne("TicketBookingApplication.Models.Visitor", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("State");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.SearchForMoviesByLocation", b =>
                {
                    b.HasOne("TicketBookingApplication.Models.Location", "Locations")
                        .WithMany()
                        .HasForeignKey("GenreId");

                    b.HasOne("TicketBookingApplication.Models.Visitor", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locations");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.State", b =>
                {
                    b.HasOne("TicketBookingApplication.Models.Country", "Country")
                        .WithOne("State")
                        .HasForeignKey("TicketBookingApplication.Models.State", "CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketBookingApplication.Models.City", "City")
                        .WithOne("State")
                        .HasForeignKey("TicketBookingApplication.Models.State", "StateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Ticket", b =>
                {
                    b.HasOne("TicketBookingApplication.Models.Visitor", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.City", b =>
                {
                    b.Navigation("State");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Country", b =>
                {
                    b.Navigation("City");

                    b.Navigation("Location");

                    b.Navigation("State");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Genre", b =>
                {
                    b.Navigation("GenreMovies");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Location", b =>
                {
                    b.Navigation("City");
                });

            modelBuilder.Entity("TicketBookingApplication.Models.Movies", b =>
                {
                    b.Navigation("GenreMovies");
                });
#pragma warning restore 612, 618
        }
    }
}
