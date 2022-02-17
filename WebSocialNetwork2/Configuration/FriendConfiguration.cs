using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSocialNetwork2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebSocialNetwork2.Configuration
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {

        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.ToTable("UserFriends").HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
