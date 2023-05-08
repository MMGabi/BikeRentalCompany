using System.ComponentModel.DataAnnotations;

namespace BikeRentalCompany0.Models
{
    public class Worker
    {
        [Key]
        public int IdPracownika { get; set; }
        [Required]
        [Display(Name = "Imię")]
        public string Imie { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string Nazwisko { get; set; }
        [Required]
        [Range(100000000, 999999999, ErrorMessage = "Podaj poprawny numer telefonu")]
        [Display(Name = "Numer Telefonu")]
        public double NrTelefonu { get; set; }
    }
}
