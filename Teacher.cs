public class Teacher : Person
{
    private string subject;

    private double salary;

    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }
    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public Teacher(int id, string fullName, string email, string subject, double salary) : base(id, fullName, email)
    {
        this.subject = subject;

        this.salary = salary;
    }

    public override string GetRole()
    {
        return "Teacher";
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine("------------------------------");
    }
}