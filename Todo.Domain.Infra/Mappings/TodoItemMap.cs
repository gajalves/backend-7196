using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.Domain.Entities;

namespace Todo.Domain.Infra.Mappings
{
    public class TodoItemMap : IEntityTypeConfiguration<TodoItem>
    {
        public void Configure(EntityTypeBuilder<TodoItem> builder)
        {
            builder.ToTable("Todo");
            builder.Property(x => x.Id);
            builder.Property(x => x.User).HasMaxLength(120).HasColumnType("VARCHAR(120)");
            builder.Property(x => x.Title).HasMaxLength(120).HasColumnType("VARCHAR(120)");
            builder.Property(x => x.Done).HasColumnType("bit");
            builder.Property(x => x.Date);
            builder.HasIndex(x => x.User);
        }
    }
}
