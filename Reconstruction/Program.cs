using System;

namespace Reconstruction
{
    class Program
    {
        static void AfficherRue1(Batiment[] rue)
        {
            Console.WriteLine("\nAfficher rue, méthode #1");

            foreach (Batiment batiment in rue)
                batiment.Afficher();
        }

        static void AfficherRue2(Batiment[] rue)
        {
            Console.WriteLine("\nAfficher rue, méthode #2");

            foreach (Batiment batiment in rue)
                Console.WriteLine(batiment.GetNom() + " (" + batiment.GetTypeBatiment() + ")");
        }

        static void Main(string[] args)
        {
            Batiment[] ruePr = new Batiment[3];
            Batiment[] rueSec = new Batiment[2];

            Batiment maison = new Batiment();
            maison.Initialiser("Maison de Hank Jones", 6, 20000, 60, 70, TypeBatiment.Residance);
            ruePr[0] = maison;

            Batiment buanderie = new Batiment();
            buanderie.Initialiser("Buanderie Tremblay", 2, 16000, 30, 40, TypeBatiment.Commercial);
            ruePr[1] = buanderie;

            Batiment musee = new Batiment();
            musee.Initialiser("Musée Marvel", 12, 32000, 180, 120, TypeBatiment.Musee);
            ruePr[2] = musee;

            Batiment corp = new Batiment();
            corp.Initialiser("101 Corp", 24, 36000, 50, 60, TypeBatiment.Musee);
            rueSec[0] = corp;

            Batiment lavoto = new Batiment();
            lavoto.Initialiser("LAV-O-2000", 3, 18000, 40, 50, TypeBatiment.Commercial);
            rueSec[1] = lavoto;

            AfficherRue1(ruePr);
            AfficherRue2(rueSec);
            Console.ReadKey();
        }
    }
}
