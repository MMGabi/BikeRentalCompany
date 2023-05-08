using System.ComponentModel.DataAnnotations;

namespace BikeRentalCompany0.Models
{
    public class Client
    {

        [Key]
        public int IdKlienta { get; set; }
        [Required]

        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        [Required]
        [Range(100000000, 999999999, ErrorMessage = "Podaj poprawny numer telefonu")]
        [Display(Name = "Numer Telefonu")]
        public double NrTelefonu { get; set; }
        public string Email { get; set; }

        public Client()
        {

        }
        public Client(string imie, string nazwisko, double nrTelefonu, string email) : base()
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NrTelefonu = nrTelefonu;
            Email = email;
        }
    }
}
