using ChatApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Repository
{
    public class MessageDbContext : DbContext
    {

        public DbSet<Message> Messages {  get; set; }

        public MessageDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var dummyDatas = new List<Message>()
            {
                new Message() {MessageId=1, Name="TestName", SentMessage="TestMessage"}
            };
            modelBuilder.Entity<Message>().HasData(dummyDatas);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("MessageDB");
            }
        }


    }
}
