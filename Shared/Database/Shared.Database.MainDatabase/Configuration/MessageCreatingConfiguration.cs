using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectC.SharedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Database.MainDatabase.Configuration
{
    public class MessageCreatingConfiguration :

       IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder <Message> builder)
        {
            builder.ToTable("main_messages");
            builder.HasKey(o => o.UniqId);
           
            builder.Property(x => x.Body)
                .HasColumnName("message_body")
                .HasMaxLength(1024);


            //builder.Property(x => x.AuthorID)
            //    .Has(); -- понять как добавить внешний ключ
            builder
                .HasOne(x => x.Producer)
                .WithMany(x => x.Message)
                .HasForeignKey(x => x.AuthorID);
        }
    }
}
