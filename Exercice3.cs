using System;

class Exercice3
{
    public static void Run()
    {
        int a, b;

        Console.Write("Entrez le premier nombre: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Entrez le deuxième nombre: ");
        b = int.Parse(Console.ReadLine());

        int somme = a + b;
        int difference = a - b;
        int produit = a * b;
        int quotient = a / b;

        Console.WriteLine($"Somme: {somme}");
        Console.WriteLine($"Différence: {difference}");
        Console.WriteLine($"Produit: {produit}");
        Console.WriteLine($"Quotient: {quotient}");

        bool test = (a > 0) && (b > 0);
        Console.WriteLine($"test: {test}");
    }
}