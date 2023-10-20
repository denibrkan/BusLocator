namespace BusLocator.Core.Entities
{
    public class Line
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public ICollection<LineStop> LineStops { get; set; } = new List<LineStop>();
    }
}