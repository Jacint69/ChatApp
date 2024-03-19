using ChatApp.Models;

namespace ChatApp.Logic
{
    public interface IMessageLogic
    {
        void Create(Message item);
        void Delete(int id);
        Message Read(int id);
        IQueryable<Message> ReadAll();
        void Update(Message item);
    }
}