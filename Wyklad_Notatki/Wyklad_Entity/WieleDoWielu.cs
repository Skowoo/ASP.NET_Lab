namespace Wyklad_Notatki.ZwiążkiDbEncji
{
    public class FirstObject
    {
        public ICollection<SecondObject> SecondObjects { get; set; }
    }

    public class SecondObject
    {
        public ICollection <FirstObject> FirstObjects { get;}
    }
}
