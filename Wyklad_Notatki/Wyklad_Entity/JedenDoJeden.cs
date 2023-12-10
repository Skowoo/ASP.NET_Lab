namespace Wyklad_Notatki.ZwiążkiDbEncji
{
    public class User
    {
        public int UserId { get; set; }
        public Car Car { get; set; } //FK
    }

    public class Car
    {
        public int CarId { get; set; }
        public User User { get; set; } //FK
        public int UserId { get; set; } //FK
    }
}
