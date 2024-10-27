using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
      static readonly EventServer eventServer = new EventServer();

      

        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return eventServer.GetEvents();
        }

        

        // POST api/<EventController>
        [HttpPost]
        public bool Post([FromBody] Event e)
        {
           eventServer.PostEvents(e);
            return true;
        }

        // PUT api/<EventController>/5
        [HttpPut("{Id}")]
        public void Put(int id, [FromBody] Event e)
        {
            eventServer.PutEvents(id,e);
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{Id}")]
        public void Delete(int id)
        {
            eventServer.DeleteEvents(id);
        }
    }
}
