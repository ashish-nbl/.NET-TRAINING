namespace BasicApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public int Standard { get; set; }
        public string State { get; set; } = string.Empty;
    }
}
