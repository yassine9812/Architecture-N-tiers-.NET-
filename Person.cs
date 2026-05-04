public abstract class Person
{

    private int id;
    private string fullName;
    private string email;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }


    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public Person (int id, string fullNamen, string email)
    {
        this.id=id;
        this.fullName=fullNamen;
        this.email=email;
    }
    
    public abstract string GetRole();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Email: {email}");
    }
}