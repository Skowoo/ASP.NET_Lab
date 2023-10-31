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

        [DataType(DataType.EmailAddress, ErrorMessage = "Nieprawidłowy format e-mail")]
        [Required(ErrorMessage = "Email jest wymagany!")]
        [MinLength(8, ErrorMessage = "Email za krótki!")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Hasło jest wymagane!")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", 
            ErrorMessage = "Hasło musi składać się z minimum 8 znaków, " +
            "w tym co najmniej jedna cyfra, jedna duża litera i jedna mała litera)")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane!")]
        [Compare("Password", ErrorMessage = "Podane hasła nie są jednakowe!")]
        public string ConfirmPassword { get; set; }

        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{3}", 
            ErrorMessage = "Prawidłowy format numeru telefonu to: 123-456-789")]
        public string? TelephoneNumber { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek poza zakresem 10 - 80")]
        public int? Age { get; set; }

        public string? City { get; set; }

        public enum Cities { Kraków = 0, Warszawa = 1, Wrocław = 2, Opole = 3, Gniezno = 4 }
    }
}
