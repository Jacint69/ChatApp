using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Repository
{
    public class MessageRepository : Repository<Message>, IRepository<Message>
    {

        public MessageRepository(MessageDbContext db) : base(db)
        {
            
        }
        public override Message? Read(int id)
        {
            return this.db.Messages.FirstOrDefault(t=> t.MessageId == id);
        }

        public override void Update(Message item)
        {
            //set olditem object
            var olditem = Read(item.MessageId);

            //prop traverse
            foreach (var prop in item.GetType().GetProperties())
            {
                //set olditem to new item value
                prop.SetValue(olditem, prop.GetValue(item));
            }
        }
    }
}
