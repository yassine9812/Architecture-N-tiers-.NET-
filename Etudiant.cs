using System;
public class Etudiant : Person
{
    public string matricule { get; set; }
    public double moyenne { get; set; }

    //Constructeur
    public Etudiant(string firstName, string lastName, int age, string matricule, double moyenne) : base(firstName, lastName, age)
    {
        this.matricule = matricule;
        this.moyenne = moyenne;
    }

    //Getters et Setters
    public string LastName
    {
        get { return lastName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.lastName = value;
            }
        }
    }

    //Methode
    public void AfficherInfoEtudiant()
    {
        Console.WriteLine($" le matricule: {matricule}, Nom Complet:  {firstName} {lastName}, Age: {age} ans, Moyenne: {moyenne}");
    }

    //Methode de mise a jour 
    public void DefinirMoyenne(double moy)
    {
        if (moy >= 0 && moy <= 20)
        {
            moyenne = moy;
        }
    }
}