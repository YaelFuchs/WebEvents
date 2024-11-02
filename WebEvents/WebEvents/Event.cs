namespace WebEvents
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }

        public Event(int id, string title, DateTime start, DateTime end)
        {
            Id = id;
            Title = title;
            this.start = start;
            this.end = end;
        }
        public Event() { }
    }
}
