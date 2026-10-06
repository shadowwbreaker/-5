namespace Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }
        public string Email { get; set; }

        public Student(int id, string name, string group, int course, string email)
        {
            Id = id;
            Name = name;
            Group = group;
            Course = course;
            Email = email;
        }

        public string GetInfo()
        {
            return $"ID: {Id}, Name: {Name}, Group: {Group}, Course: {Course}, Email: {Email}";
        }
    }
}