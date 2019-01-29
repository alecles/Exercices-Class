using System;
using Exercices_Class;

namespace Exercices_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            PremierJet();
            SecondJet();
            TroisiemeJet(5);
            QuatriemeJet(79);
            CinquiemeJet();
        }

        static void PremierJet()
        {
            int resultat = 0;
            

            De d4 = new De();
            d4.Initialiser(4);

            d4.LancerDe();
            resultat = d4.GetValeur();

            d4.LancerDe();
            resultat = d4.GetValeur();

            resultat += 4;

            Console.WriteLine("Premier Jet: " +resultat);


        }

        static void SecondJet()
        {
            int resultat1 = 0;
            int resultat2 = 0;
            int resultat3 = 0;
            int resultat4 = 0;
            int resultat5 = 0;
            int resultat6 = 0;
            int resultat = 0;

            De d61 = new De();
            d61.Initialiser(6);

            De d62 = new De();
            d62.Initialiser(6);

            De d63 = new De();
            d63.Initialiser(6);

            d61.LancerDe();
            d62.LancerDe();
            d63.LancerDe();

            resultat1 = d61.GetValeur() + d62.GetValeur() + d63.GetValeur();

            d61.LancerDe();
            d62.LancerDe();
            d63.LancerDe();

            resultat2 = d61.GetValeur() + d62.GetValeur() + d63.GetValeur();

            d61.LancerDe();
            d62.LancerDe();
            d63.LancerDe();

            resultat3 = d61.GetValeur() + d62.GetValeur() + d63.GetValeur();

            d61.LancerDe();
            d62.LancerDe();
            d63.LancerDe();

            resultat4 = d61.GetValeur() + d62.GetValeur() + d63.GetValeur();

            d61.LancerDe();
            d62.LancerDe();
            d63.LancerDe();

            resultat5 = d61.GetValeur() + d62.GetValeur() + d63.GetValeur();

            d61.LancerDe();
            d62.LancerDe();
            d63.LancerDe();

            resultat6 = d61.GetValeur() + d62.GetValeur() + d63.GetValeur();

            resultat = resultat1 + resultat2 + resultat3 + resultat4 + resultat5 + resultat6;

            Console.WriteLine("Deuxième Jet: " + resultat);
        }

        static void TroisiemeJet(int bonus)
        {
            int resultat = 0;

            De d8 = new De();
            d8.Initialiser(6);
            d8.LancerDe();
            resultat = d8.GetValeur() + bonus;

            Console.WriteLine("Troisième Jet: " + resultat);

        }

        static void QuatriemeJet(int succes)
        {                     
            string resultatString1 = "";
            string resultatString2 = "";
            string resultat1 = "";
            int resultat = 0;
            bool fin = false;

            De d10 = new De();
            d10.Initialiser(10);

            while (fin == false)
            {
                d10.LancerDe();
                int resultatInt1 = d10.GetValeur();

                d10.LancerDe();
                int resultatInt2 = d10.GetValeur();

                resultatString1 = Convert.ToString(resultatInt1);
                resultatString2 = Convert.ToString(resultatInt2);

                resultat1 = resultatString1 + resultatString2;
                resultat = Convert.ToInt32(resultat1);

                if (resultat <= succes)
                {
                    fin = true;
                }
            }

            Console.WriteLine("Quatrième Jet: " + resultat);
        }

        static void CinquiemeJet()
        {
            De d20 = new De();
            bool check = false;
            int i = 0;
            int resultat = 0;

            d20.Initialiser(20);

            while (check == false)
            {
                d20.LancerDe();
                resultat = d20.GetValeur();

                if (resultat == 1)
                {
                    check = true;
                }
                else if (resultat == 20)
                {
                    check = true;
                }
                i++;
            }
            if (resultat == 1)
            {
                Console.WriteLine("(5) Nombre de fois lançés : " + i + " : RÉSULTAT : " + resultat + " ----> ÉCHEC");
            }
            else if (resultat == 20)
            {
                Console.WriteLine("(5) Nombre de fois lançés : " + i + " : RÉSULTAT : " + resultat + "----> RÉUSSITE");
            }
        }
    }
}
