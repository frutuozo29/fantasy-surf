using Fantasy_Surf.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Fantasy_Surf.Infra.Data.EntityConfig
{
    public class RegrasFantasyConfiguration : EntityTypeConfiguration<RegrasFantasy>
    {
        public RegrasFantasyConfiguration()
        {
            HasKey(r => r.RegrasFantasyId);

            Property(r => r.Descricao)
                .IsRequired()
                .HasMaxLength(2000);
        }
    }
}
