class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        Student s1 = new Student(
        1,
        "Ali Ben Salah",
        "ali@student.com",
        "L3",
        new List<double> { 12, 15, 14 }
        );
        Student s2 = new Student(
        2,
        "Sara Trabelsi",
        "sara@student.com",
        "M1",
        new List<double> { 16, 18, 17 }
        );
        Teacher t1 = new Teacher(
        3,
        "Mohamed Khaled",
        "khaled@teacher.com",
        "Computer Science",
        2500
        );
        people.Add(s1);
        people.Add(s2);
        people.Add(t1);
        // � Polymorphism
        foreach (Person p in people)
        {
            p.DisplayInfo();
        }
        Console.ReadKey();
    }
}
