namespace Wyklad_Notatki.ZwiążkiDbEncji
{
    public class DeptUser
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public int DepartmentId { get; set; } //FK
        public Department Department { get; set; } //FK
    }
    
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users { get; set; } //FK
    }
}
