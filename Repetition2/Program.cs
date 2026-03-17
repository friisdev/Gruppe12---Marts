namespace Repetition2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Alice", 20);
            Student student2 = new Student("Bo", 23);
			Student student3 = new Student("Bob", 25);


			Course course1 = new Course("Matematik");

            course1.AddStudent(student1);
            course1.AddStudent(student2);
			course1.AddStudent(student3);

			Console.WriteLine("Alle studerende:\n");

			course1.PrintStudents();
            Console.WriteLine("Alle studerende over 22 år:\n");
            course1.PrintStudentsByAge(22);

            Console.ReadLine();
        }
    }
}
