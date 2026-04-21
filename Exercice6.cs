class Exercice6
{
    public static void Run()
    {
        Console.WriteLine("Entrez un nombre");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }

        int somme = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                somme = somme + i;
            }
        }
        Console.WriteLine($"La somme entre 1 et 100 est: {somme}");


        Console.WriteLine("Doneez la taille du triangle");
        int SommeTriangle = int.Parse(Console.ReadLine());

        for (int i = 1; i <= SommeTriangle; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        string ch;
        do
        {
        Console.WriteLine("Saisie une mot de passe de longueur de minimum de 6");
        ch = Console.ReadLine();
        } while (ch.Length < 6);
        Console.WriteLine("Password est validee");


    }
}