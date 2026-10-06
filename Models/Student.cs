namespace Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }

        public Student(int id, string name, string group, int course)
        {
            Id = id;
            Name = name;
            Group = group;
            Course = course;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Group: {Group}, Course: {Course}");
        }
    }
}