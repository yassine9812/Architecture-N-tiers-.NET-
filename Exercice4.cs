class Exercice4
{
    public static void Run()
    {
        int note;

        Console.Write("Entrez la note (0 à 20): ");
        note = int.Parse(Console.ReadLine()!);

        while (note < 0 || note > 20)
        {
            Console.Write("Note invalide. Entrez une note entre 0 et 20: ");
            note = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine($"Note valide: {note}");

        if (note >= 16)
        {
            Console.WriteLine("Tres bien");
        }
        else if (note >= 12)
        {
            Console.WriteLine("Bien");
        }
        else if (note >= 10)
        {
            Console.WriteLine("Passable");
        }
        else
        {
            Console.WriteLine("Insuffisant");
        }
    }
}