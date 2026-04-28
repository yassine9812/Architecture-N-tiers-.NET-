using System;
 
public class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
 
    // Constructeur
    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
 
    // Méthode
    public void Display()
    {
        Console.WriteLine("Nom complet: " + firstName + " " + lastName + ", Age: " + age + " ans");
    }
}