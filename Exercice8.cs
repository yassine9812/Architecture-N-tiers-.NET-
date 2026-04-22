class Exercice8
{
    public static void Run()
    {
        Console.WriteLine("Entrez un nombre entier:");
        int n = int.Parse(Console.ReadLine());

        TraiterNombre(n); 
    }

    // Afficher le nombre en utilisant les différentes méthodes
    static void TraiterNombre(int n)
    {
        if (EstPair(n))
        {
            Console.WriteLine($"{n} est un nombre pair.");
        }
        else
        {
            Console.WriteLine($"{n} est un nombre impair.");
        }

        if (EstPremier(n))
        {
            Console.WriteLine($"{n} est un nombre premier.");
        }
        else
        {
            Console.WriteLine($"{n} n'est pas un nombre premier.");
        }

        Console.WriteLine($"La factorielle de {n} est: {Factorielle(n)}");
        Console.WriteLine($"Les {n} premiers nombres de Fibonacci sont: {string.Join(", ", GenererFibonacci(n))}");
        AfficherTableau(GenererFibonacci(n));
    }

    // Méthodes pour les différentes opérations
    static bool EstPair(int n) => n % 2 == 0;

    // Vérifie si un nombre est premier
    static bool EstPremier(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    // Calcule la factorielle d'un nombre
    static int Factorielle(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    // Génère les n premiers nombres de Fibonacci
    static int[] GenererFibonacci(int n)
    {
        int[] fib = new int[n];
        if (n > 0) fib[0] = 0;
        if (n > 1) fib[1] = 1;

        for (int i = 2; i < n; i++)
            fib[i] = fib[i - 1] + fib[i - 2];

        return fib;
    }

    // Affiche les éléments d'un tableau
    static void AfficherTableau(int[] tableau)
    {
        foreach (int val in tableau)
            Console.Write(val + " ");
        Console.WriteLine();
    }
}