using System;
using System.Collections.Generic;
using System.Text;

namespace Justicier
{
    class Candidat
    {
        private string nom, surnom, pouvoir;
        private bool accepter;


        public bool EstSelectionne()
        {
            return accepter;
        }

        public void Afficher()
        {
            Console.WriteLine("Surnom : "+surnom+" \nNom : "+nom+" \nSuper pouvoir : "+pouvoir);
        }

        public void Accepter()
        {
            accepter = true;
        }

        public void Refuser()
        {
            accepter = false;
        }

        public void Initialiser(string _surnom, string _nom, string _pouvoir)
        {
            nom = _nom;
            surnom = _surnom;
            pouvoir = _pouvoir;
        }

        public string GetSurnom()
        {
            return surnom;
        }
    }
}
