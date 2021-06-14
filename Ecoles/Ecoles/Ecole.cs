using System;
/**
 * Principe de d'heritage
 * On creer La classe Person
 * Les classes Eleve et Professeur hérites de Person
 * **/
//La classe Person
class Person
{
    protected int age;
    public void Bonjour()
    {
        Console.WriteLine("Bonjour");
    }
    public void SetAge(int n)
    {
        age = n;
    }
}
//La classe Student
class Eleve : Person
{
    public void AllerEnClasse()
    {
        Console.WriteLine("Je vais en classe");
    }
    public void AfficherAge()
    {
        Console.WriteLine("Mon age est: {0} ans", age);
    }
}
//La classe Teacher
class Professeur : Person
{
    private string cours;
    public void Explicat()
    {
        Console.WriteLine("L'explication du cours commence");
    }
}
//Classe de test
class Ecole
{
    static void Main()
    {
        Person p = new Person();
        p.Bonjour();
        Eleve s = new Eleve();
        s.AllerEnClasse();
        s.SetAge(15);
        s.Bonjour();
        s.AfficherAge();
        Professeur t = new Professeur();
        t.SetAge(40);
        t.Bonjour();
        t.Explicat();
        Console.ReadKey();
    }
}