using ACU.Portals.Apply.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace ACU.Portals.Apply.Data {

    public class ApplyDbContext : AbpDbContext<ApplyDbContext>
    {
        public ApplyDbContext(DbContextOptions<ApplyDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureOpenIddict();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();
           
        }
        /* Configure your own entities here */
        public DbSet<AcademicDetails> AcademicDetails { get; set; }
        public DbSet<AddressDetails> AddressDetails { get; set; }
        public DbSet<ApplicationUpload> ApplicationUpload { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CountryState> CountryState { get; set; }
        public DbSet<ExtraStudentDetails> ExtraStudentDetails { get; set; }
        public DbSet<LGA> LGA { get; set; }
        public DbSet<Religion> Religion { get; set; }
        public DbSet<StudentApplication> StudentApplication { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }
    }
}

