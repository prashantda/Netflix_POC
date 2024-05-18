﻿// <auto-generated />
using System;
using Bfl.Netflix.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bfl.Netflix.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230213164200_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Cast", b =>
                {
                    b.Property<Guid>("CastId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("CastId");

                    b.ToTable("Casts", (string)null);

                    b.HasData(
                        new
                        {
                            CastId = new Guid("95cad04c-bb57-40e3-8ed8-6fd1ac3e81ce"),
                            CastName = "Aamir Khan"
                        },
                        new
                        {
                            CastId = new Guid("8c2c6d0d-6063-4b11-ac65-bbdcb3e58719"),
                            CastName = "Akshay Kumar"
                        },
                        new
                        {
                            CastId = new Guid("98f024b8-3b31-43c7-b6f9-17a486e88b3d"),
                            CastName = "Ajay Devgn"
                        },
                        new
                        {
                            CastId = new Guid("8c5cf78e-58c3-437a-9bbf-0b446a419f51"),
                            CastName = "Amjad Khan"
                        },
                        new
                        {
                            CastId = new Guid("5404c987-6146-453c-9611-5f85119b74c7"),
                            CastName = "Amitabh Bachchan"
                        },
                        new
                        {
                            CastId = new Guid("107ca531-68f0-4b34-a6ff-efd0d12d0110"),
                            CastName = "Amol Palekar"
                        },
                        new
                        {
                            CastId = new Guid("64e9cafa-a883-4719-abff-f6c530ec9ede"),
                            CastName = "Akshaye Khanna"
                        },
                        new
                        {
                            CastId = new Guid("0432031c-79dd-49e0-a3f7-59221fef55a7"),
                            CastName = "Anushka Shetty"
                        },
                        new
                        {
                            CastId = new Guid("f70a5658-9d2c-4746-a22c-98322c14e16c"),
                            CastName = "Ayushmann Khurrana"
                        },
                        new
                        {
                            CastId = new Guid("23cee9a2-b0e5-44ad-892c-9c3184322ab0"),
                            CastName = "Anil Kapoor"
                        },
                        new
                        {
                            CastId = new Guid("2af3e4e3-32c1-4b5d-8555-7aaf7054c13e"),
                            CastName = "Deepika Padukone"
                        },
                        new
                        {
                            CastId = new Guid("f6fa91d4-777c-439f-8350-da1b15938c98"),
                            CastName = "Madhuri Dixit"
                        },
                        new
                        {
                            CastId = new Guid("1268244c-fb2c-4ee6-b25c-e89e08e23950"),
                            CastName = "Madhubala"
                        },
                        new
                        {
                            CastId = new Guid("15b0a214-e36f-4101-b911-83e16a9dfcdd"),
                            CastName = "Rajkummar Rao"
                        },
                        new
                        {
                            CastId = new Guid("a5ff9ba3-b615-43d4-af0e-5a13d2605f81"),
                            CastName = "Tabu"
                        },
                        new
                        {
                            CastId = new Guid("195f3652-c390-4705-9f75-d88ce27dacaf"),
                            CastName = "Tapasi Pannu"
                        },
                        new
                        {
                            CastId = new Guid("4c774386-0b7f-432e-8a6f-44f2f84aac73"),
                            CastName = "Samantha Prabhu"
                        },
                        new
                        {
                            CastId = new Guid("48114c9e-e646-4dd7-98ae-06e2d0f82829"),
                            CastName = "Sai Pallavi"
                        },
                        new
                        {
                            CastId = new Guid("c5435d6a-eb1c-43b5-8eae-b0f4a0f0661a"),
                            CastName = "Shradhaa Kapoor"
                        },
                        new
                        {
                            CastId = new Guid("72eba14e-4cb5-4862-8c79-f844966e39d3"),
                            CastName = "Ranvir Kapoor"
                        },
                        new
                        {
                            CastId = new Guid("207cc525-5a71-4a2c-b317-f757d8a49753"),
                            CastName = "Aliya Bhatt"
                        },
                        new
                        {
                            CastId = new Guid("57c94d5c-55bd-4452-88d6-6ea9b05123ec"),
                            CastName = "Kiaara Adavani"
                        },
                        new
                        {
                            CastId = new Guid("5abbb589-ed12-42aa-b6a4-78b32d562a14"),
                            CastName = "Sushant Sing Rajpoot"
                        },
                        new
                        {
                            CastId = new Guid("479f8f66-2cb5-499e-8509-daf98918bec8"),
                            CastName = "ABC"
                        });
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("c03bbe45-9aeb-4d24-99e0-4743016ffce9"),
                            CategoryName = "Award Winners"
                        },
                        new
                        {
                            CategoryId = new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"),
                            CategoryName = "Biographical"
                        },
                        new
                        {
                            CategoryId = new Guid("c3abddbd-cf50-41d2-b6c4-cc7d5a750928"),
                            CategoryName = "Blockbusters"
                        },
                        new
                        {
                            CategoryId = new Guid("c6d50a47-f7e6-4482-8be0-4ddfc057fa6e"),
                            CategoryName = "Bollywood"
                        },
                        new
                        {
                            CategoryId = new Guid("d15c6d9f-70b4-48c5-afd3-e71261f1a9be"),
                            CategoryName = "Kids and Family"
                        },
                        new
                        {
                            CategoryId = new Guid("89e5f445-d89f-4e12-94e0-5ad5b235d704"),
                            CategoryName = "Comedies"
                        },
                        new
                        {
                            CategoryId = new Guid("2a6d3738-9def-43ac-9279-0310edc7ceca"),
                            CategoryName = "Documentries"
                        },
                        new
                        {
                            CategoryId = new Guid("29339209-63f5-492f-8459-754943c74abf"),
                            CategoryName = "Dramas"
                        },
                        new
                        {
                            CategoryId = new Guid("ac660a73-b0b7-4340-abc1-a914257a6189"),
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = new Guid("012107df-862f-4f16-ba94-e5c16886f005"),
                            CategoryName = "Hollywood"
                        },
                        new
                        {
                            CategoryId = new Guid("cb035f22-e7cf-4907-bd07-91cfee5240f3"),
                            CategoryName = "Horrer"
                        },
                        new
                        {
                            CategoryId = new Guid("28d11936-9466-4a4b-b9c5-2f0a8e0cbde9"),
                            CategoryName = "International"
                        },
                        new
                        {
                            CategoryId = new Guid("a3b9833b-8a4d-43e9-8690-61e08df81a9a"),
                            CategoryName = "Musicals"
                        },
                        new
                        {
                            CategoryId = new Guid("501c6d13-1bbe-48f1-4fbd-2275913c6216"),
                            CategoryName = "Reality"
                        },
                        new
                        {
                            CategoryId = new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"),
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"),
                            CategoryName = "Sci-Fi"
                        },
                        new
                        {
                            CategoryId = new Guid("12e15727-d369-49a9-8b13-bc22e9362179"),
                            CategoryName = "Stand-Up"
                        },
                        new
                        {
                            CategoryId = new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"),
                            CategoryName = "Thrillers"
                        });
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Episode", b =>
                {
                    b.Property<Guid>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TvShowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VideoPath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("TvShowId");

                    b.ToTable("Episodes", (string)null);
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Movie", b =>
                {
                    b.Property<Guid>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ChapterNo")
                        .HasColumnType("int");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies", (string)null);
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Relationships.MovieCast", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CastId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CastId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieCast");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Relationships.MovieCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieCategory");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Relationships.TvShowCast", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CastId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TvShowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CastId");

                    b.HasIndex("TvShowId");

                    b.ToTable("TvShowCast");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Relationships.TvShowCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TvShowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TvShowId");

                    b.ToTable("TvShowCategory");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.TvShow", b =>
                {
                    b.Property<Guid>("TvShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatorName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Seasons")
                        .HasColumnType("int");

                    b.Property<string>("TrailerPath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("TvShowName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("TvShowId");

                    b.ToTable("TvShows", (string)null);
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Episode", b =>
                {
                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.TvShow", "TvShows")
                        .WithMany("Episodes")
                        .HasForeignKey("TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TvShows");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Relationships.MovieCast", b =>
                {
                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.Cast", "Cast")
                        .WithMany("MovieCasts")
                        .HasForeignKey("CastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.Movie", "Movie")
                        .WithMany("MovieCasts")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cast");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Relationships.MovieCategory", b =>
                {
                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.Category", "Category")
                        .WithMany("MovieCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.Movie", "Movie")
                        .WithMany("MovieCategories")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Relationships.TvShowCast", b =>
                {
                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.Cast", "Cast")
                        .WithMany("TvShowCasts")
                        .HasForeignKey("CastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.TvShow", "TvShow")
                        .WithMany("TvShowCasts")
                        .HasForeignKey("TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cast");

                    b.Navigation("TvShow");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Relationships.TvShowCategory", b =>
                {
                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.Category", "Category")
                        .WithMany("TvShowCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.TvShow", "TvShow")
                        .WithMany("TvShowCategories")
                        .HasForeignKey("TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("TvShow");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Cast", b =>
                {
                    b.Navigation("MovieCasts");

                    b.Navigation("TvShowCasts");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Category", b =>
                {
                    b.Navigation("MovieCategories");

                    b.Navigation("TvShowCategories");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.Movie", b =>
                {
                    b.Navigation("MovieCasts");

                    b.Navigation("MovieCategories");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.TvShow", b =>
                {
                    b.Navigation("Episodes");

                    b.Navigation("TvShowCasts");

                    b.Navigation("TvShowCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
