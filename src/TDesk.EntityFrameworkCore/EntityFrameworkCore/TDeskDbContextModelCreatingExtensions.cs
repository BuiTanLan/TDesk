using Microsoft.EntityFrameworkCore;
using TDesk.Conversations;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace TDesk.EntityFrameworkCore
{
    public static class TDeskDbContextModelCreatingExtensions
    {
        public static void ConfigureTDesk(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Conversation>(b =>
            {
                b.ToTable(TDeskConsts.DbTablePrefix + "Conversations",
                          TDeskConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Messages).IsRequired().HasMaxLength(128);
            });
        }
    }
}