using BusLocator.Common.Resources.Strings;
using System.ComponentModel.DataAnnotations;

namespace BusLocator.Common.DataTransferObjects
{
    public class LineUpdateDto
    {
        [Required(ErrorMessageResourceName = nameof(Strings.NumberRequired), ErrorMessageResourceType = typeof(Strings))]
        public string? Number { get; set; }
        [Required(ErrorMessageResourceName = nameof(Strings.NameRequired), ErrorMessageResourceType = typeof(Strings))]
        public string? Name { get; set; }
        [Required(ErrorMessageResourceName = nameof(Strings.DurationRequired), ErrorMessageResourceType = typeof(Strings))]
        public int? Duration { get; set; }
        [Required(ErrorMessageResourceName = nameof(Strings.PriceRequired), ErrorMessageResourceType = typeof(Strings))]
        public decimal? Price { get; set; }
    }
}
