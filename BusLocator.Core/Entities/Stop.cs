namespace BusLocator.Core.Entities
{
    public class Stop
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Longitude { get; set; } = null!;
        public string Latitude { get; set; } = null!;
    }
}