using System;
/**
 * Projet qui illustre l'utilisation des types génériques
 * **/

namespace Couple
{
   class Personne
    {
        private string Nom;
        public Personne(string Nom)
        {
            this.Nom = Nom;
        }
        public string getNom()
        {
            return this.Nom;
        }
    }
    class Couple<T>
    {
        private T premier;
        private T deuxième;
        public Couple(T premier, T deuxième)
        {
            this.premier = premier;
            this.deuxième = deuxième;
        }
        public T Premier
        {
            get { return this.premier; }
        }
        public T Deuxième
        {
            get { return this.deuxième; }
        }

       
    }
    class Menu
    {
        static void Main(string[] args)
        {
            Personne p1;
            Personne p2;
            // Déclaration d’un couple de Personne
            Couple<Personne> couple;
            p1 = new Personne("Aurélie");
            p2 = new Personne("Gilles");
            // Instanciation d’une couple de Personne
            couple = new Couple<Personne>(p1, p2);
            // Affichage du nom de la première personne
            Console.WriteLine(couple.Premier.getNom());
            // Affichage du nom de la deuxième personne
            Console.WriteLine(couple.Deuxième.getNom());
            Console.ReadKey();
        }
    }
}
