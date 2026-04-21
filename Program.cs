class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Choose exercise:");
            Console.WriteLine("1 - Exercice1");
            Console.WriteLine("2 - Exercice2");
            Console.WriteLine("3 - Exercice3");
            Console.WriteLine("4 - Exercice4");
            Console.WriteLine("5 - Exercice5");
            Console.WriteLine("6 - Exercice6");

            string choice = Console.ReadLine();

            if (choice == "1")
                Exercice1.Run();
            else if (choice == "2")
                Exercice2.Run();
            else if (choice == "3")
                Exercice3.Run();
            else if (choice == "4")
                Exercice4.Run();
            else if (choice =="5")
                Exercice5.Run();
            else if (choice=="6")
                Exercice6.Run();
        }
    }
}