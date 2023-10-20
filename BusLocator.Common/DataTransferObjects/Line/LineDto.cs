namespace BusLocator.Common.DataTransferObjects
{
    public class LineDto
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public decimal Price { get; set; }
    }
}
