class Program
{
    static void Main(string[] args)
    {
        //Création d'un enseignant
        Enseignant enseignant1 = new Enseignant("Professeur", 5000.0, "John", "Doe", 40);

        Etudiant etudiant1 = new Etudiant("Alice", "Smith", 20, "MAT123", 15.5);
        //Affichage des informations de l'enseignant
        Console.WriteLine("Informations de l'enseignant:");
        enseignant1.AfficherInfoEnseignant();
        //Affichage des informations de l'étudiant
        Console.WriteLine("\nInformations de l'étudiant:");
        etudiant1.AfficherInfoEtudiant();
    }
}