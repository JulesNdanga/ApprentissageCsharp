using System;

/**
 * Gestion des Exception
 * **/

namespace Division
{
    
    class Divis : Exception
    {
        static int Diviser(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Division par 0 impossible");
            }
            return a / b;
        }
        static void Main(string[] args)
        {
            int resultat;
            int nbre1;
            int nbre2;

            try
            {
                Console.WriteLine("Entre le 1er nombre");
                nbre1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre le 2e nombre");
                nbre2 = int.Parse(Console.ReadLine());
                resultat = Diviser(nbre1, nbre2);
                Console.WriteLine("Le résultat est égal à " + resultat);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Une erreur s’est produite");
                Console.ReadKey();
            }
            
        }
    }
}
