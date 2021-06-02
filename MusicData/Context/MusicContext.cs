#region Usings

using Microsoft.EntityFrameworkCore;
using MusicData.Models;
using Microsoft.Extensions.Logging;
using Serilog;

#endregion

namespace MusicData.Context
{
    public class MusicContext : DbContext
    {
        #region Constructor

        public MusicContext(DbContextOptions<MusicContext>options)
            :base(options)
        {

        }

        #endregion

        #region Public Members

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Sound> Sound { get; set; }

        #endregion

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql(_connectionString);
            optionsBuilder.UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddSerilog(); }));
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => new { e.Id });
                entity.ToTable("user");
            });

            modelBuilder.Entity<Sound>(entity =>
            {
                entity.HasKey(e => new { e.Id });
                //entity.Property(e => e.FileSize("Size"));
                entity.ToTable("audiodata");
            });
        }

        #endregion
    }
}
