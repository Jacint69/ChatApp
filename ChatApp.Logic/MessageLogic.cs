using ChatApp.Logic.Exceptions;
using ChatApp.Models;
using ChatApp.Repository;

namespace ChatApp.Logic
{
    public class MessageLogic : IMessageLogic
    {

        IRepository<Message> repository;
        public MessageLogic(IRepository<Message> repository)
        {
            this.repository = repository;
        }
        public void Create(Message item)
        {
            if (item.SentMessage.Length < 1)
            {
                throw new LengthExceptions();
            }
            else
            {
                repository.Create(item);
            }
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public Message Read(int id)
        {
            return repository.Read(id);
        }

        public IQueryable<Message> ReadAll()
        {
            return repository.ReadAll();
        }

        public void Update(Message item)
        {
            repository.Update(item);
        }
    }
}
