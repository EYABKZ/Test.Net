using AM.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    internal class AMContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Appliquer la configuration de Concert
            modelBuilder.ApplyConfiguration(new ConcertConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
