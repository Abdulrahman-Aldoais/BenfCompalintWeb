using BenfCompalintWeb.Models.CompalintInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BenfCompalintWeb.Configuration
{
    public class StatusCompalintConfiguration : IEntityTypeConfiguration<StatusCompalint>
    {
        public void Configure(EntityTypeBuilder<StatusCompalint> builder)
        {
            builder.HasData(
                    new StatusCompalint
                    {
                        Id =1,
                        Name = "جديدة",
                    },
                    new StatusCompalint
                    {
                        Id = 2,
                        Name = "محلولة",
                    },

                      new StatusCompalint
                      {
                          Id = 3,
                          Name = "مرفوضة",
                      },
                       new StatusCompalint
                       {
                           Id = 4,
                           Name = "معلقة",
                       }
                );
        }


    }

}