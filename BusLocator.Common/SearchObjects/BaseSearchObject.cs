namespace BusLocator.Common.SearchObjects
{
    public class BaseSearchObject
    {
        public int PageSize { get; set; } = 10;
        public int Page { get; set; } = 1;
        public string? OrderBy { get; set; }
        public bool OrderAsc { get; set; } = true;
        public string? SearchText { get; set; }
    }
}
