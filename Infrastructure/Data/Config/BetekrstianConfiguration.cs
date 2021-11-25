using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Config
{
    public class BetekrstianConfiguration : IEntityTypeConfiguration<Betekrstian>
    {
        public void Configure(EntityTypeBuilder<Betekrstian> builder)
        {
            throw new NotImplementedException();
        }
    }
}