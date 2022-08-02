using BenfCompalintWeb.Models.CompalintInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BenfCompalintWeb.Configuration
{
    public class TypeComplaintConfiguration : IEntityTypeConfiguration<TypeComplaint>
    {
        public void Configure(EntityTypeBuilder<TypeComplaint> builder)
        {
            builder.HasData(
                    new TypeComplaint
                    {
                        Id = 1,
                        Type = "زراعية",
                    },
                    new TypeComplaint
                    {
                        Id = 2,
                        Type = "فساد",
                    },
                     new TypeComplaint
                     {
                         Id = 3,
                         Type = "مماطلة",
                     },
                      new TypeComplaint
                      {
                          Id = 4,
                          Type = "إرتشاء",
                      }
                ); ;
        }

       
    }

}
