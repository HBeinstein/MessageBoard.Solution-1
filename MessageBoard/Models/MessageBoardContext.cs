using System;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
      : base(options)
      {
      }

      public DbSet<Message> Messages { get; set; }
      public DbSet<Group> Groups { get; set; }
      public DbSet<GroupMessage> GroupMessages { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Message>()
        .HasData(
          new Message { MessageId = 1, Title = "Hello", Body = "Hello? Hello???", Date = new DateTime(2020, 08, 16), UserName = "Test1"},
          new Message { MessageId = 2, Title = "Goodbye", Body = "I don't know why you say goodbye I say hello.", Date = DateTime.Today, UserName = "Test2"},
          new Message { MessageId = 3, Title = "This is only a test", Body = "This is a test of the emergency alert system.", Date = DateTime.Today, UserName = "Test3"},
          new Message { MessageId = 4, Title = "If this was a real alert", Body = "You would be dead. Probably, who knows. If you saw a flash, most likely.", Date = DateTime.Today, UserName = "Test4"},
          new Message { MessageId = 5, Title = "My Second Message", Body = "I couldn't stay away", Date = new DateTime(2020, 08, 18), UserName = "Test2"}
        );
      }
  }
}