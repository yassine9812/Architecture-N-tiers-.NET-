class Exercice5
{
    public static void Run()
    {
        //Boucle For
        for (int i = 1; i <= 5; i++)
            Console.WriteLine($"Iteration {i}");
        int compteur = 1;

        //Boucle While
        while (compteur <= 5)
        {
            Console.WriteLine($"Compteur: {compteur}");
            compteur++;
        }

        //Boucle Do While

        int n;
        do
        {
            Console.WriteLine("Entrez un nombre positif");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);
        Console.WriteLine($"Vous avez daisi: {n}");
    }

}