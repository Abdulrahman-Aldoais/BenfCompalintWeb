using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Configuration;
using BenfCompalintWeb.Models.Benef;
using BenfCompalintWeb.Models.CompalintInformation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
namespace BenfCompalintWeb.Models
{
    public class AppCompalintsContextDB : IdentityDbContext<ApplicationUser>
    {
        public AppCompalintsContextDB(DbContextOptions<AppCompalintsContextDB> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppCompalintsContextDB).Assembly);


            //modelBuilder.ApplyConfiguration(new DirectorateConfiguration());
            //modelBuilder.ApplyConfiguration(new GeneralFederationConfiguration());
            //modelBuilder.ApplyConfiguration(new GovernorateConfiguration());
            //modelBuilder.ApplyConfiguration(new SocietyConfiguration());
            //modelBuilder.ApplyConfiguration(new StagesComplaintConfiguration());
            //modelBuilder.ApplyConfiguration(new SubDirectorateConfiguration());
            //modelBuilder.ApplyConfiguration(new TypeComplaintConfiguration());
            //modelBuilder.ApplyConfiguration(new VillagesConfiguration());

            modelBuilder.HasDefaultSchema("Identity");
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");

            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });



            modelBuilder.Entity<Compalint>().Property(i=>i.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<BenefCommunication>().Property(i=>i.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Beneficiarie>().Property(i=>i.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Proposal>().Property(i=>i.Id).HasDefaultValueSql("NEWID()");
            //modelBuilder.Entity<TypeComplaint>().Property(i=>i.Id).HasDefaultValueSql("NEWID()");
            //modelBuilder.Entity<StatusCompalint>().Property(i=>i.Id).HasDefaultValueSql("NEWID()");
            //modelBuilder.Entity<StagesComplaint>().Property(i=>i.Id).HasDefaultValueSql("NEWID()");




        }


        public DbSet<TypeComplaint> TypeComplaints { get; set; }
        //public DbSet<TypeBeneficiari> TypeBeneficiaris { get; set; }
        public DbSet<Beneficiarie> Beneficiaries { get; set; }
        public DbSet<Compalint> Compalints { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<Directorate> Directorates { get; set; }
        public DbSet<SubDirectorate> SubDirectorates { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<LimitationOrder> LimitationOrders { get; set; }
        public DbSet<UsersCommunication> UsersCommunications { get; set; }
        public DbSet<Compalints_Solution> Compalints_Solutions { get; set; }
        public DbSet<Society> Societys { get; set; }
        public DbSet<StagesComplaint> StagesComplaints { get; set; }
        public DbSet<StatusCompalint> StatusCompalints { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        //public DbSet<TypeCommunication> TypeCommunications { get; set; }






    }

}
