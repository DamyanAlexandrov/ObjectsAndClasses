namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                string[] input = Console.ReadLine().Split();

                student.FirstName = input[0];
                student.LastName = input[1];
                student.Grade = double.Parse(input[2]);

                listOfStudents.Add(student);
            }

            foreach (var m in listOfStudents.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{m.FirstName} {m.LastName}: {m.Grade:f2}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
