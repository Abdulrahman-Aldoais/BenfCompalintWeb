using BenfCompalintWeb.Const;
using BenfCompalintWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenfCompalintWeb.Configuration
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                 new IdentityRole
                 {
                     Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                     Name = UserRoles.AdminGeneralFederation,
                     NormalizedName = UserRoles.AdminGeneralFederation.ToUpper(),
                 },
                 new IdentityRole
                 {
                     Id = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                     Name = UserRoles.AdminGovernorate,
                     NormalizedName = UserRoles.AdminGovernorate.ToUpper()
                 }
                 ,
                 new IdentityRole
                 {
                     Id = "cbc43a8e-f7bb-4445-baaf-1wdd431ffbbf",
                     Name = UserRoles.AdminDirectorate,
                     NormalizedName = UserRoles.AdminDirectorate.ToUpper()
                 },
                 new IdentityRole
                 {
                     Id = "cbc43a8e-f7bb-4445-baaf-1rdd431ffbbf",
                     Name = UserRoles.AdminSubDirectorate,
                     NormalizedName = UserRoles.AdminSubDirectorate.ToUpper()
                 },
                 new IdentityRole
                 {
                     Id = "cbc43a8e-f7bb-1445-baaf-1rdd431ffbbf",
                     Name = UserRoles.AdminVillages,
                     NormalizedName = UserRoles.AdminVillages.ToUpper()
                 }
               
            );
        }
    }
}