﻿// <auto-generated />
using System;
using FavoriteMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FavoriteMovies.Migrations
{
    [DbContext(typeof(HomeContext))]
    partial class HomeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FavoriteMovies.Models.Favorite", b =>
                {
                    b.Property<int>("FavoriteId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MovieId");

                    b.Property<int>("UserId");

                    b.HasKey("FavoriteId");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("FavoriteMovies.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Actor");

                    b.Property<string>("Director");

                    b.Property<int?>("FavoritedByUserId");

                    b.Property<string>("Genre");

                    b.Property<string>("Plot");

                    b.Property<string>("Poster");

                    b.Property<int>("Rating");

                    b.Property<string>("Released");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("MovieId");

                    b.HasIndex("FavoritedByUserId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("FavoriteMovies.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FavoriteMovies.Models.Favorite", b =>
                {
                    b.HasOne("FavoriteMovies.Models.Movie", "Favorited")
                        .WithMany("Favorites")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FavoriteMovies.Models.User", "UserFavorited")
                        .WithMany("myFavorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FavoriteMovies.Models.Movie", b =>
                {
                    b.HasOne("FavoriteMovies.Models.User", "FavoritedBy")
                        .WithMany("myFavoriteMovies")
                        .HasForeignKey("FavoritedByUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
