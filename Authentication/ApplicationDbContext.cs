using _41505212__API.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using _41505212__API.Models;



namespace JWTAuthentication.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // Add this DbSet property for the JobTelemetry table
        //public DbSet<JobTelemetry> JobTelemetry { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // You can add additional model configurations here if needed
            //builder.Entity<JobTelemetry>().ToTable("JobTelemetry", "Telemetry");
        }
    }

}
