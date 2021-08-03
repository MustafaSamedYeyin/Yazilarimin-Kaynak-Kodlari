using HashAspMoq.Core.Entties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAspMoq.Data.EntityFrameworkCore.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User()
            {
                Id = 1,
                Age = 24,
                Country = "Turkey",
                Name = "Mustafa"
            });

            builder.HasData(new User()
            {
                Id = 2,
                Age = 27,
                Country = "Turkey",
                Name = "Ömer"
            });

            builder.HasData(new User()
            {
                Id = 3,
                Age = 20,
                Country = "Turkey",
                Name = "Mehmet"
            });
        }
    }
}
