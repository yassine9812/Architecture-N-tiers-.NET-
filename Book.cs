public class Book
{
    private int id;
    private string title;
    private string author;
    private double price;

    public int Id
    {
        get {return id;}
        set {id=value;}
    }

    public string Title
    {
        get {return title;}
        set{title=value;}
    }

    public string Author
    {
        get{return author;}
        set{author=value;}
    }

    public double Price
    {
        get {return price;}
        set {price=value;}
    }

    public Book(int id, string title, string author, double price)
    {
        this.id=id;
        this.title=title;
        this.author=author;
        this.price=price;
    }

    public void Display()
    {
        Console.WriteLine("Id:"+id);
        Console.WriteLine("Title:"+title);
        Console.WriteLine("Author:"+author);
        Console.WriteLine("Price:"+price);
    }
}