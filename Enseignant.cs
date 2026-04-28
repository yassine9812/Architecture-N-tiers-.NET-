using System;
public class Enseignant : Person
{
    public string grade { get; set; }
    public double salaire { get; set; }

    //Constructeur
    public Enseignant(string grade, double salaire, string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        this.grade = grade;
        this.salaire = salaire;
    }

    //Methode
    public void AfficherInfoEnseignant()
    {
        Console.WriteLine($"Grade: {grade}, Salaire: {salaire}, Nom Complet: {firstName} {lastName}, Age: {age} ans");
    }
}


