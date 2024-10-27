namespace WebApi
{
    public class EventServer
    {
        
        public List<Event> Events { get; set; }
        public EventServer()
        {
           
            Events = new List<Event>();
            Events.Add(new Event(1, "first", new DateTime(2024, 08, 12), new DateTime(2024, 08, 16)));
            Events.Add(new Event(2, "second", new DateTime(2024, 09, 01), new DateTime(2024, 09, 01)));
            Events.Add(new Event(3, "third", new DateTime(2024, 08, 20)));
        }
        public List<Event> GetEvents()
        {
            return Events;
        }

        public bool PostEvents(Event e)
        {
            Events.Add(e);
            return true;
        }
        public void PutEvents(int id,Event e)
        {
            int index = Events.FindIndex(ev => ev.Id == id);
            if(index!=-1)
            {
                Events[index]=e;
            }
            
        }
        public void DeleteEvents(int id)
        {
            Event del = Events.Find(e => e.Id == id);
            if(del!=null)
            Events.Remove(del);
        }
    }
}
