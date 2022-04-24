namespace ConsoleAppObjectsAndClasses
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public bool IsMale { get; set; }
        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }
}
