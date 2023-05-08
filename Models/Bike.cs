using System.ComponentModel.DataAnnotations;

namespace BikeRentalCompany0.Models
{
    public class Bike
    {
        [Key]
        public int IdRoweru { get; set; }
        [Required]
        [Display(Name = "Nazwa Roweru")]
        public string NazwaRoweru { get; set; }

        [Range(1, 100, ErrorMessage = "Rozmiar koła w przedziale 1-100!")]
        [Display(Name = "Rozmiar Koła")]
        public int RozmiarKola { get; set; }
    }
}
