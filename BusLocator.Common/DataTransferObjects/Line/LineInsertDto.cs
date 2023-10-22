using System.ComponentModel.DataAnnotations;

namespace BusLocator.Common.DataTransferObjects
{
    public class LineInsertDto
    {
        [Required(ErrorMessage = "Broj je obavezno polje")]
        public string? Number { get; set; }
        [Required(ErrorMessage = "Naziv je obavezno polje")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Trajanje je obavezno polje")]
        public int? Duration { get; set; }
        [Required(ErrorMessage = "Cijena je obavezno polje")]
        public decimal? Price { get; set; }
    }
}