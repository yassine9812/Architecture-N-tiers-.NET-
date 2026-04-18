using System;

class Exercice2
{
    public static void Run()
    {
        string nom;
        int age;

        Console.Write("Entrez votre nom: ");
        nom = Console.ReadLine();

        Console.Write("Entrez votre âge: ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine($"nom: {nom} et age: {age}");
    }
}