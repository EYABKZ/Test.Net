using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamesp


namespace AM.Infrastructure.Configuration
{
    public class ConcertConfiguration : IEntityTypeConfiguration<Concert>
    {
    
          public void Configure(EntityTypeBuilder<Concert> builder)
        {
            // Définir la clé primaire
            builder.HasKey(c => c.ConcertId);

            // Configurer la clé étrangère ArtisteFk
            builder.HasOne(c => c.Artiste)
                   .WithMany(a => a.Concerts) // Un artiste peut avoir plusieurs concerts
                   .HasForeignKey(c => c.ArtisteFk)
                   .OnDelete(DeleteBehavior.Restrict); // Pas de suppression en cascade

            // Configurer la clé étrangère FestivalFk
            builder.HasOne(c => c.Festival)
                   .WithMany(f => f.Concerts) // Un festival peut avoir plusieurs concerts
                   .HasForeignKey(c => c.FestivalFk)
                   .OnDelete(DeleteBehavior.Restrict); // Pas de suppression en cascade
        }
    }
}
}
