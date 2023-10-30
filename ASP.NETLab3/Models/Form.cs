using System.ComponentModel.DataAnnotations;

namespace ASP.NETLab3.Models
{
    public class Form
    {
        [Required(ErrorMessage = "Imie jest wymagane!")]
        [MinLength(2, ErrorMessage = "Imie za krótkie!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane!")]
        [MinLength(2, ErrorMessage = "Nazwisko za krótkie!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email jest wymagany!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Nieprawidłowy format e-mail")]
        [MinLength(8)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane!")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Hasło za krótkie!")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Podane hasła nie są jednakowe!")]
        [Required(ErrorMessage = "Hasło jest wymagane!")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Hasło za krótkie!")]
        public string ConfirmPassword { get; set; }

        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{3}", ErrorMessage = "Prawidłowy format numeru telefonu to: 123-456-789")]
        public string? TelephoneNumber { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek poza zakresem 10 - 80")]
        public int? Age { get; set; }

        public string? City { get; set; }

        public enum Cities { Kraków = 0, Warszawa = 1, Wrocław = 2, Opole = 3, Gniezno = 4 }
    }
}
