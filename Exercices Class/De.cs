using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_Class
{
    class De
    {
        private int valeur;
        private int nbFaces;
        private Random rnd;

        public void Initialiser(int _nbFaces)
        {
            nbFaces = _nbFaces;
            rnd = new Random();
            LancerDe();
        }

        public void LancerDe()
        {
            valeur = ((int)rnd.Next(nbFaces)) + 1;
        }

        public int GetValeur()
        {
            return valeur;
        }
    }
}


