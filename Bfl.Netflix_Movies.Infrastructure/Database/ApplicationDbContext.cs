
using Bfl.Netflix.Core.Configurations;
using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.Entities.Relationships;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Bfl.Netflix.Infrastructure.Database
{
   
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,Guid>
    {
        public ApplicationDbContext(DbContextOptions options):base(options)  
        {
           
        }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<TvShow> Series { get; set; }//Property name can be used to access table in our  code
        public  virtual DbSet<Cast> Casts { get; set; }
        public virtual DbSet<Episode> Episodes { get; set; }
        public virtual DbSet<MovieCast> MovieCasts { get; set; }
        public virtual DbSet<MovieCategory> MoviesCategories { get; set; }  
        public virtual DbSet<TvShowCast> TvShowCasts { get; set; }
        public virtual DbSet<TvShowCategory> TvShowCategories { get; set; } 
        public virtual DbSet<OneTimePassword> OneTimePasswords { get; set; }

        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.Entity<Category>().ToTable("Categories");
                string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(),Configuration.CategoriesPath));
                string CategorysJason = System.IO.File.ReadAllText(path);//Reading data as json

                List<Category>? categories = System.Text.Json.JsonSerializer.Deserialize<List<Category>>(CategorysJason);//Getting list from read string
                foreach (Category category in categories)
                    modelBuilder.Entity<Category>().HasData(category);


                modelBuilder.Entity<Cast>().ToTable("Casts");
                modelBuilder.ApplyConfiguration(new CastsConfiguration());

                //
                modelBuilder.Entity<Movie>().ToTable("Movies");//toTable  gives name to table
                modelBuilder.Entity<TvShow>().ToTable("TvShows")
                    .Ignore(t => t.Duration)//Entity will not make column for Duration property
                    .Ignore(t => t.VideoPath);

                modelBuilder.Entity<Episode>().ToTable("Episodes").
                    Ignore(t => t.TrailerPath)
                    .Ignore(t => t.CreatorName);

                modelBuilder.Entity<ApplicationRole>().HasData(
                    new ApplicationRole() { Id = Guid.Parse("77AAAF947E334E6E972A77E4EC793F04"), Name = "Admin", NormalizedName = "ADMINISTRATOR" },
                    new ApplicationRole() { Id = Guid.Parse("74E20FEA171F4D34928540298C018CCA"), Name = "Customer", NormalizedName = "CUSTOMER" },
                     new ApplicationRole() { Id = Guid.Parse("FB574BAB813B4CDEB7E8C8188A51803E"), Name = "Basic", NormalizedName = "BASIC" },
                      new ApplicationRole() { Id = Guid.Parse("0313B58093D94677B4F25924509B63B0"), Name = "Gold", NormalizedName = "GOLD" },
                       new ApplicationRole() { Id = Guid.Parse("E72BFDB8F3D646E99989E740583A53BC"), Name = "Platinum", NormalizedName = "PLATINUM" }
                    );

                modelBuilder.Entity<IdentityUserLogin<Guid>>()
                    .HasKey(l => new { l.LoginProvider, l.ProviderKey });
                modelBuilder.Entity<IdentityUserRole<Guid>>()
                .HasKey(r => new { r.UserId, r.RoleId });

                modelBuilder.Entity<IdentityUserToken<Guid>>()
                    .HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

            }
            catch (Exception ex)
            {
                throw;
            }

        }


    }
}
