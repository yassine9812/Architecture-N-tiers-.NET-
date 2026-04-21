class Exercice7
{
    public static void Run()
    {
        double[] notes = new double[5];
        double moy = 0;

        for (int i = 0; i < notes.Length; i++)
        {
            Console.WriteLine("Entrez un nombre");
            notes[i] = double.Parse(Console.ReadLine());
            moy += notes[i];
        }
        moy /= notes.Length;
        Console.WriteLine($"La moyenne est: {moy}");

        double max = notes[0];
        double min = notes[0];

        for (int i = 1; i < notes.Length; i++)
        {
            if (notes[i] > max)
                max = notes[i];
            if (notes[i] < min)
                min = notes[i];
        }

        Console.WriteLine($"La note maximale est: {max}");
        Console.WriteLine($"La note minimale est: {min}");

        Array.Sort(notes);
        Console.WriteLine("Les notes triées sont:");
        foreach (double note in notes)
        {
            Console.WriteLine(note);
        }

    }
}
