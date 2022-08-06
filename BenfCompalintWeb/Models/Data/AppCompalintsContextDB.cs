using BenfCompalintWeb.Areas.UsersService.Model;
using BenfCompalintWeb.Models.CompalintInformation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BenfCompalintWeb.Models
{
    public class AppCompalintsContextDB : IdentityDbContext<
        ApplicationUser,
        ApplicationRole, string,
        IdentityUserClaim<string>,
        ApplicationUserRole,
        IdentityUserLogin<string>,
        IdentityRoleClaim<string>,
        IdentityUserToken<string>>


    //IdentityDbContext<
    //ApplicationUser, ApplicationRole, Guid,
    //IdentityUserClaim<Guid>, ApplicationUserRole, IdentityUserLogin<Guid>,
    //IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public AppCompalintsContextDB(DbContextOptions<AppCompalintsContextDB> options) 
            : base(options)
        {

        }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            //modelBuilder.Ignore<IdentityUserLogin<string>>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppCompalintsContextDB).Assembly);

            //modelBuilder.ApplyConfiguration(new DirectorateConfiguration());
            //modelBuilder.ApplyConfiguration(new GeneralFederationConfiguration());
            //modelBuilder.ApplyConfiguration(new GovernorateConfiguration());
            //modelBuilder.ApplyConfiguration(new SocietyConfiguration());
            //modelBuilder.ApplyConfiguration(new StagesComplaintConfiguration());
            //modelBuilder.ApplyConfiguration(new SubDirectorateConfiguration());
            //modelBuilder.ApplyConfiguration(new TypeComplaintConfiguration());
            //modelBuilder.ApplyConfiguration(new VillagesConfiguration());
            //modelBuilder.Ignore<IdentityUserLogin<string>>();


            modelBuilder.Entity<ApplicationUser>(b =>
            {
                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne()
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne()
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne()
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

                b.HasMany(e => e.CompalintHasSolo)
                   .WithOne(e => e.HoUser)
                  
                   .IsRequired();
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                // Each Role can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
            });

            modelBuilder.Entity<IdentityUser>(b =>
            {
                b.Property(u => u.UserName).HasMaxLength(128);
                b.Property(u => u.NormalizedUserName).HasMaxLength(128);
                b.Property(u => u.Email).HasMaxLength(128);
                b.Property(u => u.NormalizedEmail).HasMaxLength(128);
            });

            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.Property(t => t.LoginProvider).HasMaxLength(128);
                b.Property(t => t.Name).HasMaxLength(128);
            });
            #pragma warning restore 

            modelBuilder.Entity<IdentityUser>(b =>
            {
                b.Property(e => e.Email).HasColumnName("EMail");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.Property(e => e.ClaimType).HasColumnName("CType");
                b.Property(e => e.ClaimValue).HasColumnName("CValue");
            });

            modelBuilder.HasDefaultSchema("Identity");
            modelBuilder.Entity<IdentityUser>(entity =>
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

            base.OnModelCreating(modelBuilder);


        }


        public DbSet<TypeComplaint> TypeComplaints { get; set; }
        //public DbSet<TypeBeneficiari> TypeBeneficiaris { get; set; }
        public DbSet<Beneficiarie> Beneficiaries { get; set; }
        public DbSet<Compalint> Compalints { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Permission> Permissions { get; set; }
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
