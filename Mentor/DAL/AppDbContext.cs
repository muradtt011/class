using Mentor.Models;
using Microsoft.EntityFrameworkCore;

namespace Mentor.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

      public DbSet<HeroContent > HeroContent { get; set; }

      public DbSet<AboutContent> aboutContents { get; set; }

        public DbSet<AboutListContent> aboutListContents { get; set; }
        public DbSet<IconSection> iconSections { get; set; }
        public DbSet<PopularCategory> popularCategories { get; set; }

        public DbSet<PopularCourse> popularCourse { get; set; }

        public DbSet<Trainers> Trainers { get; set; }

        public DbSet<WhyChooseUs> WhyChooseUs { get; set; }

        public DbSet<Detail>
            

    }
   
}
