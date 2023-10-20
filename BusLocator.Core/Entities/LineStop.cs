namespace BusLocator.Core.Entities
{
    public class LineStop
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public int LineId { get; set; }
        public int StopId { get; set; }
        public Line? Line { get; set; }
        public Stop? Stop { get; set; }
    }
}
