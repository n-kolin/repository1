namespace WebApi
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Event(int id, string title, DateTime start, DateTime end)
        {
            this.Id = id;
            this.Title = title;
            this.Start = start;
            this.End = end;
        }
        public Event(int id, string title, DateTime start)
        {
            this.Id = id;
            this.Title = title;
            this.Start = start;
            this.End = start;
        }

        public Event()
        {
        }
    }
}
