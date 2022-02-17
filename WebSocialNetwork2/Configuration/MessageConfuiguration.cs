using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSocialNetwork2.Models;

namespace WebSocialNetwork2.Configuration
{
    public class MessageConfuiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Mesages").HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
