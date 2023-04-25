namespace ModelMapping.App.Component
{
    public class Channel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Channel() { }
        public Channel(string name, string description) { Name = name; Description = description; }
    }
}