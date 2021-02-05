using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hahn.ApplicatonProcess.December2020.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
// using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hahn.ApplicatonProcess.December2020.Data
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Applicant> Applicants { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Applicant>().HasKey(e => e.Id);
            builder.Entity<Applicant>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();
        }


        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Applicant.db");
    }
}
