class Exercice1
{
    public static void Run()
    {
        Console.WriteLine("Hello, World!");

        //LES TYPES PRIMITIFS
        int age = 25;
        bool estActif = true;
        char lettere = 'A';
        string nom = "Alice";
        Console.WriteLine("LES TYPES PRIMITIFS");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Est actif: {estActif}");
        Console.WriteLine($"Lettre: {lettere}");
        Console.WriteLine($"Nom: {nom}");

        //INTERFACE DE TYPE AVEC VAR
        var annee=2025;
        var message= "Bonjour";
        Console.WriteLine("INTERFACE DE TYPE AVEC VAR");
        Console.WriteLine($"Année: {annee}");
        Console.WriteLine($"Message: {message}");

        //CONSTATNTE
        const double PI = 3.14159;
        Console.WriteLine($"La valeur de PI est: {PI}");

        Console.Write("Entrez votre nom: ");
        string prenom=Console.ReadLine();

        Console.Write("Entrez votre Age; ");
        int agee = int.Parse(Console.ReadLine());

        Console.WriteLine($"Bonjour {prenom}, vous avez {agee} ans.");
    }
}