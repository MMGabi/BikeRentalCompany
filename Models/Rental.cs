using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRentalCompany0.Models
{
    public class Rental
    {
        [Key]
        public int IdWynajmu { get; set; }

        [Required]
        [Display(Name = "Data wynajmu roweru")]
        public DateTime DataOd { get; set; } = DateTime.Now;

        [Required]
        [Range(1, 30, ErrorMessage = "Możesz wypożyczyć na maksymalnie 30 dni!")]
        public int IloscDni { get; set; }

        public int IdKlienta { get; set; }

        [Required]
        [ForeignKey("IdKlienta")]
        public virtual Client Client { get; set; }

        public int IdRoweru { get; set; }

        [Required]
        [ForeignKey("IdRoweru")]
        public virtual Bike Rower { get; set; }

        public int IdPracownika { get; set; }

        [Required]
        [ForeignKey("IdPracownika")]
        public virtual Worker Pracownik { get; set; }
    }
}
