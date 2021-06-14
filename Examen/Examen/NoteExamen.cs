using System;


namespace LivrableOne
{
    /**
     * calcule de la moyenned’une série de notes d’examen
     * **/
    class NoteExamen
    {


        /**
         * Fonction qui calcule la moyenne des notes 
         * 
         * **/
        public static float CalculMoyenNote(float[] notes)
        {
            float total = 0;
            float moyen;

            for (int i = 0; i < notes.Length; i++)
            {
                total = total + notes[i];
            }
            moyen = total / notes.Length;
            return moyen;
        }

        /**
         * Fonction qui Remplie les notes
         * 
         * **/
        public static float[] Remplir(float[] notes)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine("Entrer la note n°" + i);
                string note = Console.ReadLine();
                notes[i] = float.Parse(note);
            }
            return notes;
        }

        /**
         * Fonction qui affiche les notes
         * 
         * **/
        public static void Affiche(float[] notes)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                Console.Write(" | " + notes[i]);
            }
        }

        static void Main(string[] args)
        {
            float[] notes;
            float moyenne;
            notes = new float[10];
            notes = Remplir(notes);
            Affiche(notes);

            moyenne = CalculMoyenNote(notes);

            Console.WriteLine("| La moyenne des ces notes est: " + moyenne);

            /*
             * J'utilise la fonction ReadKey à cause d'un problème d'affichage que j'ai eu
             * La console se fermer immédiatement après être ouverte
             * **/
            Console.ReadKey(true); //attend que l'utilisateur appuie sur Entrée
        }
    }

}
