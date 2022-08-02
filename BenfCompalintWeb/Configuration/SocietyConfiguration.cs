using BenfCompalintWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BenfCompalintWeb.Configuration
{
    public class SocietyConfiguration : IEntityTypeConfiguration<Society>
    {
        public void Configure(EntityTypeBuilder<Society> builder)
        {
            builder.HasData(
                    new Society
                    {
                        Id = 1,
                        Name = "جمعية البن",
                    },
                    new Society
                    {
                        Id = 2,
                        Name = "جمعية الالبان",
                    },
                     new Society
                     {
                         Id = 3,
                         Name = "جمعية الحبوب",
                     }
                );
        }


    }

}