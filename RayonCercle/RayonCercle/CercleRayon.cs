using System;

/**
 * On calcul l'aire et le prérimètre d'un cercle
 * **/

class Cercle
{
    public double Rayon;

    public Cercle(double rayon)
    {
        Rayon = rayon;
    }

    public double GetAire()
    {
        return Rayon * Rayon * Math.PI;
    }

    public double GetPerimetre()
    {
        return 2 * Rayon * Math.PI;
    }
}

public class CercleRayon
{
    public static void Main()
    {
        var c = new Cercle(6.25);
        Console.WriteLine("L'aire de ce cercle est: "+c.GetAire()+" et son périmètre est "+ c.GetPerimetre());
        Console.ReadKey();
    }
}