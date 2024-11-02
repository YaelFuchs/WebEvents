using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public static List<Event> Events = new List<Event>();
        public EventController() {

            Event e1 = new Event(123, "wedding", new DateTime(2024, 10, 11), new DateTime(2024, 10, 12));
            Event e2 = new Event(421, "bar_mitzva", new DateTime(2024, 10, 25), new DateTime(2024, 10, 26));
            Event e3 = new Event(716, "party", new DateTime(2024, 10, 19), new DateTime(2024, 10, 21));

            Events.Add(e1);
            Events.Add(e2);
            Events.Add(e3);
}



        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return Events;
        }

      

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event e )
        {
             int id = e.Id;
             e.Id = id;
             Events.Add(e);

        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event change)
        {
            Event temp = new Event();
            foreach(Event e in Events)
            {
                if(e.Id == id)
                {
                    temp=e;
                    break;
                }
            }
            if (change.Title != null)
            {
                temp.Title = change.Title;
            }
            if(change.end != null)
            {
                temp.end = change.end;
            }
            if (change.start != null)
            {
                temp.start = change.start;
            }
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
