using PracticeInterfaces_IEnumerable;

class Program
{
    static void Main(string[] args)
    {
        SchoolClass schoolClass = new SchoolClass("Math");

        string[] names = {
            "Alice", "Bob", "Charlie", "David", "Emma", "Frank", "Grace", "Henry", "Isabella", "Jack",
            "Kate", "Liam", "Mia", "Noah", "Olivia", "Parker", "Quinn", "Ryan", "Sophia", "Thomas"
        };

        foreach (string name in names)
        {
            Student student = new Student(name);
            schoolClass.AddStudent(student);
        }

        Console.WriteLine($"Class Name: {schoolClass.Name}");

        foreach (Student student in schoolClass)
        {
            Console.WriteLine(student);
        }
    }
}