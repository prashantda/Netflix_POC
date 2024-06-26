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
    [Migration("20230301114320_Security1")]
    partial class Security1
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
                            ConcurrencyStamp = "db060741-1331-428d-99ba-749339705502",
                            Name = "Admin",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("74e20fea-171f-4d34-9285-40298c018cca"),
                            ConcurrencyStamp = "156a3795-e5d5-4477-a2be-4ce96b758803",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = new Guid("fb574bab-813b-4cde-b7e8-c8188a51803e"),
                            ConcurrencyStamp = "4df6dd2f-e09d-4472-b407-d19b7fed065f",
                            Name = "Basic",
                            NormalizedName = "BASIC"
                        },
                        new
                        {
                            Id = new Guid("0313b580-93d9-4677-b4f2-5924509b63b0"),
                            ConcurrencyStamp = "e47f07a6-3682-41ca-bdd7-7df29b3c41c0",
                            Name = "Gold",
                            NormalizedName = "GOLD"
                        },
                        new
                        {
                            Id = new Guid("e72bfdb8-f3d6-46e9-9989-e740583a53bc"),
                            ConcurrencyStamp = "7041891f-1a01-496f-86ee-c04f8b02f500",
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
                            CastId = new Guid("04a5e4cb-29d8-4591-addb-35abfc8180eb"),
                            CastName = "Aamir Khan"
                        },
                        new
                        {
                            CastId = new Guid("330e305f-0206-474f-bde4-5c29220afe7f"),
                            CastName = "Akshay Kumar"
                        },
                        new
                        {
                            CastId = new Guid("e1cae9d9-84e6-4015-9e1a-8ea4e6ee4fa0"),
                            CastName = "Ajay Devgn"
                        },
                        new
                        {
                            CastId = new Guid("ce8fe4da-36ce-434f-b5cb-bacfe5cd9d2a"),
                            CastName = "Amjad Khan"
                        },
                        new
                        {
                            CastId = new Guid("5527a5d8-cd18-4d93-bdbe-1ac579341349"),
                            CastName = "Amitabh Bachchan"
                        },
                        new
                        {
                            CastId = new Guid("0f04858b-ca53-4b3e-983a-72f16b4ea6df"),
                            CastName = "Amol Palekar"
                        },
                        new
                        {
                            CastId = new Guid("4e125c1a-9d33-40b9-a685-57d1faf169fe"),
                            CastName = "Akshaye Khanna"
                        },
                        new
                        {
                            CastId = new Guid("ac97c19d-41b8-47c5-9b7b-7fe659d8f376"),
                            CastName = "Anushka Shetty"
                        },
                        new
                        {
                            CastId = new Guid("3fa19adb-ab45-404c-83dc-f060b26404c3"),
                            CastName = "Ayushmann Khurrana"
                        },
                        new
                        {
                            CastId = new Guid("38a60f8b-7a3b-443d-9fa5-e533006106b1"),
                            CastName = "Anil Kapoor"
                        },
                        new
                        {
                            CastId = new Guid("9b3a80fc-32c2-4692-a93e-c3fcc67bbf90"),
                            CastName = "Deepika Padukone"
                        },
                        new
                        {
                            CastId = new Guid("afcbe3ef-4fee-4d7b-90e8-f0a702b6319b"),
                            CastName = "Madhuri Dixit"
                        },
                        new
                        {
                            CastId = new Guid("56467188-93fd-4a09-a754-b456da250cc9"),
                            CastName = "Madhubala"
                        },
                        new
                        {
                            CastId = new Guid("ac74290d-f661-45b2-9913-9e5c38b9b5f4"),
                            CastName = "Rajkummar Rao"
                        },
                        new
                        {
                            CastId = new Guid("c93f2acc-da24-4041-93fc-67e1bc0bf07e"),
                            CastName = "Tabu"
                        },
                        new
                        {
                            CastId = new Guid("ba223128-130f-4fac-978e-220ce5117a1d"),
                            CastName = "Tapasi Pannu"
                        },
                        new
                        {
                            CastId = new Guid("e928d312-970b-4d72-9a0a-e781b46e20fd"),
                            CastName = "Samantha Prabhu"
                        },
                        new
                        {
                            CastId = new Guid("111b3f52-9032-4ab5-8212-12fb852c3f49"),
                            CastName = "Sai Pallavi"
                        },
                        new
                        {
                            CastId = new Guid("c317c924-69c8-42ad-9aa5-bcd0770a01a2"),
                            CastName = "Shradhaa Kapoor"
                        },
                        new
                        {
                            CastId = new Guid("ef022dfd-6ae5-4b8d-8f58-9f761c6b070c"),
                            CastName = "Ranvir Kapoor"
                        },
                        new
                        {
                            CastId = new Guid("cc61c7b1-96a3-46d6-b517-58e20010cc72"),
                            CastName = "Aliya Bhatt"
                        },
                        new
                        {
                            CastId = new Guid("52e09145-0bd0-40f0-b02f-3a92560c1132"),
                            CastName = "Kiaara Adavani"
                        },
                        new
                        {
                            CastId = new Guid("78f4e48d-8f52-49be-8170-97a51c433bae"),
                            CastName = "Sushant Sing Rajpoot"
                        },
                        new
                        {
                            CastId = new Guid("245b95d4-4e83-45f5-a9c4-3273d975f402"),
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

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.OneTimePassword", b =>
                {
                    b.Property<Guid>("TempUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OTP")
                        .HasColumnType("int");

                    b.HasKey("TempUserId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("OTP");
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

            modelBuilder.Entity("Bfl.Netflix.Core.Domain.Entities.OneTimePassword", b =>
                {
                    b.HasOne("Bfl.Netflix.Core.Domain.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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
