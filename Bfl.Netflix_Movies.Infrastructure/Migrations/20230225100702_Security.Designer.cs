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
    [Migration("20230225100702_Security")]
    partial class Security
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("77aaaf94-7e33-4e6e-972a-77e4ec793f04"),
                            ConcurrencyStamp = "f060093a-a95d-4cb9-9361-935e04c5bc95",
                            Name = "Admin",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("74e20fea-171f-4d34-9285-40298c018cca"),
                            ConcurrencyStamp = "97b22826-5a36-4cb0-ac52-c140e6161b64",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = new Guid("fb574bab-813b-4cde-b7e8-c8188a51803e"),
                            ConcurrencyStamp = "48a64228-6c16-4f7d-b0ee-19b10d1aad22",
                            Name = "Basic",
                            NormalizedName = "BASIC"
                        },
                        new
                        {
                            Id = new Guid("0313b580-93d9-4677-b4f2-5924509b63b0"),
                            ConcurrencyStamp = "06b09a99-ff15-40ec-889e-8f17dff5ad0e",
                            Name = "Gold",
                            NormalizedName = "GOLD"
                        },
                        new
                        {
                            Id = new Guid("e72bfdb8-f3d6-46e9-9989-e740583a53bc"),
                            ConcurrencyStamp = "1e956e0c-ea26-49bb-9b07-d0488d0fa5c6",
                            Name = "Platinum",
                            NormalizedName = "PLATINUM"
                        });
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(63)
                        .HasColumnType("nvarchar(63)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subscription")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

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
                            CastId = new Guid("352cc882-d63b-471d-9308-c8375caf6566"),
                            CastName = "Aamir Khan"
                        },
                        new
                        {
                            CastId = new Guid("31f99d1f-aa25-4376-a7bb-c021e99958b0"),
                            CastName = "Akshay Kumar"
                        },
                        new
                        {
                            CastId = new Guid("4efc401e-eb6b-43bc-87b9-96f381715d1e"),
                            CastName = "Ajay Devgn"
                        },
                        new
                        {
                            CastId = new Guid("9052d29d-948e-4baa-82b6-1a12526d2d35"),
                            CastName = "Amjad Khan"
                        },
                        new
                        {
                            CastId = new Guid("9ebb0c1e-4a78-4b5a-8940-8f5300c1a25e"),
                            CastName = "Amitabh Bachchan"
                        },
                        new
                        {
                            CastId = new Guid("c8260d12-63bc-4707-8563-24bf16ae6f60"),
                            CastName = "Amol Palekar"
                        },
                        new
                        {
                            CastId = new Guid("33a4e89f-3547-4223-a45d-6cb900f65a9e"),
                            CastName = "Akshaye Khanna"
                        },
                        new
                        {
                            CastId = new Guid("fc57061c-6292-4b2c-9d42-6e4a87dd9c07"),
                            CastName = "Anushka Shetty"
                        },
                        new
                        {
                            CastId = new Guid("b9949ec7-d655-4d0a-a891-cd0e9fd116df"),
                            CastName = "Ayushmann Khurrana"
                        },
                        new
                        {
                            CastId = new Guid("fb63a20a-bb55-4b40-904e-e8aa9ea672b0"),
                            CastName = "Anil Kapoor"
                        },
                        new
                        {
                            CastId = new Guid("ca52b5e6-85a0-422b-923e-4aa087eeb576"),
                            CastName = "Deepika Padukone"
                        },
                        new
                        {
                            CastId = new Guid("ff41b25f-a757-4685-a425-dc5d33bb13ef"),
                            CastName = "Madhuri Dixit"
                        },
                        new
                        {
                            CastId = new Guid("403d62c2-58c6-4c08-b38a-9fa599e6250c"),
                            CastName = "Madhubala"
                        },
                        new
                        {
                            CastId = new Guid("f4592808-ae0c-4e08-8415-ec17cb4d4d60"),
                            CastName = "Rajkummar Rao"
                        },
                        new
                        {
                            CastId = new Guid("0cb222ba-e9b8-4997-83ce-71141d2b5f1f"),
                            CastName = "Tabu"
                        },
                        new
                        {
                            CastId = new Guid("29b60896-727c-4ff1-8ddb-19014e181223"),
                            CastName = "Tapasi Pannu"
                        },
                        new
                        {
                            CastId = new Guid("c5e657fa-7ab4-43d6-81fc-0c6741ded8df"),
                            CastName = "Samantha Prabhu"
                        },
                        new
                        {
                            CastId = new Guid("696506fe-bac4-4f32-bd7a-499f843a35e3"),
                            CastName = "Sai Pallavi"
                        },
                        new
                        {
                            CastId = new Guid("cf6cfd48-5771-4f8a-bec9-fd7292d6b58a"),
                            CastName = "Shradhaa Kapoor"
                        },
                        new
                        {
                            CastId = new Guid("cd9b8a00-dca7-4964-bfc2-d985e8683cd8"),
                            CastName = "Ranvir Kapoor"
                        },
                        new
                        {
                            CastId = new Guid("78a77634-af3a-4af6-8367-19e1d1219162"),
                            CastName = "Aliya Bhatt"
                        },
                        new
                        {
                            CastId = new Guid("70a73fde-2154-430a-86c3-cdb9d1c78301"),
                            CastName = "Kiaara Adavani"
                        },
                        new
                        {
                            CastId = new Guid("b999020b-9c8c-49a3-812b-c503b5789437"),
                            CastName = "Sushant Sing Rajpoot"
                        },
                        new
                        {
                            CastId = new Guid("7d75f962-6701-4be2-a7c7-43667d14750a"),
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

                    b.Property<string>("Access")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Access")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChapterNo")
                        .HasColumnType("int");

                    b.Property<string>("CreatorName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrailerPath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("VideoPath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

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

                    b.ToTable("MovieCats");
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

                    b.ToTable("MovieCategories");
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

                    b.ToTable("TvShowCasts");
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

                    b.ToTable("TvShowCategories");
                });

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.TvShow", b =>
                {
                    b.Property<Guid>("TvShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Access")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
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
                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.Cast", "Casts")
                        .WithMany("MovieCasts")
                        .HasForeignKey("CastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.Movie", "Movie")
                        .WithMany("MovieCasts")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Casts");

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
