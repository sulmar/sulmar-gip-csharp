namespace Models
{
    public abstract class Base
    {
        public int Id { get; set; }
    }

    public class Person : Base
    {
        public string FirstName { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime Date { get; set; }
    }

}