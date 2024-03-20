using ChatApp.Logic;
using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChatApp.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IMessageLogic logic;
        public MessageController(IMessageLogic messageLogic)
        {
            logic= messageLogic;
        }
        // GET: api/<MessageController>
        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return logic.ReadAll();
        }

        // GET api/<MessageController>/5
        [HttpGet("{id}")]
        public Message Get(int id)
        {
            return logic.Read(id);
        }

        // POST api/<MessageController>
        [HttpPost]
        public void Post([FromBody] Message value)
        {
            logic.Create(value);
        }

        // PUT api/<MessageController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Message value)
        {
            logic.Update(value);
        }

        // DELETE api/<MessageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            logic.Delete(id);
        }
    }
}
