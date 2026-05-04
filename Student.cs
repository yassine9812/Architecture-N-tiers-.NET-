public class Student : Person, IEvaluable
{
    private string level;
    private List<double> grades;

    public string Level
    {
        get { return level; }
    }

    public List<double> Grades
    {
        get { return grades; }
    }

    public Student(int id, string fullName, string email, string level, List<double> grades) : base(id, fullName, email)
    {
        this.level = level;
        this.grades = grades;
    }
    public override string GetRole()
    {
        return "Student";
    }

    public double CalculAverage()
    {
        return grades.Count > 0 ? grades.Average() : 0.0;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Grades: {string.Join(", ", grades)}");
        Console.WriteLine("------------------------------");
    }
}